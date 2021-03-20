
namespace Chapter5_Program1
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.fancyDecorationsCheckbox = new System.Windows.Forms.CheckBox();
            this.healthDecorationsCheckbox = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(44, 38);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fancyDecorationsCheckbox
            // 
            this.fancyDecorationsCheckbox.AutoSize = true;
            this.fancyDecorationsCheckbox.Checked = true;
            this.fancyDecorationsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyDecorationsCheckbox.Location = new System.Drawing.Point(44, 77);
            this.fancyDecorationsCheckbox.Name = "fancyDecorationsCheckbox";
            this.fancyDecorationsCheckbox.Size = new System.Drawing.Size(148, 21);
            this.fancyDecorationsCheckbox.TabIndex = 2;
            this.fancyDecorationsCheckbox.Text = "Fancy Decorations";
            this.fancyDecorationsCheckbox.UseVisualStyleBackColor = true;
            this.fancyDecorationsCheckbox.CheckedChanged += new System.EventHandler(this.fancyDecorationsCheckbox_CheckedChanged);
            // 
            // healthDecorationsCheckbox
            // 
            this.healthDecorationsCheckbox.AutoSize = true;
            this.healthDecorationsCheckbox.Location = new System.Drawing.Point(44, 117);
            this.healthDecorationsCheckbox.Name = "healthDecorationsCheckbox";
            this.healthDecorationsCheckbox.Size = new System.Drawing.Size(158, 21);
            this.healthDecorationsCheckbox.TabIndex = 3;
            this.healthDecorationsCheckbox.Text = "Healthy Decorations";
            this.healthDecorationsCheckbox.UseVisualStyleBackColor = true;
            this.healthDecorationsCheckbox.CheckedChanged += new System.EventHandler(this.healthDecorationsCheckbox_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(108, 183);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(2, 19);
            this.costLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 275);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.healthDecorationsCheckbox);
            this.Controls.Add(this.fancyDecorationsCheckbox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox fancyDecorationsCheckbox;
        private System.Windows.Forms.CheckBox healthDecorationsCheckbox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label2;
    }
}

