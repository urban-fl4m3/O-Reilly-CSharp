
namespace Chapter4_Program3
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
            this.LloydButton = new System.Windows.Forms.Button();
            this.LucindaButton = new System.Windows.Forms.Button();
            this.SwapButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LloydButton
            // 
            this.LloydButton.Location = new System.Drawing.Point(157, 40);
            this.LloydButton.Name = "LloydButton";
            this.LloydButton.Size = new System.Drawing.Size(149, 54);
            this.LloydButton.TabIndex = 0;
            this.LloydButton.Text = "Lloyd";
            this.LloydButton.UseVisualStyleBackColor = true;
            this.LloydButton.Click += new System.EventHandler(this.LloydButton_Click);
            // 
            // LucindaButton
            // 
            this.LucindaButton.Location = new System.Drawing.Point(157, 118);
            this.LucindaButton.Name = "LucindaButton";
            this.LucindaButton.Size = new System.Drawing.Size(149, 54);
            this.LucindaButton.TabIndex = 1;
            this.LucindaButton.Text = "Lucinda";
            this.LucindaButton.UseVisualStyleBackColor = true;
            this.LucindaButton.Click += new System.EventHandler(this.LucindaButton_Click);
            // 
            // SwapButton
            // 
            this.SwapButton.Location = new System.Drawing.Point(157, 192);
            this.SwapButton.Name = "SwapButton";
            this.SwapButton.Size = new System.Drawing.Size(149, 54);
            this.SwapButton.TabIndex = 2;
            this.SwapButton.Text = "Swap";
            this.SwapButton.UseVisualStyleBackColor = true;
            this.SwapButton.Click += new System.EventHandler(this.SwapButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dont\' touch!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SwapButton);
            this.Controls.Add(this.LucindaButton);
            this.Controls.Add(this.LloydButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LloydButton;
        private System.Windows.Forms.Button LucindaButton;
        private System.Windows.Forms.Button SwapButton;
        private System.Windows.Forms.Button button1;
    }
}

