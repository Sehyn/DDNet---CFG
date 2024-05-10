using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDNet___CFG
{
    public partial class Configurator : Form
    {
        private string BindFolderPath = Path.Combine(PathHolder.FullPath, "binds");
        private string DeepFlyOffFilePath = Path.Combine(PathHolder.FullPath, "binds", "DeepFly", "[DP]OFF.cfg");
        private string DeepFlyOnFilePath = Path.Combine(PathHolder.FullPath, "binds", "DeepFly", "[DP]ON.cfg");

        public Configurator()
        {
            InitializeComponent();
            LoadDefaultPath();

            // Set default value for the combo box
            SetDefaultComboBoxValue();
            lbldebug.Text = DeepFlyOffFilePath;
            InitializePseudoFlyComboBox();
            InitializeTripleFlyComboBox();

        }

        private void SetDefaultComboBoxValue()
        {
            Console.WriteLine("Setting default value for the combo box...");
            // Read the binded key from the OFF file
            string bindedKey = GetBindedKey(DeepFlyOffFilePath);
            Console.WriteLine($"Binded key from file: {bindedKey}");

            // Set the default value of the combo box to the binded key
            if (!string.IsNullOrEmpty(bindedKey))
            {
                cb_deepfly.SelectedItem = bindedKey;
                Console.WriteLine($"Default value set: {cb_deepfly.SelectedItem}");
            }
            else
            {
                Console.WriteLine("Default value not found.");
            }
        }

        private string GetBindedKey(string filePath)
        {
            Console.WriteLine($"Getting binded key from file: {filePath}");
            // Read the content of the file and extract the binded key
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine($"Line read from file: {line}");
                    if (line.StartsWith("bind") && line.Contains("exec"))
                    {
                        string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length >= 3)
                        {
                            string bindedKey = parts[1];
                            Console.WriteLine($"Binded key found: {bindedKey}");
                            return bindedKey;
                        }
                    }
                }
            }
            return null; // Bind key not found
        }
        private void InitializePseudoFlyComboBox()
        {
            // Set default value for the combo box
            string pseudoFlyOnFilePath = Path.Combine(PathHolder.FullPath, "binds", "PseudoFly", "[PF]ON.cfg");
            string defaultBindedKey = GetBindedKeyFromConfigFile(pseudoFlyOnFilePath);
            if (!string.IsNullOrEmpty(defaultBindedKey))
            {
                cb_pseudofly.Items.Add(defaultBindedKey);
                cb_pseudofly.SelectedItem = defaultBindedKey;
            }

            // Handle selection change event
            cb_pseudofly.SelectedIndexChanged += (sender, e) =>
            {
                string newBindedKey = cb_pseudofly.SelectedItem.ToString();
                UpdatePseudoFlyBindedKey(newBindedKey);
            };
        }

        private void InitializeTripleFlyComboBox()
        {
            // Set default value for the combo box
            string tripleFlyOnFilePath = Path.Combine(PathHolder.FullPath, "binds", "TripleFly", "[TF]ON.cfg");
            string defaultBindedKey = GetBindedKeyFromConfigFile(tripleFlyOnFilePath);
            if (!string.IsNullOrEmpty(defaultBindedKey))
            {
                cb_triplefly.Items.Add(defaultBindedKey);
                cb_triplefly.SelectedItem = defaultBindedKey;
            }

            // Handle selection change event
            cb_triplefly.SelectedIndexChanged += (sender, e) =>
            {
                string newBindedKey = cb_triplefly.SelectedItem.ToString();
                UpdateTripleFlyBindedKey(newBindedKey);
            };
        }



        // Update the binded key in the [TF]OFF.cfg and [TF]ON.cfg files
        private void UpdateTripleFlyBindedKey(string newBindedKey)
        {
            // Update the binded key in the [TF]OFF.cfg file
            string tripleFlyOffFilePath = Path.Combine(PathHolder.FullPath, "binds", "TripleFly", "[TF]OFF.cfg");
            UpdateBindedKeyInFile(tripleFlyOffFilePath, newBindedKey);

            // Update the binded key in the [TF]ON.cfg file
            string tripleFlyOnFilePath = Path.Combine(PathHolder.FullPath, "binds", "TripleFly", "[TF]ON.cfg");
            UpdateBindedKeyInFile(tripleFlyOnFilePath, newBindedKey);
        }

        // Get the binded key from the [PF]OFF.cfg file
        private string GetBindedKeyFromConfigFile(string filePath)
        {
            Console.WriteLine($"Getting binded key from file: {filePath}");
            // Read the content of the file and extract the binded key
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine($"Line read from file: {line}");
                    if (line.StartsWith("bind") && line.Contains("exec"))
                    {
                        string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length >= 4 && parts[2].Equals("exec", StringComparison.OrdinalIgnoreCase))
                        {
                            string bindedKey = parts[1];
                            Console.WriteLine($"Binded key found: {bindedKey}");
                            return bindedKey;
                        }
                    }
                }
            }
            Console.WriteLine("Default value not found.");
            return null; // Bind key not found
        }

        private void UpdatePseudoFlyBindedKey(string newBindedKey)
        {
            // Update the binded key in the [PF]OFF.cfg file
            string pseudoFlyOffFilePath = Path.Combine(PathHolder.FullPath, "binds", "PseudoFly", "[PF]OFF.cfg");
            UpdateBindedKeyInFile(pseudoFlyOffFilePath, newBindedKey);

            // Update the binded key in the [PF]ON.cfg file
            string pseudoFlyOnFilePath = Path.Combine(PathHolder.FullPath, "binds", "PseudoFly", "[PF]ON.cfg");
            UpdateBindedKeyInFile(pseudoFlyOnFilePath, newBindedKey);
        }


        private void UpdateBindedKeyInFiles(string newBindedKey)
        {
            Console.WriteLine($"Updating binded key in files. New binded key: {newBindedKey}");

            // Update the binded key in both ON and OFF files
            UpdateBindedKeyInFile(DeepFlyOffFilePath, newBindedKey);
            UpdateBindedKeyInFile(DeepFlyOnFilePath, newBindedKey);
        }

        private void UpdateBindedKeyInFile(string filePath, string newBindedKey)
        {
            Console.WriteLine($"Updating binded key in file: {filePath}. New binded key: {newBindedKey}");

            // Read the content of the file
            string[] lines = File.ReadAllLines(filePath);

            // Update the line containing the binded key
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("bind"))
                {
                    string[] parts = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 4 && parts[2].Equals("exec", StringComparison.OrdinalIgnoreCase))
                    {
                        string originalBindedKey = parts[1];
                        string originalFilePath = parts[3];
                        lines[i] = $"bind {newBindedKey} exec {originalFilePath}";
                        break;
                    }
                }
            }

            // Write the updated content back to the file
            File.WriteAllLines(filePath, lines);
        }


        private void LoadDefaultPath()
        {
            // Access the FullPath property from PathHolder class and set it to the label
            lbldefaultpath.Text = PathHolder.FullPath;
        }

        private void btn_credits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tool: Sucre\nGitHub: Sehyn\nConfig: Based of xKox [PL]", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey, thanks for using the tool\nI've made this after I wanted to easilly import/modify configs with the less interaction possible for new players and veterans who just want to use that config and modify it with ease.\n\nAnyways, now you can simply modify the key for each available binds according to where you've installed the binds\nthe program will simply find the line and replace the current 'key' to the one you're going to define easy as that!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_supportme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You've actually clicked it? How handsome you are.\nSo let's go straight forward, I've actually fall in love with this game I'm so sad that I've not find it earlier I think I've missed his golden era and it's kind of unfortunate.\nIf you wish to support me there is multiple ways:\n\nYou can play with me! Yes please do so, It's so hard nowadays to find players to play with, most players are always the same they already have their set of friends, group of friends or whatever I've never been able to integrate any group, perhaps my behavior I don't know could be and sorry if I offended anyone, but regardless the fact I'm using the binds is to make my life easier with dummy play, cause since I have no friends not a single one on that game, well just like a few players I'd mention 'Tisch' specially which I'am thankful for explaining me how we play dummy and why I should play with it. Well I'm playing with dummy and this is why that tool is here, so if you want to support me on hop in game find me with the username Sucre and let's have some fun voice chat is appreciated for team runs :)\n\nMoney? Well if you really think I deserve it throw me a Discord DM my nickname is: impots", "Support me", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cb_deepfly_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string newBindedKey = comboBox.SelectedItem.ToString();
            Console.WriteLine($"Combo box selection changed. New selected item: {newBindedKey}");


            // Update the binded key in both ON and OFF files
            UpdateBindedKeyInFiles(newBindedKey);
        }
    }
}
