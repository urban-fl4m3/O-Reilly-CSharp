﻿
namespace Chapter9_Program2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.folder = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.random = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.excuse = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.TextBox();
            this.fileDate = new System.Windows.Forms.TextBox();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excuse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "File date";
            // 
            // folder
            // 
            this.folder.Location = new System.Drawing.Point(25, 230);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(158, 23);
            this.folder.TabIndex = 4;
            this.folder.Text = "Folder";
            this.folder.UseVisualStyleBackColor = true;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(189, 230);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(158, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Enabled = false;
            this.open.Location = new System.Drawing.Point(353, 230);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(158, 23);
            this.open.TabIndex = 6;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // random
            // 
            this.random.Enabled = false;
            this.random.Location = new System.Drawing.Point(517, 230);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(158, 23);
            this.random.TabIndex = 7;
            this.random.Text = "Random";
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.random_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text file (*.txt)|*.txt|All filed|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // excuse
            // 
            this.excuse.Location = new System.Drawing.Point(123, 35);
            this.excuse.Name = "excuse";
            this.excuse.Size = new System.Drawing.Size(440, 22);
            this.excuse.TabIndex = 8;
            this.excuse.TextChanged += new System.EventHandler(this.excuse_TextChanged);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(123, 78);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(440, 22);
            this.results.TabIndex = 9;
            this.results.TextChanged += new System.EventHandler(this.results_TextChanged);
            // 
            // fileDate
            // 
            this.fileDate.Location = new System.Drawing.Point(123, 170);
            this.fileDate.Name = "fileDate";
            this.fileDate.Size = new System.Drawing.Size(440, 22);
            this.fileDate.TabIndex = 11;
            // 
            // lastUsed
            // 
            this.lastUsed.Location = new System.Drawing.Point(123, 124);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(440, 22);
            this.lastUsed.TabIndex = 12;
            this.lastUsed.ValueChanged += new System.EventHandler(this.lastUsed_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 275);
            this.Controls.Add(this.lastUsed);
            this.Controls.Add(this.fileDate);
            this.Controls.Add(this.results);
            this.Controls.Add(this.excuse);
            this.Controls.Add(this.random);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button folder;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button random;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox excuse;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.TextBox fileDate;
        private System.Windows.Forms.DateTimePicker lastUsed;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

