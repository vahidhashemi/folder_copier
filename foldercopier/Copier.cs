using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace foldercopier
{
    class Copier
    {
        private List<Dictionary<String, String>> conversions;
        private HtmlDocument htmlTemplate;
        private String baseUrl;

        public Copier(List<Dictionary<String, String>> conversions,String templatePath, String baseUrl )
        {
            this.conversions = conversions;
            htmlTemplate = new HtmlAgilityPack.HtmlDocument();
            htmlTemplate.Load(templatePath);
            this.baseUrl = baseUrl;


        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void doCopy(String dstPath, String dstImagePath, String srcPath, bool isCreatingDate)
        {
            String actualDstPath;
            String actualImagePath;
            if (isCreatingDate)
                actualDstPath = createFolder(dstPath, true);
            else
                actualDstPath = createFolder(dstPath, false);
            // there will be two different path. Make sure to behave the same for image path
            if (!dstImagePath.Equals(dstPath))
            {
                if (isCreatingDate)
                    actualImagePath = createFolder(dstImagePath, true);
                else
                    actualImagePath = createFolder(dstImagePath, false);
            }
            else
            {
                actualImagePath = actualDstPath;
            }

            String[] files = Directory.GetFiles(srcPath);

            foreach (var file in files)
            {
                String ext = Path.GetExtension(file).ToLower();
                if (ext.Contains(".jpg") || ext.Contains(".jpeg"))
                {

                    try
                    {
                        File.Copy(file, Path.Combine(actualImagePath, Path.GetFileName(file)));
                    }
                    catch (IOException ex)
                    {
                        File.Copy(file, Path.Combine(actualImagePath, Path.GetFileName(file)), true);
                        log("Warnning : " + file + " Replaced");
                    }

                }
                else
                {
                    try
                    {
                        //Before copying file we have to change the template
                        changeTemplate(file, Path.Combine(actualDstPath, Path.GetFileName(file)));
                        //                        File.Copy(file, Path.Combine(actualDstPath, Path.GetFileName(file)));
                    }
                    catch (Exception)
                    {

                        changeTemplate(file, Path.Combine(actualDstPath, Path.GetFileName(file)));
                        log("Warnning : " + file + " Replaced");
                    }

                }
                File.Delete(file);
            }
        }

        private String changeTemplate(String oldFilePath, String newFilePath)
        {
            var html = new HtmlAgilityPack.HtmlDocument();
            html.Load(oldFilePath);
            foreach (var conversion in conversions)
            {
                String oldTag = conversion.ElementAt(0).Key;
                String newTag = conversion.ElementAt(0).Value;

                if (oldTag.Trim().Equals("[img]"))
                {
                    String imgFile = Path.GetFileName(newFilePath);
                    imgFile = imgFile.Replace(".htm", ".jpg");
                    imgFile = imgFile.Replace(".html", ".jpg");
                    String newFileName = baseUrl + getCurrentDateForWeb() + imgFile;
                    htmlTemplate.DocumentNode
                        .SelectNodes(newTag.Trim())
                        .First()
                        .Attributes["src"].Value = newFileName;
                }
                else
                {
                    String oldHtmlData = html.DocumentNode
                    .SelectNodes(oldTag.Trim())
                    .First()
                    .Attributes["value"].Value;

                    htmlTemplate.DocumentNode
                        .SelectNodes(newTag.Trim())
                        .First()
                        .Attributes["value"].Value = oldHtmlData;
                }

            }
            using (FileStream fs = new FileStream(newFilePath, FileMode.Create))
            {
                Stream stream = GenerateStreamFromString(htmlTemplate.DocumentNode.OuterHtml);

                byte[] bytesInStream = new byte[stream.Length];
                stream.Read(bytesInStream, 0, bytesInStream.Length);
                // Use write method to write to the file specified above
                fs.Write(bytesInStream, 0, bytesInStream.Length);
            }

            return "";
        }

        private String getCurrentDateForWeb()
        {
            String year = DateTime.Now.Year + "";
            String month = DateTime.Now.Month + "";
            String day = DateTime.Now.Day + "";
            return year + "/" + month + "/" + day + "/";
        }

        private String createFolder(String dstPath, bool hasDate)
        {
            String actualPath;
            if (hasDate)
            {
                String yearPath = Path.Combine(dstPath, DateTime.Now.Year + "");
                String monthPath = Path.Combine(yearPath, DateTime.Now.Month + "");
                String dayPath = Path.Combine(monthPath, DateTime.Now.Day + "");

                if (!Directory.Exists(yearPath))
                    Directory.CreateDirectory(yearPath);
                if (!Directory.Exists(monthPath))
                    Directory.CreateDirectory(monthPath);
                if (!Directory.Exists(dayPath))
                    Directory.CreateDirectory(dayPath);
                return dayPath;
            }
            return dstPath;
        }

        public Stream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream, Encoding.GetEncoding(1256));
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        private void log(String message)
        {
//            lstLog.Items.Add(message);
        }

    }
}
