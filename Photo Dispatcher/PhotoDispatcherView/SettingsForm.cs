using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
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
            ClearAppSettingsFile();
            InitializeComponent();
            InitializeTooltips();
        }

        #region Empty Methods
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
        #endregion

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

            LaunchPhotoDispatcherMainProject();

            Application.Exit();
        }

        private void LaunchPhotoDispatcherMainProject()
        {
            // Define the paths
            string solutionDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
            string projectFilePath = Path.Combine(solutionDirectory, @"Photo Dispatcher\PhotoDispatcher.csproj");
            string otherProjectExePath = Path.Combine(solutionDirectory, @"Photo Dispatcher\bin\Debug\net8.0\PhotoDispatcher.exe");

            // Debug: Verify the solution and project file paths
            MessageBox.Show($"Solution directory: {solutionDirectory}\nProject file path: {projectFilePath}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Build the project
            Process buildProcess = new Process();
            buildProcess.StartInfo.FileName = "dotnet";
            buildProcess.StartInfo.Arguments = $"build \"{projectFilePath}\"";
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


        // Clears appsettings.json file
        private void ClearAppSettingsFile()
        {
            var emptyAppSettings = new JObject
            {
                ["EmailSettings"] = new JObject
                {
                    ["FromName"] = "",
                    ["SmtpServer"] = "",
                    ["SmtpPort"] = 0,
                    ["SmtpUser"] = "",
                    ["SmtpPass"] = "",
                    ["EmailSubject"] = "",
                    ["EmailBody"] = ""
                },
                ["Paths"] = new JObject
                {
                    ["PhotosDirectory"] = "",
                    ["CsvFilePath"] = ""
                }
            };

            using(var fileStream = new FileStream(_configFilePath, FileMode.Create, FileAccess.Write))
            {
                using(var streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write(emptyAppSettings.ToString());
                }
            }
        }

    }
}