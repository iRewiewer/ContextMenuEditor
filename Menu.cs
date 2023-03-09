using Microsoft.Win32;

namespace ContextMenuEditor
{
    public partial class CME : Form
    {
        private const string basePath = @"Directory\Background\shell\";
        private const string notepadPath = @"C:\Program Files (x86)\Notepad++\notepad++.exe";

        public CME()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void iconTextBox_TextChanged(object sender, EventArgs e)
        {
            Image imageFile;

            try
            {
                imageFile = new Bitmap(iconTextBox.Text);
            }
            catch
            {
                try
                {
                    imageFile = System.Drawing.Icon.ExtractAssociatedIcon(iconTextBox.Text).ToBitmap();
                }
                catch(Exception ex)
                {
                    imageFile = new Bitmap("cross.png");
                }
            }

            imageFile = new Bitmap(imageFile, new Size(iconPreview.Width, iconPreview.Height));
            iconPreview.Image = imageFile;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CreateRegistryKey(keyNameTextBox.Text, keyHeaderTextBox.Text, iconTextBox.Text, commandTextBox.Text);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP");
        }

        private void CreateRegistryKey(string keyName, string keyHeader, string iconPath, string command)
        {
            using(RegistryKey baseDirectory = Registry.ClassesRoot.OpenSubKey(basePath, true))
            {
                if(baseDirectory.OpenSubKey(keyName) != null)
                {
                    MessageBox.Show($"Key '{keyName}' already exists.");
                    return;
                }

                RegistryKey key = baseDirectory.CreateSubKey(keyName, true);
                RegistryKey subkey = key.CreateSubKey("command", true);
                key.SetValue("", $"&{keyHeader}");
                key.SetValue("Icon", iconPath);
                subkey.SetValue("Default", command);

                subkey.Close();
                key.Close();
            }

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            panel.Rows.Clear();

            using (RegistryKey baseDirectory = Registry.ClassesRoot.OpenSubKey(basePath, true))
            {
                foreach (string item in baseDirectory.GetSubKeyNames())
                {
                    DataRow row = new DataRow();

                    using (RegistryKey key = baseDirectory.OpenSubKey(item))
                    {
                        row.KeyName = key.Name.Split(@"\").Last();
                        row.KeyHeader = (key.GetValue("") == null ? "null" : key.GetValue("")).ToString();
                        row.IconPath = (key.GetValue("Icon") == null ? "null" : key.GetValue("Icon")).ToString();

                        using (RegistryKey command = key.OpenSubKey("command"))
                        {
                            if(command == null)
                            {
                                row.Command = "null";
                                return;
                            }

                            row.Command = (command.GetValue("") == null ? "null" : command.GetValue("")).ToString();
                        }
                    }

                    panel.Rows.Add(row.KeyName, row.KeyHeader, row.IconPath, row.Command);
                }
            }
        }
    }

    public class DataRow
    {
        public string KeyName { get; set; }
        public string KeyHeader { get; set; }
        public string IconPath { get; set; }
        public string Command { get; set; }
    }
}