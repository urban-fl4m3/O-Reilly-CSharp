
namespace Chapter3_Program2
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
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.giveCashToJoeButton = new System.Windows.Forms.Button();
            this.receiveFromBobButton = new System.Windows.Forms.Button();
            this.joeGivesCashToBobButton = new System.Windows.Forms.Button();
            this.bobGivesCashToJoeButton = new System.Windows.Forms.Button();
            this.saveJoe = new System.Windows.Forms.Button();
            this.loadJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(190, 97);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(78, 17);
            this.joesCashLabel.TabIndex = 0;
            this.joesCashLabel.Text = "Joe has $0";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(193, 136);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(80, 17);
            this.bobsCashLabel.TabIndex = 1;
            this.bobsCashLabel.Text = "Bob has $0";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(193, 172);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(115, 17);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "The bank has $0";
            // 
            // giveCashToJoeButton
            // 
            this.giveCashToJoeButton.Location = new System.Drawing.Point(126, 222);
            this.giveCashToJoeButton.Name = "giveCashToJoeButton";
            this.giveCashToJoeButton.Size = new System.Drawing.Size(133, 66);
            this.giveCashToJoeButton.TabIndex = 3;
            this.giveCashToJoeButton.Text = "Give $10 to Joe";
            this.giveCashToJoeButton.UseVisualStyleBackColor = true;
            this.giveCashToJoeButton.Click += new System.EventHandler(this.giveCashToJoeButton_Click);
            // 
            // receiveFromBobButton
            // 
            this.receiveFromBobButton.Location = new System.Drawing.Point(283, 222);
            this.receiveFromBobButton.Name = "receiveFromBobButton";
            this.receiveFromBobButton.Size = new System.Drawing.Size(133, 66);
            this.receiveFromBobButton.TabIndex = 4;
            this.receiveFromBobButton.Text = "Receive $5 from Bob";
            this.receiveFromBobButton.UseVisualStyleBackColor = true;
            this.receiveFromBobButton.Click += new System.EventHandler(this.receiveFromBobButton_Click);
            // 
            // joeGivesCashToBobButton
            // 
            this.joeGivesCashToBobButton.Location = new System.Drawing.Point(126, 307);
            this.joeGivesCashToBobButton.Name = "joeGivesCashToBobButton";
            this.joeGivesCashToBobButton.Size = new System.Drawing.Size(133, 66);
            this.joeGivesCashToBobButton.TabIndex = 5;
            this.joeGivesCashToBobButton.Text = "Joe gives $10 to Bob";
            this.joeGivesCashToBobButton.UseVisualStyleBackColor = true;
            this.joeGivesCashToBobButton.Click += new System.EventHandler(this.joeGivesCashToBobButton_Click);
            // 
            // bobGivesCashToJoeButton
            // 
            this.bobGivesCashToJoeButton.Location = new System.Drawing.Point(283, 307);
            this.bobGivesCashToJoeButton.Name = "bobGivesCashToJoeButton";
            this.bobGivesCashToJoeButton.Size = new System.Drawing.Size(133, 66);
            this.bobGivesCashToJoeButton.TabIndex = 6;
            this.bobGivesCashToJoeButton.Text = "Bob gives $5 to Joe";
            this.bobGivesCashToJoeButton.UseVisualStyleBackColor = true;
            this.bobGivesCashToJoeButton.Click += new System.EventHandler(this.bobGivesCashToJoeButton_Click);
            // 
            // saveJoe
            // 
            this.saveJoe.Location = new System.Drawing.Point(126, 392);
            this.saveJoe.Name = "saveJoe";
            this.saveJoe.Size = new System.Drawing.Size(133, 46);
            this.saveJoe.TabIndex = 7;
            this.saveJoe.Text = "Save Joe";
            this.saveJoe.UseVisualStyleBackColor = true;
            this.saveJoe.Click += new System.EventHandler(this.saveJoe_Click);
            // 
            // loadJoe
            // 
            this.loadJoe.Location = new System.Drawing.Point(283, 392);
            this.loadJoe.Name = "loadJoe";
            this.loadJoe.Size = new System.Drawing.Size(133, 46);
            this.loadJoe.TabIndex = 8;
            this.loadJoe.Text = "Load Joe";
            this.loadJoe.UseVisualStyleBackColor = true;
            this.loadJoe.Click += new System.EventHandler(this.loadJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.loadJoe);
            this.Controls.Add(this.saveJoe);
            this.Controls.Add(this.bobGivesCashToJoeButton);
            this.Controls.Add(this.joeGivesCashToBobButton);
            this.Controls.Add(this.receiveFromBobButton);
            this.Controls.Add(this.giveCashToJoeButton);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button giveCashToJoeButton;
        private System.Windows.Forms.Button receiveFromBobButton;
        private System.Windows.Forms.Button joeGivesCashToBobButton;
        private System.Windows.Forms.Button bobGivesCashToJoeButton;
        private System.Windows.Forms.Button saveJoe;
        private System.Windows.Forms.Button loadJoe;
    }
}

