namespace DDNet___CFG
{
    public partial class Installer : Form
    {
        public Installer()
        {
            InitializeComponent();
            SetDefaultPath();

        }
        private void SetDefaultPath()
        {
            // Get the path to the AppData directory
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Concatenate the rest of the path
            string fullPath = System.IO.Path.Combine(appDataPath, "DDNet");

            // Set the label text to the full path
            lbldefaultpath.Text = fullPath;

            // Set the path in the static variable
            PathHolder.FullPath = fullPath;
        }

        private void btn_validatepath_Click(object sender, EventArgs e)
        {
            // Source directory is the "binds" folder in the current executable directory
            string sourceDir = Path.Combine(Application.StartupPath, "binds");

            // Target directory is the "binds" folder in the FullPath directory
            string targetDir = Path.Combine(PathHolder.FullPath, "binds");

            try
            {
                // Copy all files and directories recursively
                CopyDirectory(sourceDir, targetDir);

                // Store the selected path in application settings
                Properties.Settings.Default.DefaultPath = lbldefaultpath.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show("Binds config successfully installed.\nRedirecting you to configurator section.", "DDNet - CFG | Installer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the Configurator form
                Configurator configuratorForm = new Configurator();
                configuratorForm.Show();

                // Hide the current form
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void CopyDirectory(string sourceDir, string targetDir)
        {
            // Create the target directory if it doesn't exist
            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }

            // Get all files in the source directory
            string[] files = Directory.GetFiles(sourceDir);

            // Copy each file to the target directory
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(targetDir, fileName);
                File.Copy(file, destFile, true);
            }

            // Get all subdirectories in the source directory
            string[] subDirs = Directory.GetDirectories(sourceDir);

            // Recursively copy each subdirectory to the target directory
            foreach (string subDir in subDirs)
            {
                string dirName = Path.GetFileName(subDir);
                string destDir = Path.Combine(targetDir, dirName);
                CopyDirectory(subDir, destDir);
            }
        }

        private void btn_modifypath_Click(object sender, EventArgs e)
        {
            // Display the folder browser dialog
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();

            // If the user selects a folder and clicks OK
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                // Prompt the user for confirmation to overwrite the default path
                DialogResult confirmationResult = MessageBox.Show("Are you sure you want to overwrite the default path with the selected folder?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms the overwrite
                if (confirmationResult == DialogResult.Yes)
                {
                    // Update the default path with the selected folder
                    PathHolder.FullPath = folderBrowser.SelectedPath;

                    // Display the updated default path in the label
                    lbldefaultpath.Text = PathHolder.FullPath;

                    MessageBox.Show("Default path updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_configurator_Click(object sender, EventArgs e)
        {
            // Open the Configurator form
            Configurator configuratorForm = new Configurator();
            configuratorForm.Show();

            // Hide the current form
            this.Hide();
        }
    }
}