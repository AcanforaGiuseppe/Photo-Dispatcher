namespace PhotoDispatcherView
{
    partial class SettingsForm
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
            if(disposing && (components != null))
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
            this.photosDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.BrowsePhotosButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.csvFilePathTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.smtpPortTextBox = new System.Windows.Forms.TextBox();
            this.smtpServerTextBox = new System.Windows.Forms.TextBox();
            this.fromNameTextBox = new System.Windows.Forms.TextBox();
            this.smtpPassTextBox = new System.Windows.Forms.TextBox();
            this.smtpUserTextBox = new System.Windows.Forms.TextBox();
            this.emailSubjectTextBox = new System.Windows.Forms.TextBox();
            this.emailBodyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PhotosDirectory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // photosDirectoryTextBox
            // 
            this.photosDirectoryTextBox.Location = new System.Drawing.Point(146, 43);
            this.photosDirectoryTextBox.Name = "photosDirectoryTextBox";
            this.photosDirectoryTextBox.Size = new System.Drawing.Size(510, 20);
            this.photosDirectoryTextBox.TabIndex = 1;
            // 
            // BrowsePhotosButton
            // 
            this.BrowsePhotosButton.Location = new System.Drawing.Point(671, 40);
            this.BrowsePhotosButton.Name = "BrowsePhotosButton";
            this.BrowsePhotosButton.Size = new System.Drawing.Size(75, 23);
            this.BrowsePhotosButton.TabIndex = 2;
            this.BrowsePhotosButton.Text = "Browse";
            this.BrowsePhotosButton.UseVisualStyleBackColor = true;
            this.BrowsePhotosButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "EmailBody";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "EmailSubject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SmtpPass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "SmtpUser";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "SmtpPort";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "SmtpServer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "FromName";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "CsvFilePath";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // csvFilePathTextBox
            // 
            this.csvFilePathTextBox.Location = new System.Drawing.Point(146, 69);
            this.csvFilePathTextBox.Name = "csvFilePathTextBox";
            this.csvFilePathTextBox.Size = new System.Drawing.Size(510, 20);
            this.csvFilePathTextBox.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(290, 482);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(257, 43);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Email Service Settings";
            // 
            // smtpPortTextBox
            // 
            this.smtpPortTextBox.Location = new System.Drawing.Point(114, 235);
            this.smtpPortTextBox.Name = "smtpPortTextBox";
            this.smtpPortTextBox.Size = new System.Drawing.Size(278, 20);
            this.smtpPortTextBox.TabIndex = 15;
            // 
            // smtpServerTextBox
            // 
            this.smtpServerTextBox.Location = new System.Drawing.Point(114, 209);
            this.smtpServerTextBox.Name = "smtpServerTextBox";
            this.smtpServerTextBox.Size = new System.Drawing.Size(278, 20);
            this.smtpServerTextBox.TabIndex = 16;
            // 
            // fromNameTextBox
            // 
            this.fromNameTextBox.Location = new System.Drawing.Point(114, 183);
            this.fromNameTextBox.Name = "fromNameTextBox";
            this.fromNameTextBox.Size = new System.Drawing.Size(278, 20);
            this.fromNameTextBox.TabIndex = 17;
            // 
            // smtpPassTextBox
            // 
            this.smtpPassTextBox.Location = new System.Drawing.Point(114, 287);
            this.smtpPassTextBox.Name = "smtpPassTextBox";
            this.smtpPassTextBox.Size = new System.Drawing.Size(278, 20);
            this.smtpPassTextBox.TabIndex = 18;
            // 
            // smtpUserTextBox
            // 
            this.smtpUserTextBox.Location = new System.Drawing.Point(114, 261);
            this.smtpUserTextBox.Name = "smtpUserTextBox";
            this.smtpUserTextBox.Size = new System.Drawing.Size(278, 20);
            this.smtpUserTextBox.TabIndex = 19;
            // 
            // emailSubjectTextBox
            // 
            this.emailSubjectTextBox.Location = new System.Drawing.Point(114, 378);
            this.emailSubjectTextBox.Name = "emailSubjectTextBox";
            this.emailSubjectTextBox.Size = new System.Drawing.Size(542, 20);
            this.emailSubjectTextBox.TabIndex = 20;
            // 
            // emailBodyTextBox
            // 
            this.emailBodyTextBox.Location = new System.Drawing.Point(114, 404);
            this.emailBodyTextBox.Name = "emailBodyTextBox";
            this.emailBodyTextBox.Size = new System.Drawing.Size(542, 20);
            this.emailBodyTextBox.TabIndex = 21;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 558);
            this.Controls.Add(this.emailBodyTextBox);
            this.Controls.Add(this.emailSubjectTextBox);
            this.Controls.Add(this.smtpUserTextBox);
            this.Controls.Add(this.smtpPassTextBox);
            this.Controls.Add(this.fromNameTextBox);
            this.Controls.Add(this.smtpServerTextBox);
            this.Controls.Add(this.smtpPortTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.csvFilePathTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BrowsePhotosButton);
            this.Controls.Add(this.photosDirectoryTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "PhotoDispatcherView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox photosDirectoryTextBox;
        private System.Windows.Forms.Button BrowsePhotosButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox csvFilePathTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox smtpPortTextBox;
        private System.Windows.Forms.TextBox smtpServerTextBox;
        private System.Windows.Forms.TextBox fromNameTextBox;
        private System.Windows.Forms.TextBox smtpPassTextBox;
        private System.Windows.Forms.TextBox smtpUserTextBox;
        private System.Windows.Forms.TextBox emailSubjectTextBox;
        private System.Windows.Forms.TextBox emailBodyTextBox;
    }
}