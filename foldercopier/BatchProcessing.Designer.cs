namespace foldercopier
{
    partial class BatchProcessing
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_physical_files = new System.Windows.Forms.Label();
            this.lbl_db_queue = new System.Windows.Forms.Label();
            this.lbl_in_database = new System.Windows.Forms.Label();
            this.lbl_processed = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find All Files in Source Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Physical Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File in Databas Queue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Files in Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Files Processed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Files Error";
            // 
            // lbl_physical_files
            // 
            this.lbl_physical_files.AutoSize = true;
            this.lbl_physical_files.Location = new System.Drawing.Point(115, 47);
            this.lbl_physical_files.Name = "lbl_physical_files";
            this.lbl_physical_files.Size = new System.Drawing.Size(55, 13);
            this.lbl_physical_files.TabIndex = 6;
            this.lbl_physical_files.Text = "                ";
            // 
            // lbl_db_queue
            // 
            this.lbl_db_queue.AutoSize = true;
            this.lbl_db_queue.Location = new System.Drawing.Point(130, 72);
            this.lbl_db_queue.Name = "lbl_db_queue";
            this.lbl_db_queue.Size = new System.Drawing.Size(55, 13);
            this.lbl_db_queue.TabIndex = 7;
            this.lbl_db_queue.Text = "                ";
            // 
            // lbl_in_database
            // 
            this.lbl_in_database.AutoSize = true;
            this.lbl_in_database.Location = new System.Drawing.Point(106, 100);
            this.lbl_in_database.Name = "lbl_in_database";
            this.lbl_in_database.Size = new System.Drawing.Size(55, 13);
            this.lbl_in_database.TabIndex = 8;
            this.lbl_in_database.Text = "                ";
            // 
            // lbl_processed
            // 
            this.lbl_processed.AutoSize = true;
            this.lbl_processed.Location = new System.Drawing.Point(99, 126);
            this.lbl_processed.Name = "lbl_processed";
            this.lbl_processed.Size = new System.Drawing.Size(55, 13);
            this.lbl_processed.TabIndex = 9;
            this.lbl_processed.Text = "                ";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(71, 154);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(55, 13);
            this.lbl_error.TabIndex = 10;
            this.lbl_error.Text = "                ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BatchProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 262);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_processed);
            this.Controls.Add(this.lbl_in_database);
            this.Controls.Add(this.lbl_db_queue);
            this.Controls.Add(this.lbl_physical_files);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "BatchProcessing";
            this.Text = "BatchProcessing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_physical_files;
        private System.Windows.Forms.Label lbl_db_queue;
        private System.Windows.Forms.Label lbl_in_database;
        private System.Windows.Forms.Label lbl_processed;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Timer timer1;
    }
}