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
                && !String.IsNullOrEmpty(templatePath) && !String.IsNullOrEmpty(conversionPath))
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
            if (isCreatingDate)
                actualDstPath = createFolder(true);
            else
                actualDstPath = createFolder(false);

        }

        private String createFolder(bool hasDate)
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
    }
}
