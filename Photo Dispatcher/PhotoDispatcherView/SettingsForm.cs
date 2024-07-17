using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace PhotoDispatcherView
{
    public partial class SettingsForm : Form
    {
        private string _configFilePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Photo Dispatcher\appsettings.json"));
        private ToolTip toolTip;
        private ResourceManager _resourceManager;

        public SettingsForm()
        {
            InitializeComponent();
        }

        #region Empty Methods

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

        private void languageLabel_Click(object sender, EventArgs e)
        { }

        private void emailDelaySeconds_Click(object sender, EventArgs e)
        { }

        private void emailRetryAttempts_Click(object sender, EventArgs e)
        { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            toolTip = new ToolTip();
            _resourceManager = new ResourceManager("PhotoDispatcherView.Properties.Resources", typeof(SettingsForm).Assembly);

            ApplyLanguage("en");
            languageComboBox.SelectedIndex = 0;
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
                ["EmailBody"] = emailBodyTextBox.Text,
                ["SendDelaySeconds"] = int.Parse(emailDelaySecondsTextBox.Text),
                ["MaxRetryAttempts"] = int.Parse(EmailMaxRetryAttemptsTextBox.Text)
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

            LaunchPhotoDispatcherMainProject();

            Application.Exit();
        }

        private void LaunchPhotoDispatcherMainProject()
        {
            // If the code is being launched in Debug mode, the executable will be taken from the Debug folder. Otherwise, the Release one will be used.
#if DEBUG
            string configuration = "Debug";
#else
            string configuration = "Release";
#endif

            // Define the paths
            string solutionDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
            string projectFilePath = Path.Combine(solutionDirectory, @"Photo Dispatcher\PhotoDispatcher.csproj");
            string otherProjectExePath = Path.Combine(solutionDirectory, $@"Photo Dispatcher\bin\{configuration}\net8.0\PhotoDispatcher.exe");

            // Debug: Verify the solution and project file paths
            MessageBox.Show($"Solution directory: {solutionDirectory}\nProject file path: {projectFilePath}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Build the project
            Process buildProcess = new Process();
            buildProcess.StartInfo.FileName = "dotnet";
            buildProcess.StartInfo.Arguments = $"build \"{projectFilePath}\" -c {configuration}";
            buildProcess.StartInfo.WorkingDirectory = solutionDirectory;
            buildProcess.StartInfo.RedirectStandardOutput = true;
            buildProcess.StartInfo.RedirectStandardError = true;
            buildProcess.StartInfo.UseShellExecute = false;
            buildProcess.StartInfo.CreateNoWindow = true;
            buildProcess.Start();

            // Read the output and error streams
            string buildOutput = buildProcess.StandardOutput.ReadToEnd();
            string buildError = buildProcess.StandardError.ReadToEnd();
            buildProcess.WaitForExit();

            // Debug: Verify build output and error streams
            MessageBox.Show($"Build output:\n{buildOutput}\n\nBuild error:\n{buildError}", "Build Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Check for build errors
            if(buildProcess.ExitCode != 0)
            {
                MessageBox.Show($"Build failed with exit code {buildProcess.ExitCode}.\n\nError Details:\n{buildError}", "Build Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Debug: Verify that the executable path is correct
            MessageBox.Show($"Executable path: {otherProjectExePath}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Launch the executable if it exists
            if(File.Exists(otherProjectExePath))
                Process.Start(otherProjectExePath);
            else
                MessageBox.Show("The main project executable was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ApplyLanguage(string culture)
        {
            var cultureInfo = new CultureInfo(culture);

            // Labels
            photosDirectoryLabel.Text = _resourceManager.GetString($"photosDirectoryLabel.Text.{culture}", cultureInfo);
            csvFilePathLabel.Text = _resourceManager.GetString($"csvFilePathLabel.Text.{culture}", cultureInfo);
            fromNameLabel.Text = _resourceManager.GetString($"fromNameLabel.Text.{culture}", cultureInfo);
            smtpServerLabel.Text = _resourceManager.GetString($"smtpServerLabel.Text.{culture}", cultureInfo);
            smtpPortLabel.Text = _resourceManager.GetString($"smtpPortLabel.Text.{culture}", cultureInfo);
            smtpUserLabel.Text = _resourceManager.GetString($"smtpUserLabel.Text.{culture}", cultureInfo);
            smtpPassLabel.Text = _resourceManager.GetString($"smtpPassLabel.Text.{culture}", cultureInfo);
            emailSubjectLabel.Text = _resourceManager.GetString($"emailSubjectLabel.Text.{culture}", cultureInfo);
            emailBodyLabel.Text = _resourceManager.GetString($"emailBodyLabel.Text.{culture}", cultureInfo);
            label10.Text = _resourceManager.GetString($"label10.Text.{culture}", cultureInfo);
            SaveButton.Text = _resourceManager.GetString($"SaveButton.Text.{culture}", cultureInfo);
            BrowsePhotosButton.Text = _resourceManager.GetString($"BrowsePhotosButton.Text.{culture}", cultureInfo);
            button2.Text = _resourceManager.GetString($"button2.Text.{culture}", cultureInfo);
            languageLabel.Text = _resourceManager.GetString($"languageLabel.Text.{culture}", cultureInfo);
            emailDelaySecondsLabel.Text = _resourceManager.GetString($"emailDelaySecondsLabel.Text.{culture}", cultureInfo);
            emailRetryAttemptsLabel.Text = _resourceManager.GetString($"emailRetryAttemptsLabel.Text.{culture}", cultureInfo);

            // Tooltips
            toolTip.SetToolTip(this.photosDirectoryLabel, _resourceManager.GetString($"photosDirectoryLabel.ToolTip.{culture}", cultureInfo));
            toolTip.SetToolTip(this.csvFilePathLabel, _resourceManager.GetString($"csvFilePathLabel.ToolTip.{culture}", cultureInfo));
            toolTip.SetToolTip(this.fromNameLabel, _resourceManager.GetString($"fromNameLabel.ToolTip.{culture}", cultureInfo));
            toolTip.SetToolTip(this.smtpServerLabel, _resourceManager.GetString($"smtpServerLabel.ToolTip.{culture}", cultureInfo));
            toolTip.SetToolTip(this.smtpPortLabel, _resourceManager.GetString($"smtpPortLabel.ToolTip.{culture}", cultureInfo));
            toolTip.SetToolTip(this.smtpUserLabel, _resourceManager.GetString($"smtpUserLabel.ToolTip.{culture}", cultureInfo));
            toolTip.SetToolTip(this.smtpPassLabel, _resourceManager.GetString($"smtpPassLabel.ToolTip.{culture}", cultureInfo));
            toolTip.SetToolTip(this.emailSubjectLabel, _resourceManager.GetString($"emailSubjectLabel.ToolTip.{culture}", cultureInfo));
            toolTip.SetToolTip(this.emailBodyLabel, _resourceManager.GetString($"emailBodyLabel.ToolTip.{culture}", cultureInfo));
            toolTip.SetToolTip(this.emailDelaySecondsLabel, _resourceManager.GetString($"emailDelaySecondsLabel.ToolTip.{culture}", cultureInfo));
            toolTip.SetToolTip(this.emailRetryAttemptsLabel, _resourceManager.GetString($"emailRetryAttemptsLabel.ToolTip.{culture}", cultureInfo));
        }

        private void languageComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(languageComboBox.SelectedItem.ToString() == "English")
                ApplyLanguage("en");
            else if(languageComboBox.SelectedItem.ToString() == "Italiano")
                ApplyLanguage("it");
        }

    }
}