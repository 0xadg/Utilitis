using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCopy
{
    public partial class Form1 : Form
    {
        private List<string> sourceFolders = new List<string>();
        private List<string> targetFolders = new List<string>();
        string triggerFolder;
        public Form1 ()
        {
            InitializeComponent();
            
        }

        #region FSW methods
        private void fswChanged (object sender, System.IO.FileSystemEventArgs e)
        {
            new ToastContentBuilder()
                .AddText("sus?")
                .Show();
            //MessageBox.Show($"Got {e.ChangeType}!", "AutoCopyInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 

        #endregion

        #region Form methods

        private void startListeningButton_Click (object sender, EventArgs e)
        {
            fsw.EnableRaisingEvents = true;
        }
        #endregion


        #region source folder selector methods
        private void addSourceFolderButton_Click (object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                sourceFolders.Add(fbd.SelectedPath);
                sourceFoldersList.Items.Add(fbd.SelectedPath);
            }
        }
        private void editSourceFolderButton_Click (object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (sourceFoldersList.SelectedItem.ToString() == $"[TRG] {triggerFolder}")
                {
                    triggerFolder = fbd.SelectedPath;
                    sourceFoldersList.Items[sourceFoldersList.SelectedIndex] = $"[TRG] {fbd.SelectedPath}";
                }
                else
                {
                    int index = sourceFolders.FindIndex((x) => x == sourceFoldersList.SelectedItem.ToString());
                    if (index != -1)
                    {
                        sourceFolders[index] = fbd.SelectedPath;
                        sourceFoldersList.Items[sourceFoldersList.SelectedIndex] = fbd.SelectedPath;
                    }
                }
            }
        }
        private void removeSourceFolderButton_Click (object sender, EventArgs e)
        {
            if (sourceFoldersList.SelectedItem.ToString() == triggerFolder) triggerFolder = "";
            sourceFolders.Remove(sourceFoldersList.SelectedItem.ToString());
            sourceFoldersList.Items.RemoveAt(sourceFoldersList.SelectedIndex);
        }
        private void sourceFoldersList_SelectedIndexChanged (object sender, EventArgs e)
        {
            editSourceFolderButton.Enabled = sourceFoldersList.SelectedIndex != -1;
            removeSourceFolderButton.Enabled = sourceFoldersList.SelectedIndex != -1;
        }
        private void selectTriggerButton_Click (object sender, EventArgs e)
        {
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                fsw.Path = triggerFolder = fbd.SelectedPath;
                trigFolderLabel.Text = triggerFolder;
            }
            //if (sourceFoldersList.SelectedItem.ToString() != triggerFolder)
            //{
            //    // removing previous folder
            //    int index = sourceFoldersList.Items.IndexOf($"[TRG] {triggerFolder}");
            //    if (index != -1)
            //    {
            //        sourceFoldersList.Items[index] = triggerFolder;
            //    }

            //    fsw.Path = triggerFolder = sourceFoldersList.SelectedItem.ToString();
            //    sourceFoldersList.Items[sourceFoldersList.SelectedIndex] = $"[TRG] {fsw.Path}";
            //    sourceFolders.Remove(fsw.Path);
            //}
        }
        #endregion

        #region target folder selector methods
        private void addTargetFolderButton_Click (object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                targetFolders.Add(fbd.SelectedPath);
                targetFoldersList.Items.Add(fbd.SelectedPath);
            }
        }
        private void editTargetFolderButton_Click (object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                int index = targetFolders.FindIndex((x) => x == targetFoldersList.SelectedItem.ToString());
                if (index != -1)
                {
                    targetFolders[index] = fbd.SelectedPath;
                    targetFoldersList.Items[targetFoldersList.SelectedIndex] = fbd.SelectedPath;
                }
            }
        }
        private void removeTargetFolderButton_Click (object sender, EventArgs e)
        {
            targetFolders.Remove(targetFoldersList.SelectedItem.ToString());
            targetFoldersList.Items.RemoveAt(targetFoldersList.SelectedIndex);
        }
        private void targetFoldersList_SelectedIndexChanged (object sender, EventArgs e)
        {
            editTargetFolderButton.Enabled = targetFoldersList.SelectedIndex != -1;
            removeTargetFolderButton.Enabled = targetFoldersList.SelectedIndex != -1;
        } 
        #endregion

    }
}
