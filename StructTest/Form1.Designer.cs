namespace StructTest
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
            this.DisplayDetailsLabel = new System.Windows.Forms.Label();
            this.DateTimeNowLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.StudentIdLabel = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisplayDetailsLabel
            // 
            this.DisplayDetailsLabel.AutoSize = true;
            this.DisplayDetailsLabel.Location = new System.Drawing.Point(140, 35);
            this.DisplayDetailsLabel.Name = "DisplayDetailsLabel";
            this.DisplayDetailsLabel.Size = new System.Drawing.Size(76, 13);
            this.DisplayDetailsLabel.TabIndex = 0;
            this.DisplayDetailsLabel.Text = "Display Details";
            // 
            // DateTimeNowLabel
            // 
            this.DateTimeNowLabel.AutoSize = true;
            this.DateTimeNowLabel.Location = new System.Drawing.Point(50, 78);
            this.DateTimeNowLabel.Name = "DateTimeNowLabel";
            this.DateTimeNowLabel.Size = new System.Drawing.Size(81, 13);
            this.DateTimeNowLabel.TabIndex = 1;
            this.DateTimeNowLabel.Text = "Date Time Now";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(50, 124);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(75, 13);
            this.StudentNameLabel.TabIndex = 2;
            this.StudentNameLabel.Text = "Student Name";
            // 
            // StudentIdLabel
            // 
            this.StudentIdLabel.AutoSize = true;
            this.StudentIdLabel.Location = new System.Drawing.Point(50, 162);
            this.StudentIdLabel.Name = "StudentIdLabel";
            this.StudentIdLabel.Size = new System.Drawing.Size(56, 13);
            this.StudentIdLabel.TabIndex = 3;
            this.StudentIdLabel.Text = "Student Id";
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(100, 203);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 7;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.StudentIdLabel);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.DateTimeNowLabel);
            this.Controls.Add(this.DisplayDetailsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisplayDetailsLabel;
        private System.Windows.Forms.Label DateTimeNowLabel;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Label StudentIdLabel;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

