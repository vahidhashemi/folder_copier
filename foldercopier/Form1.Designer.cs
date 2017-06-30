namespace foldercopier
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblImageDst = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDst = new System.Windows.Forms.Label();
            this.lblSrc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtImgBaseUrl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(62, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(188, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Create Folder By Year/Month/Day";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose Source";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Choose Destination";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(364, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Select Template HTML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(62, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(364, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Select Conversion Table";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(62, 177);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(364, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.lblImageDst);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDst);
            this.groupBox1.Controls.Add(this.lblSrc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 225);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(382, 65);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblImageDst
            // 
            this.lblImageDst.AutoSize = true;
            this.lblImageDst.Location = new System.Drawing.Point(108, 68);
            this.lblImageDst.Name = "lblImageDst";
            this.lblImageDst.Size = new System.Drawing.Size(29, 13);
            this.lblImageDst.TabIndex = 6;
            this.lblImageDst.Text = "Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Image Destination:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDst
            // 
            this.lblDst.AutoSize = true;
            this.lblDst.Location = new System.Drawing.Point(79, 44);
            this.lblDst.Name = "lblDst";
            this.lblDst.Size = new System.Drawing.Size(29, 13);
            this.lblDst.TabIndex = 4;
            this.lblDst.Text = "Path";
            // 
            // lblSrc
            // 
            this.lblSrc.AutoSize = true;
            this.lblSrc.Location = new System.Drawing.Point(60, 20);
            this.lblSrc.Name = "lblSrc";
            this.lblSrc.Size = new System.Drawing.Size(29, 13);
            this.lblSrc.TabIndex = 3;
            this.lblSrc.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.Location = new System.Drawing.Point(6, 94);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(452, 121);
            this.lstLog.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(62, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(364, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Choose JPEG Image Destination";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // txtImgBaseUrl
            // 
            this.txtImgBaseUrl.Location = new System.Drawing.Point(62, 93);
            this.txtImgBaseUrl.Name = "txtImgBaseUrl";
            this.txtImgBaseUrl.Size = new System.Drawing.Size(364, 20);
            this.txtImgBaseUrl.TabIndex = 8;
            this.txtImgBaseUrl.TextChanged += new System.EventHandler(this.txtImgBaseUrl_TextChanged);
            this.txtImgBaseUrl.Enter += new System.EventHandler(this.txtImgBaseUrl_Enter);
            this.txtImgBaseUrl.Leave += new System.EventHandler(this.txtImgBaseUrl_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 436);
            this.Controls.Add(this.txtImgBaseUrl);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Folder Copier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDst;
        private System.Windows.Forms.Label lblSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblImageDst;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtImgBaseUrl;
        private System.Windows.Forms.Button btnExport;
    }
}

