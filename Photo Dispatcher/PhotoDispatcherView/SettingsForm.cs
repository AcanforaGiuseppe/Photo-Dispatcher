using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace PhotoDispatcherView
{
    public partial class SettingsForm : Form
    {
        private string _configFilePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Photo Dispatcher\appsettings.json"));

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void label9_Click(object sender, EventArgs e)
        { }

        private void label8_Click(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        { }

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