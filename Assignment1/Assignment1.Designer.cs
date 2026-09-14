namespace Assignment1
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
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.fstNameBox = new System.Windows.Forms.TextBox();
            this.lstNameBox = new System.Windows.Forms.TextBox();
            this.hrsWrkdBox = new System.Windows.Forms.TextBox();
            this.sumzeBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.firstName.Location = new System.Drawing.Point(83, 103);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(97, 22);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "&First Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lastName.Location = new System.Drawing.Point(336, 103);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(96, 22);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "&Last Name";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.hours.Location = new System.Drawing.Point(550, 103);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(125, 22);
            this.hours.TabIndex = 4;
            this.hours.Text = "&Hours Worked";
            // 
            // fstNameBox
            // 
            this.fstNameBox.Location = new System.Drawing.Point(80, 128);
            this.fstNameBox.Name = "fstNameBox";
            this.fstNameBox.Size = new System.Drawing.Size(100, 20);
            this.fstNameBox.TabIndex = 1;
            this.fstNameBox.TextChanged += new System.EventHandler(this.fstNameBox_TextChanged);
            // 
            // lstNameBox
            // 
            this.lstNameBox.Location = new System.Drawing.Point(332, 128);
            this.lstNameBox.Name = "lstNameBox";
            this.lstNameBox.Size = new System.Drawing.Size(100, 20);
            this.lstNameBox.TabIndex = 3;
            // 
            // hrsWrkdBox
            // 
            this.hrsWrkdBox.Location = new System.Drawing.Point(564, 128);
            this.hrsWrkdBox.Name = "hrsWrkdBox";
            this.hrsWrkdBox.Size = new System.Drawing.Size(100, 20);
            this.hrsWrkdBox.TabIndex = 5;
            // 
            // sumzeBtn
            // 
            this.sumzeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sumzeBtn.Location = new System.Drawing.Point(80, 181);
            this.sumzeBtn.Name = "sumzeBtn";
            this.sumzeBtn.Size = new System.Drawing.Size(100, 32);
            this.sumzeBtn.TabIndex = 6;
            this.sumzeBtn.Text = "Summarize";
            this.sumzeBtn.UseVisualStyleBackColor = true;
            this.sumzeBtn.Click += new System.EventHandler(this.sumzeBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clrBtn.Location = new System.Drawing.Point(220, 181);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 32);
            this.clrBtn.TabIndex = 7;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.outputLabel.Location = new System.Drawing.Point(216, 306);
            this.outputLabel.MaximumSize = new System.Drawing.Size(100000, 200000);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.outputLabel.Size = new System.Drawing.Size(500, 100);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.sumzeBtn);
            this.Controls.Add(this.hrsWrkdBox);
            this.Controls.Add(this.lstNameBox);
            this.Controls.Add(this.fstNameBox);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName
            ;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.TextBox fstNameBox;
        private System.Windows.Forms.TextBox lstNameBox;
        private System.Windows.Forms.TextBox hrsWrkdBox;
        private System.Windows.Forms.Button sumzeBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Label outputLabel;
    }
}

