/*
© Giuseppe Acanfora - PHOTODISPATCHER 2024. Tutti i diritti riservati.
*/
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
                components.Dispose();

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
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.emailDelaySecondsTextBox = new System.Windows.Forms.TextBox();
            this.EmailMaxRetryAttemptsTextBox = new System.Windows.Forms.TextBox();
            this.emailDelaySecondsLabel = new System.Windows.Forms.Label();
            this.emailRetryAttemptsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // photosDirectoryLabel
            // 
            this.photosDirectoryLabel.AutoSize = true;
            this.photosDirectoryLabel.Location = new System.Drawing.Point(7, 50);
            this.photosDirectoryLabel.Name = "photosDirectoryLabel";
            this.photosDirectoryLabel.Size = new System.Drawing.Size(85, 13);
            this.photosDirectoryLabel.TabIndex = 0;
            this.photosDirectoryLabel.Text = "Photos Directory";
            this.photosDirectoryLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // photosDirectoryTextBox
            // 
            this.photosDirectoryTextBox.Location = new System.Drawing.Point(114, 43);
            this.photosDirectoryTextBox.Name = "photosDirectoryTextBox";
            this.photosDirectoryTextBox.Size = new System.Drawing.Size(510, 20);
            this.photosDirectoryTextBox.TabIndex = 1;
            this.photosDirectoryTextBox.TextChanged += new System.EventHandler(this.photosDirectoryTextBox_TextChanged);
            // 
            // BrowsePhotosButton
            // 
            this.BrowsePhotosButton.Location = new System.Drawing.Point(642, 40);
            this.BrowsePhotosButton.Name = "BrowsePhotosButton";
            this.BrowsePhotosButton.Size = new System.Drawing.Size(87, 23);
            this.BrowsePhotosButton.TabIndex = 2;
            this.BrowsePhotosButton.Text = "Browse";
            this.BrowsePhotosButton.UseVisualStyleBackColor = true;
            this.BrowsePhotosButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailBodyLabel
            // 
            this.emailBodyLabel.AutoSize = true;
            this.emailBodyLabel.Location = new System.Drawing.Point(8, 423);
            this.emailBodyLabel.Name = "emailBodyLabel";
            this.emailBodyLabel.Size = new System.Drawing.Size(59, 13);
            this.emailBodyLabel.TabIndex = 3;
            this.emailBodyLabel.Text = "Email Body";
            this.emailBodyLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailSubjectLabel
            // 
            this.emailSubjectLabel.AutoSize = true;
            this.emailSubjectLabel.Location = new System.Drawing.Point(8, 393);
            this.emailSubjectLabel.Name = "emailSubjectLabel";
            this.emailSubjectLabel.Size = new System.Drawing.Size(71, 13);
            this.emailSubjectLabel.TabIndex = 4;
            this.emailSubjectLabel.Text = "Email Subject";
            this.emailSubjectLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // smtpPassLabel
            // 
            this.smtpPassLabel.AutoSize = true;
            this.smtpPassLabel.Location = new System.Drawing.Point(7, 303);
            this.smtpPassLabel.Name = "smtpPassLabel";
            this.smtpPassLabel.Size = new System.Drawing.Size(86, 13);
            this.smtpPassLabel.TabIndex = 5;
            this.smtpPassLabel.Text = "SMTP Password";
            this.smtpPassLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // smtpUserLabel
            // 
            this.smtpUserLabel.AutoSize = true;
            this.smtpUserLabel.Location = new System.Drawing.Point(7, 273);
            this.smtpUserLabel.Name = "smtpUserLabel";
            this.smtpUserLabel.Size = new System.Drawing.Size(65, 13);
            this.smtpUserLabel.TabIndex = 6;
            this.smtpUserLabel.Text = "SMTP Email";
            this.smtpUserLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // smtpPortLabel
            // 
            this.smtpPortLabel.AutoSize = true;
            this.smtpPortLabel.Location = new System.Drawing.Point(7, 243);
            this.smtpPortLabel.Name = "smtpPortLabel";
            this.smtpPortLabel.Size = new System.Drawing.Size(59, 13);
            this.smtpPortLabel.TabIndex = 7;
            this.smtpPortLabel.Text = "SMTP Port";
            this.smtpPortLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // smtpServerLabel
            // 
            this.smtpServerLabel.AutoSize = true;
            this.smtpServerLabel.Location = new System.Drawing.Point(7, 213);
            this.smtpServerLabel.Name = "smtpServerLabel";
            this.smtpServerLabel.Size = new System.Drawing.Size(71, 13);
            this.smtpServerLabel.TabIndex = 8;
            this.smtpServerLabel.Text = "SMTP Server";
            this.smtpServerLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // fromNameLabel
            // 
            this.fromNameLabel.AutoSize = true;
            this.fromNameLabel.Location = new System.Drawing.Point(7, 183);
            this.fromNameLabel.Name = "fromNameLabel";
            this.fromNameLabel.Size = new System.Drawing.Size(72, 13);
            this.fromNameLabel.TabIndex = 9;
            this.fromNameLabel.Text = "Sender Name";
            this.fromNameLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // csvFilePathLabel
            // 
            this.csvFilePathLabel.AutoSize = true;
            this.csvFilePathLabel.Location = new System.Drawing.Point(7, 76);
            this.csvFilePathLabel.Name = "csvFilePathLabel";
            this.csvFilePathLabel.Size = new System.Drawing.Size(72, 13);
            this.csvFilePathLabel.TabIndex = 10;
            this.csvFilePathLabel.Text = "CSV File Path";
            this.csvFilePathLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // csvFilePathTextBox
            // 
            this.csvFilePathTextBox.Location = new System.Drawing.Point(114, 69);
            this.csvFilePathTextBox.Name = "csvFilePathTextBox";
            this.csvFilePathTextBox.Size = new System.Drawing.Size(510, 20);
            this.csvFilePathTextBox.TabIndex = 3;
            this.csvFilePathTextBox.TextChanged += new System.EventHandler(this.csvFilePathTextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(642, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(243, 538);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(257, 43);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 151);
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
            this.smtpPortTextBox.TabIndex = 7;
            this.smtpPortTextBox.TextChanged += new System.EventHandler(this.smtpPortTextBox_TextChanged);
            // 
            // smtpServerTextBox
            // 
            this.smtpServerTextBox.Location = new System.Drawing.Point(114, 210);
            this.smtpServerTextBox.Name = "smtpServerTextBox";
            this.smtpServerTextBox.Size = new System.Drawing.Size(278, 20);
            this.smtpServerTextBox.TabIndex = 6;
            this.smtpServerTextBox.TextChanged += new System.EventHandler(this.smtpServerTextBox_TextChanged);
            // 
            // fromNameTextBox
            // 
            this.fromNameTextBox.Location = new System.Drawing.Point(114, 180);
            this.fromNameTextBox.Name = "fromNameTextBox";
            this.fromNameTextBox.Size = new System.Drawing.Size(278, 20);
            this.fromNameTextBox.TabIndex = 5;
            this.fromNameTextBox.TextChanged += new System.EventHandler(this.fromNameTextBox_TextChanged);
            // 
            // smtpPassTextBox
            // 
            this.smtpPassTextBox.Location = new System.Drawing.Point(114, 300);
            this.smtpPassTextBox.Name = "smtpPassTextBox";
            this.smtpPassTextBox.PasswordChar = '*';
            this.smtpPassTextBox.Size = new System.Drawing.Size(278, 20);
            this.smtpPassTextBox.TabIndex = 9;
            this.smtpPassTextBox.TextChanged += new System.EventHandler(this.smtpPassTextBox_TextChanged);
            // 
            // smtpUserTextBox
            // 
            this.smtpUserTextBox.Location = new System.Drawing.Point(114, 270);
            this.smtpUserTextBox.Name = "smtpUserTextBox";
            this.smtpUserTextBox.Size = new System.Drawing.Size(278, 20);
            this.smtpUserTextBox.TabIndex = 8;
            this.smtpUserTextBox.TextChanged += new System.EventHandler(this.smtpUserTextBox_TextChanged);
            // 
            // emailSubjectTextBox
            // 
            this.emailSubjectTextBox.Location = new System.Drawing.Point(115, 390);
            this.emailSubjectTextBox.Name = "emailSubjectTextBox";
            this.emailSubjectTextBox.Size = new System.Drawing.Size(542, 20);
            this.emailSubjectTextBox.TabIndex = 12;
            this.emailSubjectTextBox.TextChanged += new System.EventHandler(this.emailSubjectTextBox_TextChanged);
            // 
            // emailBodyTextBox
            // 
            this.emailBodyTextBox.Location = new System.Drawing.Point(115, 420);
            this.emailBodyTextBox.Multiline = true;
            this.emailBodyTextBox.Name = "emailBodyTextBox";
            this.emailBodyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.emailBodyTextBox.Size = new System.Drawing.Size(542, 100);
            this.emailBodyTextBox.TabIndex = 13;
            this.emailBodyTextBox.TextChanged += new System.EventHandler(this.emailBodyTextBox_TextChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(7, 20);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(55, 13);
            this.languageLabel.TabIndex = 16;
            this.languageLabel.Text = "Language";
            this.languageLabel.Click += new System.EventHandler(this.languageLabel_Click);
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "Italiano"});
            this.languageComboBox.Location = new System.Drawing.Point(114, 17);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(124, 21);
            this.languageComboBox.TabIndex = 0;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged_1);
            // 
            // emailDelaySecondsTextBox
            // 
            this.emailDelaySecondsTextBox.Location = new System.Drawing.Point(114, 330);
            this.emailDelaySecondsTextBox.Name = "emailDelaySecondsTextBox";
            this.emailDelaySecondsTextBox.Size = new System.Drawing.Size(278, 20);
            this.emailDelaySecondsTextBox.TabIndex = 10;
            this.emailDelaySecondsTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmailMaxRetryAttemptsTextBox
            // 
            this.EmailMaxRetryAttemptsTextBox.Location = new System.Drawing.Point(114, 360);
            this.EmailMaxRetryAttemptsTextBox.Name = "EmailMaxRetryAttemptsTextBox";
            this.EmailMaxRetryAttemptsTextBox.Size = new System.Drawing.Size(278, 20);
            this.EmailMaxRetryAttemptsTextBox.TabIndex = 11;
            this.EmailMaxRetryAttemptsTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // emailDelaySecondsLabel
            // 
            this.emailDelaySecondsLabel.AutoSize = true;
            this.emailDelaySecondsLabel.Location = new System.Drawing.Point(7, 333);
            this.emailDelaySecondsLabel.Name = "emailDelaySecondsLabel";
            this.emailDelaySecondsLabel.Size = new System.Drawing.Size(107, 13);
            this.emailDelaySecondsLabel.TabIndex = 18;
            this.emailDelaySecondsLabel.Text = "Email Delay Seconds";
            this.emailDelaySecondsLabel.Click += new System.EventHandler(this.emailDelaySeconds_Click);
            // 
            // emailRetryAttemptsLabel
            // 
            this.emailRetryAttemptsLabel.AutoSize = true;
            this.emailRetryAttemptsLabel.Location = new System.Drawing.Point(7, 363);
            this.emailRetryAttemptsLabel.Name = "emailRetryAttemptsLabel";
            this.emailRetryAttemptsLabel.Size = new System.Drawing.Size(104, 13);
            this.emailRetryAttemptsLabel.TabIndex = 17;
            this.emailRetryAttemptsLabel.Text = "Email Retry Attempts";
            this.emailRetryAttemptsLabel.Click += new System.EventHandler(this.emailRetryAttempts_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(748, 599);
            this.Controls.Add(this.emailDelaySecondsTextBox);
            this.Controls.Add(this.EmailMaxRetryAttemptsTextBox);
            this.Controls.Add(this.emailDelaySecondsLabel);
            this.Controls.Add(this.emailRetryAttemptsLabel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.TextBox emailDelaySecondsTextBox;
        private System.Windows.Forms.TextBox EmailMaxRetryAttemptsTextBox;
        private System.Windows.Forms.Label emailDelaySecondsLabel;
        private System.Windows.Forms.Label emailRetryAttemptsLabel;
    }
}