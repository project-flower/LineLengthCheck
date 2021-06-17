using LineLengthCheck.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LineLengthCheck
{
    public partial class FormMain : Form
    {
        #region Private Fields

        private readonly Font monospacedFont;

        #endregion

        #region Public Methods

        public FormMain()
        {
            InitializeComponent();
            monospacedFont = new Font(Resources.MonospacedFontName, listViewResults.Font.Size);
        }

        #endregion

        #region Private Methods

        private void ExploreFile()
        {
            ListView.SelectedListViewItemCollection selectedItems = listViewResults.SelectedItems;

            if (selectedItems.Count < 1)
            {
                return;
            }

            try
            {
                Process.Start("explorer.exe", string.Format("/select,\"{0}\"", selectedItems[0].Tag));
            }
            catch (Exception exception)
            {
                ShowErrorMessage(exception.Message);
            }
        }

        private void SetListViewItem(CheckResult[] checkResults)
        {
            listViewResults.BeginUpdate();
            listViewResults.Items.Clear();

            foreach (CheckResult checkResult in checkResults)
            {
                int line = checkResult.Line;
                bool error = (line < 0);
                string lineText;
                Color foreColor;

                if (error)
                {
                    lineText = string.Empty;
                    foreColor = Color.Red;
                }
                else
                {
                    lineText = line.ToString();
                    foreColor = listViewResults.ForeColor;
                }

                string fileName;
                string fileFullName = checkResult.FileName;

                try
                {
                    fileName = Path.GetFileName(fileFullName);
                }
                catch
                {
                    fileName = fileFullName;
                }

                var item = new ListViewItem(new string[] { fileName, lineText })
                {
                    ForeColor = foreColor,
                    Tag = fileFullName,
                    UseItemStyleForSubItems = false
                };

                var subItem = new ListViewItem.ListViewSubItem()
                {
                    ForeColor = foreColor,
                    Text = checkResult.Contents
                };

                if (!error)
                {
                    subItem.Font = monospacedFont;
                }

                item.SubItems.Add(subItem);
                listViewResults.Items.Add(item);
            }

            listViewResults.EndUpdate();
        }

        private void ShowErrorMessage(string message)
        {
            ShowMessage(message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private DialogResult ShowMessage(string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(this, text, Text, buttons, icon);
        }

        #endregion

        // Designer's Methods

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            CheckResult[] checkResults;
            int limit = (int)numericUpDownLimit.Value;

            try
            {
                checkResults = MainEngine.Analyze(
                    comboBoxDirectory.Text, comboBoxFilePattern.Text, checkBoxDirectoryRecursive.Checked, limit, checkBoxCountInAscii.Checked);
            }
            catch (Exception exception)
            {
                ShowErrorMessage(exception.Message);
                return;
            }

            SetListViewItem(checkResults);
            string message;
            MessageBoxIcon icon;
            int resultsLength = checkResults.Length;

            if (resultsLength < 1)
            {
                message = string.Format("No file has lines longer than {0} charactors.", limit);
                icon = MessageBoxIcon.Information;
            }
            else
            {
                message = string.Format("{0} lines found.", resultsLength);
                icon = MessageBoxIcon.Warning;
            }

            ShowMessage(message, MessageBoxButtons.OK, icon);
        }

        private void comboBoxDirectory_DragDrop(object sender, DragEventArgs e)
        {
            if (!(e.Data.GetData(DataFormats.FileDrop) is string[] dropData) || (dropData.Length < 1))
            {
                return;
            }

            comboBoxDirectory.Text = dropData[0];
        }

        private void comboBoxDirectory_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None);
        }

        private void listViewResults_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExploreFile();
            }
        }

        private void listViewResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ExploreFile();
        }
    }
}
