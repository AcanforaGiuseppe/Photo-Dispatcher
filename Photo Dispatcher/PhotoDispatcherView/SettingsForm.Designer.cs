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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.photosDirectoryLabel = new System.Windows.Forms.Label();
            this.photosDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.BrowsePhotosButton = new System.Windows.Forms.Button();
            this.emailBodyLabel = new System.Windows.Forms.Label();
            this.emailSubjectLabel = new System.Windows.Forms.Label();
            this.smtpPassLabel = new System.Windows.Forms.Label();
            this.smtpUserLabel = new System.Windows.Forms.Label();
            this.smtpPortLabel = new System.Windows.Forms.Label();
            this.smtpServerLabel = new System.Windows.Forms.Label();
            this.fromNameLabel = new System.Windows.Forms.Label();
            this.csvFilePathLabel = new System.Windows.Forms.Label();
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
            // photosDirectoryLabel
            // 
            this.photosDirectoryLabel.AutoSize = true;
            this.photosDirectoryLabel.Location = new System.Drawing.Point(30, 50);
            this.photosDirectoryLabel.Name = "photosDirectoryLabel";
            this.photosDirectoryLabel.Size = new System.Drawing.Size(85, 13);
            this.photosDirectoryLabel.TabIndex = 0;
            this.photosDirectoryLabel.Text = "Photos Directory";
            this.photosDirectoryLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // photosDirectoryTextBox
            // 
            this.photosDirectoryTextBox.Location = new System.Drawing.Point(146, 43);
            this.photosDirectoryTextBox.Name = "photosDirectoryTextBox";
            this.photosDirectoryTextBox.Size = new System.Drawing.Size(510, 20);
            this.photosDirectoryTextBox.TabIndex = 0;
            this.photosDirectoryTextBox.TextChanged += new System.EventHandler(this.photosDirectoryTextBox_TextChanged);
            // 
            // BrowsePhotosButton
            // 
            this.BrowsePhotosButton.Location = new System.Drawing.Point(671, 40);
            this.BrowsePhotosButton.Name = "BrowsePhotosButton";
            this.BrowsePhotosButton.Size = new System.Drawing.Size(75, 23);
            this.BrowsePhotosButton.TabIndex = 1;
            this.BrowsePhotosButton.Text = "Browse";
            this.BrowsePhotosButton.UseVisualStyleBackColor = true;
            this.BrowsePhotosButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailBodyLabel
            // 
            this.emailBodyLabel.AutoSize = true;
            this.emailBodyLabel.Location = new System.Drawing.Point(30, 363);
            this.emailBodyLabel.Name = "emailBodyLabel";
            this.emailBodyLabel.Size = new System.Drawing.Size(56, 13);
            this.emailBodyLabel.TabIndex = 3;
            this.emailBodyLabel.Text = "EmailBody";
            this.emailBodyLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailSubjectLabel
            // 
            this.emailSubjectLabel.AutoSize = true;
            this.emailSubjectLabel.Location = new System.Drawing.Point(30, 333);
            this.emailSubjectLabel.Name = "emailSubjectLabel";
            this.emailSubjectLabel.Size = new System.Drawing.Size(68, 13);
            this.emailSubjectLabel.TabIndex = 4;
            this.emailSubjectLabel.Text = "EmailSubject";
            this.emailSubjectLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // smtpPassLabel
            // 
            this.smtpPassLabel.AutoSize = true;
            this.smtpPassLabel.Location = new System.Drawing.Point(30, 303);
            this.smtpPassLabel.Name = "smtpPassLabel";
            this.smtpPassLabel.Size = new System.Drawing.Size(54, 13);
            this.smtpPassLabel.TabIndex = 5;
            this.smtpPassLabel.Text = "SmtpPass";
            this.smtpPassLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // smtpUserLabel
            // 
            this.smtpUserLabel.AutoSize = true;
            this.smtpUserLabel.Location = new System.Drawing.Point(30, 273);
            this.smtpUserLabel.Name = "smtpUserLabel";
            this.smtpUserLabel.Size = new System.Drawing.Size(53, 13);
            this.smtpUserLabel.TabIndex = 6;
            this.smtpUserLabel.Text = "SmtpUser";
            this.smtpUserLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // smtpPortLabel
            // 
            this.smtpPortLabel.AutoSize = true;
            this.smtpPortLabel.Location = new System.Drawing.Point(30, 243);
            this.smtpPortLabel.Name = "smtpPortLabel";
            this.smtpPortLabel.Size = new System.Drawing.Size(50, 13);
            this.smtpPortLabel.TabIndex = 7;
            this.smtpPortLabel.Text = "SmtpPort";
            this.smtpPortLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // smtpServerLabel
            // 
            this.smtpServerLabel.AutoSize = true;
            this.smtpServerLabel.Location = new System.Drawing.Point(30, 213);
            this.smtpServerLabel.Name = "smtpServerLabel";
            this.smtpServerLabel.Size = new System.Drawing.Size(62, 13);
            this.smtpServerLabel.TabIndex = 8;
            this.smtpServerLabel.Text = "SmtpServer";
            this.smtpServerLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // fromNameLabel
            // 
            this.fromNameLabel.AutoSize = true;
            this.fromNameLabel.Location = new System.Drawing.Point(30, 183);
            this.fromNameLabel.Name = "fromNameLabel";
            this.fromNameLabel.Size = new System.Drawing.Size(58, 13);
            this.fromNameLabel.TabIndex = 9;
            this.fromNameLabel.Text = "FromName";
            this.fromNameLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // csvFilePathLabel
            // 
            this.csvFilePathLabel.AutoSize = true;
            this.csvFilePathLabel.Location = new System.Drawing.Point(30, 76);
            this.csvFilePathLabel.Name = "csvFilePathLabel";
            this.csvFilePathLabel.Size = new System.Drawing.Size(69, 13);
            this.csvFilePathLabel.TabIndex = 10;
            this.csvFilePathLabel.Text = "Csv File Path";
            this.csvFilePathLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // csvFilePathTextBox
            // 
            this.csvFilePathTextBox.Location = new System.Drawing.Point(146, 69);
            this.csvFilePathTextBox.Name = "csvFilePathTextBox";
            this.csvFilePathTextBox.Size = new System.Drawing.Size(510, 20);
            this.csvFilePathTextBox.TabIndex = 2;
            this.csvFilePathTextBox.TextChanged += new System.EventHandler(this.csvFilePathTextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(263, 480);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(257, 43);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Email Service Settings";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // smtpPortTextBox
            // 
            this.smtpPortTextBox.Location = new System.Drawing.Point(114, 240);
            this.smtpPortTextBox.Name = "smtpPortTextBox";
            this.smtpPortTextBox.Size = new System.Drawing.Size(278, 20);
            this.smtpPortTextBox.TabIndex = 6;
            this.smtpPortTextBox.TextChanged += new System.EventHandler(this.smtpPortTextBox_TextChanged);
            // 
            // smtpServerTextBox
            // 
            this.smtpServerTextBox.Location = new System.Drawing.Point(114, 210);
            this.smtpServerTextBox.Name = "smtpServerTextBox";
            this.smtpServerTextBox.Size = new System.Drawing.Size(278, 20);
            this.smtpServerTextBox.TabIndex = 5;
            this.smtpServerTextBox.TextChanged += new System.EventHandler(this.smtpServerTextBox_TextChanged);
            // 
            // fromNameTextBox
            // 
            this.fromNameTextBox.Location = new System.Drawing.Point(114, 180);
            this.fromNameTextBox.Name = "fromNameTextBox";
            this.fromNameTextBox.Size = new System.Drawing.Size(278, 20);
            this.fromNameTextBox.TabIndex = 4;
            this.fromNameTextBox.TextChanged += new System.EventHandler(this.fromNameTextBox_TextChanged);
            // 
            // smtpPassTextBox
            // 
            this.smtpPassTextBox.Location = new System.Drawing.Point(114, 300);
            this.smtpPassTextBox.Name = "smtpPassTextBox";
            this.smtpPassTextBox.PasswordChar = '*';
            this.smtpPassTextBox.Size = new System.Drawing.Size(278, 20);
            this.smtpPassTextBox.TabIndex = 8;
            this.smtpPassTextBox.TextChanged += new System.EventHandler(this.smtpPassTextBox_TextChanged);
            // 
            // smtpUserTextBox
            // 
            this.smtpUserTextBox.Location = new System.Drawing.Point(114, 270);
            this.smtpUserTextBox.Name = "smtpUserTextBox";
            this.smtpUserTextBox.Size = new System.Drawing.Size(278, 20);
            this.smtpUserTextBox.TabIndex = 7;
            this.smtpUserTextBox.TextChanged += new System.EventHandler(this.smtpUserTextBox_TextChanged);
            // 
            // emailSubjectTextBox
            // 
            this.emailSubjectTextBox.Location = new System.Drawing.Point(114, 330);
            this.emailSubjectTextBox.Name = "emailSubjectTextBox";
            this.emailSubjectTextBox.Size = new System.Drawing.Size(542, 20);
            this.emailSubjectTextBox.TabIndex = 9;
            this.emailSubjectTextBox.TextChanged += new System.EventHandler(this.emailSubjectTextBox_TextChanged);
            // 
            // emailBodyTextBox
            // 
            this.emailBodyTextBox.Location = new System.Drawing.Point(114, 360);
            this.emailBodyTextBox.Multiline = true;
            this.emailBodyTextBox.Name = "emailBodyTextBox";
            this.emailBodyTextBox.Size = new System.Drawing.Size(542, 100);
            this.emailBodyTextBox.TabIndex = 10;
            this.emailBodyTextBox.TextChanged += new System.EventHandler(this.emailBodyTextBox_TextChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
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
            this.Controls.Add(this.csvFilePathLabel);
            this.Controls.Add(this.fromNameLabel);
            this.Controls.Add(this.smtpServerLabel);
            this.Controls.Add(this.smtpPortLabel);
            this.Controls.Add(this.smtpUserLabel);
            this.Controls.Add(this.smtpPassLabel);
            this.Controls.Add(this.emailSubjectLabel);
            this.Controls.Add(this.emailBodyLabel);
            this.Controls.Add(this.BrowsePhotosButton);
            this.Controls.Add(this.photosDirectoryTextBox);
            this.Controls.Add(this.photosDirectoryLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Photo Dispatcher: Settings Provider";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label photosDirectoryLabel;
        private System.Windows.Forms.TextBox photosDirectoryTextBox;
        private System.Windows.Forms.Button BrowsePhotosButton;
        private System.Windows.Forms.Label emailBodyLabel;
        private System.Windows.Forms.Label emailSubjectLabel;
        private System.Windows.Forms.Label smtpPassLabel;
        private System.Windows.Forms.Label smtpUserLabel;
        private System.Windows.Forms.Label smtpPortLabel;
        private System.Windows.Forms.Label smtpServerLabel;
        private System.Windows.Forms.Label fromNameLabel;
        private System.Windows.Forms.Label csvFilePathLabel;
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