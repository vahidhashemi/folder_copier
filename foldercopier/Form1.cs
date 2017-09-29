using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

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
        private String txtBaseUrl = "Enter Image Server Base URL e.g: http://192.168.1.1/img/";
        private Dictionary<String, String>  convertTable = new Dictionary<string, string>();
        private String convertSeparator = "->";
        private List<Dictionary<String, String>>  conversions = new List<Dictionary<string, string>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isStarted = false;
            btnStart.Enabled = false;
            txtImgBaseUrl.Text = "Enter Image Server Base URL e.g: http://192.168.1.1/img/";
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
                fillConversionTable(conversionPath);
                enableSartButton();
                //                MessageBox.Show(templatePath);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Copier copier = new Copier(conversions, templatePath, txtImgBaseUrl.Text);
                copier.doCopy(dstPath, dstImagePath, srcPath, isCreatingDate);
            }
            catch (Exception ex)
            {

                log("Error : " + ex.Message);
            }
            
        }



        private void fillConversionTable(string convertFile)
        {
            String[] conversionTable = System.IO.File.ReadAllLines(convertFile);
            foreach (string line in conversionTable)
            {
                String[] data = line.Split(new []{convertSeparator}, StringSplitOptions.None);
                
                String oldTag = data[0];
                String newTag = data[1];
                conversions.Add(new Dictionary<string, string>(){{oldTag, newTag}});

                int i = 0;
            }
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

        private void txtImgBaseUrl_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtImgBaseUrl_Enter(object sender, EventArgs e)
        {
            
            if (txtImgBaseUrl.Text.Length == 0 ||
                txtImgBaseUrl.Text.Equals(txtBaseUrl))
                txtImgBaseUrl.Text = "";

        }

        private void txtImgBaseUrl_Leave(object sender, EventArgs e)
        {
            if (txtImgBaseUrl.Text.Length == 0)
                txtImgBaseUrl.Text = txtBaseUrl;

        }

        private void log(String message)
        {
            lstLog.Items.Add(message);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
