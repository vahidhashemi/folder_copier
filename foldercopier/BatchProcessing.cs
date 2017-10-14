using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foldercopier
{
    public partial class BatchProcessing : Form
    {
        private BlockingCollection<FilePath> files = new BlockingCollection<FilePath>();
        private BlockingCollection<FileResult> queueProcess = new BlockingCollection<FileResult>();

        public BatchProcessing()
        {
            InitializeComponent();
        }

        private void initThreads()
        {
            Thread getFiles = new Thread(getAllFiles);
            getFiles.Start();
            Thread pfile = new Thread(process);
            pfile.Start();
//            Thread saveFilesInfo = new Thread(saveToDb);
//            saveFilesInfo.Start();

//            List<Thread> processFileThreads = new List<Thread>();
//            for (int i = 0; i < 10; i++)
//            {
//                processFileThreads.Add(new Thread(() => process(i)));
//                processFileThreads[i].Start();
//                
//            }

           
        }

        private void saveToDb()
        {
            DataBase db = new DataBase();
            long i = 0;

            while (true)
            {
                FilePath file = null;
                files.TryTake(out file);
                lbl_db_queue.Invoke((Action) delegate { lbl_db_queue.Text = files.Count.ToString(); });
                if (file != null)
                {
                    i++;
                    if (i%10 == 0)
                        lbl_in_database.Invoke((Action) delegate { lbl_in_database.Text = i.ToString(); });
                    db.add(file);
                }
                else
                {
                    Thread.Sleep(5000);
                }
            }
        }

      

        private void getAllFiles()
        {
            //            string[] allfiles = System.IO.Directory.GetFiles(@"C:\arta_src", "*.*", System.IO.SearchOption.AllDirectories);
            long i = 0;
            foreach (string file in Directory.EnumerateFiles(Form1.srcPath, "*.htm", SearchOption.AllDirectories))
            {
                
                files.Add(new FilePath(file, (i % 10).ToString()));
                i++;
                if ( i % 100 ==0 )
                    lbl_physical_files.Invoke((Action) delegate { lbl_physical_files.Text = i.ToString(); });
            }
        }

        public void process()
        {
//            DataBase db = new DataBase();
            while (true)
            {
                FilePath file = null;
                files.TryTake(out file);
                
                if (file != null)
                {
                    try
                    {
                        Copier copier = new Copier(Form1.conversions, Form1.templatePath, Form1.txtBaseUrl);
                        copier.doSingleCopy(Form1.dstPath, Form1.dstImagePath, file.file, Form1.isCreatingDate);
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(@"c:\etel\log\error_filename.txt", file.file + Environment.NewLine);
                        File.AppendAllText(@"c:\etel\log\error_filename_desc.txt", file.file + "-----" + ex.Message + Environment.NewLine);
                    }

                    
                }
                else
                {
                    Thread.Sleep(5000);
                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
//            DataBase dataBase = new DataBase();
//            dataBase.getDone();
            initThreads();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            lbl_processed.Text =  files.Count.ToString();
            
//            dataBase.getError();
        }
    }
}
