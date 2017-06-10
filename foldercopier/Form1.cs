using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foldercopier
{
    public partial class Form1 : Form
    {
        private String srcPath;
        private String dstPath;
        private String templatePath;
        private String conversionPath;
        private Boolean isCreatingDate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void enableSartButton()
        {
            if (!String.IsNullOrEmpty(srcPath) && !String.IsNullOrEmpty(dstPath)
                && !String.IsNullOrEmpty(templatePath) && !String.IsNullOrEmpty(conversionPath))
                btnStart.Enabled = true;
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
    }
}
