using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace PhotoDispatcherView
{
    public partial class SettingsForm : Form
    {
        private string _configFilePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Photo Dispatcher\appsettings.json"));
        private ToolTip toolTip;

        public SettingsForm()
        {
            InitializeComponent();
            InitializeTooltips();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        { }

        private void label3_Click(object sender, EventArgs e)
        { }

        private void label4_Click(object sender, EventArgs e)
        { }

        private void label5_Click(object sender, EventArgs e)
        { }

        private void label6_Click(object sender, EventArgs e)
        { }

        private void label7_Click(object sender, EventArgs e)
        { }

        private void label8_Click(object sender, EventArgs e)
        { }

        private void label9_Click(object sender, EventArgs e)
        { }

        private void label10_Click(object sender, EventArgs e)
        { }

        private void fromNameTextBox_TextChanged(object sender, EventArgs e)
        { }

        private void smtpServerTextBox_TextChanged(object sender, EventArgs e)
        { }

        private void smtpPortTextBox_TextChanged(object sender, EventArgs e)
        { }

        private void smtpUserTextBox_TextChanged(object sender, EventArgs e)
        { }

        private void smtpPassTextBox_TextChanged(object sender, EventArgs e)
        { }

        private void emailSubjectTextBox_TextChanged(object sender, EventArgs e)
        { }

        private void emailBodyTextBox_TextChanged(object sender, EventArgs e)
        { }

        private void csvFilePathTextBox_TextChanged(object sender, EventArgs e)
        { }

        private void photosDirectoryTextBox_TextChanged(object sender, EventArgs e)
        { }

        private void InitializeTooltips()
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(this.photosDirectoryLabel, "The directory where photos are stored.");
            toolTip.SetToolTip(this.csvFilePathLabel, "The path to the CSV file containing email mappings.");
            toolTip.SetToolTip(this.fromNameLabel, "The displayed name of the email sender.");
            toolTip.SetToolTip(this.smtpServerLabel, "The address of the SMTP server.");
            toolTip.SetToolTip(this.smtpPortLabel, "The port number used for the SMTP server.");
            toolTip.SetToolTip(this.smtpUserLabel, "The email address of the account.");
            toolTip.SetToolTip(this.smtpPassLabel, "The email account password.");
            toolTip.SetToolTip(this.emailSubjectLabel, "The subject line of the email.");
            toolTip.SetToolTip(this.emailBodyLabel, "The body text of the email.");
        }

        //           BrowsePhotosButton_Click
        private void button1_Click(object sender, EventArgs e)
        {
            using(var folderBrowser = new FolderBrowserDialog())
            {
                if(folderBrowser.ShowDialog() == DialogResult.OK)
                    photosDirectoryTextBox.Text = folderBrowser.SelectedPath;
            }
        }

        //           BrowseCsvButton_Click
        private void button2_Click(object sender, EventArgs e)
        {
            using(var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                    csvFilePathTextBox.Text = openFileDialog.FileName;
            }
        }

        //           SaveButton_Click
        private void button3_Click(object sender, EventArgs e)
        {
            var emailSettings = new JObject
            {
                ["FromName"] = fromNameTextBox.Text,
                ["SmtpServer"] = smtpServerTextBox.Text,
                ["SmtpPort"] = int.Parse(smtpPortTextBox.Text),
                ["SmtpUser"] = smtpUserTextBox.Text,
                ["SmtpPass"] = smtpPassTextBox.Text,
                ["EmailSubject"] = emailSubjectTextBox.Text,
                ["EmailBody"] = emailBodyTextBox.Text
            };

            var paths = new JObject
            {
                ["PhotosDirectory"] = photosDirectoryTextBox.Text,
                ["CsvFilePath"] = csvFilePathTextBox.Text
            };

            var appSettings = new JObject
            {
                ["EmailSettings"] = emailSettings,
                ["Paths"] = paths
            };

            using(var fileStream = new FileStream(_configFilePath, FileMode.Create, FileAccess.Write))
            {
                using(var streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write(appSettings.ToString());
                }
            }

            MessageBox.Show($"Settings saved successfully at {_configFilePath}");

            Application.Exit();
        }

    }
}