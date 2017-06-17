using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foldercopier
{
    public partial class Form1 : Form, IAnswer
    {
        private String srcPath;
        private String dstPath;
        private String dstImagePath;
        private String templatePath;
        private String conversionPath;
        private Boolean isCreatingDate;
        private String formTitle = "Folder Copier";
        private Boolean isStarted = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isStarted = false;
            btnStart.Enabled = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lblSrc.Text = folderBrowserDialog1.SelectedPath;
                srcPath = folderBrowserDialog1.SelectedPath;
                enableSartButton();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            isCreatingDate = checkBox1.Checked;
            if (btnStart.Text.ToLower().Equals("start"))
            {
                InputBox inputbox = new InputBox();
                inputbox.setAnswer(this);
                inputbox.ShowDialog(this);
                timer1.Enabled = true;
                btnStart.Text = "Stop";
            }
            else //Stop Clicked
            {
                timer1.Enabled = false;
                btnStart.Text = "Start";
                this.Text = formTitle + " | Not Working";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void enableSartButton()
        {
            if (!String.IsNullOrEmpty(srcPath) && !String.IsNullOrEmpty(dstPath)
                && !String.IsNullOrEmpty(templatePath) && !String.IsNullOrEmpty(conversionPath)
                && !String.IsNullOrEmpty(dstImagePath))
            {
                btnStart.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lblDst.Text = folderBrowserDialog1.SelectedPath;
                dstPath = folderBrowserDialog1.SelectedPath;
                enableSartButton();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "HTML |*.html;*.htm";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                templatePath = openFileDialog1.FileName;
                enableSartButton();
//                MessageBox.Show(templatePath);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Convesion Table |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                conversionPath = openFileDialog1.FileName;
                enableSartButton();
                //                MessageBox.Show(templatePath);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
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
                    File.Copy(file, Path.Combine(actualImagePath, Path.GetFileName(file)));
                }
                else
                {
                    File.Copy(file, Path.Combine(actualDstPath, Path.GetFileName(file)));
                }
                File.Delete(file);
            }
        }

        private String createFolder(String dstPath, bool hasDate)
        {
            String actualPath;
            if (hasDate)
            {
                String yearPath = Path.Combine(dstPath , DateTime.Now.Year + "");
                String monthPath = Path.Combine(yearPath , DateTime.Now.Month + "");
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


        public void answer(string title)
        {
            // after getting data from job title. We will enable timer to do it is job
            if (String.IsNullOrEmpty(title))
                MessageBox.Show("Please choose a job Title");
            else
            {
                this.Text = formTitle + " | " + title;
                timer1.Enabled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lblImageDst.Text = folderBrowserDialog1.SelectedPath;
                dstImagePath = folderBrowserDialog1.SelectedPath;
                enableSartButton();
            }
        }
    }
}
