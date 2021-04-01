
namespace Chapter8_Program8
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
            this.lumberjackNameText = new System.Windows.Forms.TextBox();
            this.addLumberjack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.banana = new System.Windows.Forms.RadioButton();
            this.addFlapjacks = new System.Windows.Forms.Button();
            this.nextLumberjack = new System.Windows.Forms.Button();
            this.nextInLineLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumberjack name";
            // 
            // lumberjackNameText
            // 
            this.lumberjackNameText.Location = new System.Drawing.Point(140, 13);
            this.lumberjackNameText.Name = "lumberjackNameText";
            this.lumberjackNameText.Size = new System.Drawing.Size(164, 22);
            this.lumberjackNameText.TabIndex = 1;
            // 
            // addLumberjack
            // 
            this.addLumberjack.Location = new System.Drawing.Point(16, 54);
            this.addLumberjack.Name = "addLumberjack";
            this.addLumberjack.Size = new System.Drawing.Size(288, 23);
            this.addLumberjack.TabIndex = 2;
            this.addLumberjack.Text = "Add lumberjack";
            this.addLumberjack.UseVisualStyleBackColor = true;
            this.addLumberjack.Click += new System.EventHandler(this.addLumberjack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Breakfast line";
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.ItemHeight = 16;
            this.line.Location = new System.Drawing.Point(16, 167);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(120, 356);
            this.line.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nextInLineLabel);
            this.groupBox1.Controls.Add(this.nextLumberjack);
            this.groupBox1.Controls.Add(this.addFlapjacks);
            this.groupBox1.Controls.Add(this.banana);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Location = new System.Drawing.Point(142, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 433);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a Lumberjack";
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(16, 71);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(68, 21);
            this.crispy.TabIndex = 0;
            this.crispy.TabStop = true;
            this.crispy.Text = "Crispy";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(16, 32);
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(120, 22);
            this.howMany.TabIndex = 1;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(16, 115);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(69, 21);
            this.soggy.TabIndex = 2;
            this.soggy.TabStop = true;
            this.soggy.Text = "Soggy";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(16, 160);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(84, 21);
            this.browned.TabIndex = 3;
            this.browned.TabStop = true;
            this.browned.Text = "Browned";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Location = new System.Drawing.Point(16, 202);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(78, 21);
            this.banana.TabIndex = 4;
            this.banana.TabStop = true;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // addFlapjacks
            // 
            this.addFlapjacks.Location = new System.Drawing.Point(16, 241);
            this.addFlapjacks.Name = "addFlapjacks";
            this.addFlapjacks.Size = new System.Drawing.Size(156, 23);
            this.addFlapjacks.TabIndex = 5;
            this.addFlapjacks.Text = "Add flapjacks";
            this.addFlapjacks.UseVisualStyleBackColor = true;
            this.addFlapjacks.Click += new System.EventHandler(this.addFlapjacks_Click);
            // 
            // nextLumberjack
            // 
            this.nextLumberjack.Location = new System.Drawing.Point(16, 390);
            this.nextLumberjack.Name = "nextLumberjack";
            this.nextLumberjack.Size = new System.Drawing.Size(175, 37);
            this.nextLumberjack.TabIndex = 6;
            this.nextLumberjack.Text = "Next lumberjack";
            this.nextLumberjack.UseVisualStyleBackColor = true;
            this.nextLumberjack.Click += new System.EventHandler(this.nextLumberjack_Click);
            // 
            // nextInLineLabel
            // 
            this.nextInLineLabel.AutoSize = true;
            this.nextInLineLabel.Location = new System.Drawing.Point(16, 289);
            this.nextInLineLabel.Name = "nextInLineLabel";
            this.nextInLineLabel.Size = new System.Drawing.Size(46, 17);
            this.nextInLineLabel.TabIndex = 7;
            this.nextInLineLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addLumberjack);
            this.Controls.Add(this.lumberjackNameText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Breakfast for Lumberjacks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lumberjackNameText;
        private System.Windows.Forms.Button addLumberjack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.Button addFlapjacks;
        private System.Windows.Forms.Button nextLumberjack;
        private System.Windows.Forms.Label nextInLineLabel;
    }
}

