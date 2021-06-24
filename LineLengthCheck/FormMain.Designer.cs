
namespace LineLengthCheck
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDirectory = new System.Windows.Forms.Label();
            this.comboBoxDirectory = new System.Windows.Forms.ComboBox();
            this.checkBoxDirectoryRecursive = new System.Windows.Forms.CheckBox();
            this.labelFilePattern = new System.Windows.Forms.Label();
            this.comboBoxFilePattern = new System.Windows.Forms.ComboBox();
            this.labelLimit = new System.Windows.Forms.Label();
            this.numericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCountInAscii = new System.Windows.Forms.CheckBox();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.columnHeaderFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderContents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonBegin = new System.Windows.Forms.Button();
            this.buttonOutputReport = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(12, 15);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(54, 12);
            this.labelDirectory.TabIndex = 0;
            this.labelDirectory.Text = "&Directory:";
            // 
            // comboBoxDirectory
            // 
            this.comboBoxDirectory.AllowDrop = true;
            this.comboBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.comboBoxDirectory.FormattingEnabled = true;
            this.comboBoxDirectory.Location = new System.Drawing.Point(72, 12);
            this.comboBoxDirectory.Name = "comboBoxDirectory";
            this.comboBoxDirectory.Size = new System.Drawing.Size(635, 20);
            this.comboBoxDirectory.TabIndex = 1;
            this.comboBoxDirectory.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxDirectory_DragDrop);
            this.comboBoxDirectory.DragEnter += new System.Windows.Forms.DragEventHandler(this.comboBoxDirectory_DragEnter);
            // 
            // checkBoxDirectoryRecursive
            // 
            this.checkBoxDirectoryRecursive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDirectoryRecursive.AutoSize = true;
            this.checkBoxDirectoryRecursive.Checked = true;
            this.checkBoxDirectoryRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDirectoryRecursive.Location = new System.Drawing.Point(713, 14);
            this.checkBoxDirectoryRecursive.Name = "checkBoxDirectoryRecursive";
            this.checkBoxDirectoryRecursive.Size = new System.Drawing.Size(75, 16);
            this.checkBoxDirectoryRecursive.TabIndex = 2;
            this.checkBoxDirectoryRecursive.Text = "&Recursive";
            this.checkBoxDirectoryRecursive.UseVisualStyleBackColor = true;
            // 
            // labelFilePattern
            // 
            this.labelFilePattern.AutoSize = true;
            this.labelFilePattern.Location = new System.Drawing.Point(12, 41);
            this.labelFilePattern.Name = "labelFilePattern";
            this.labelFilePattern.Size = new System.Drawing.Size(67, 12);
            this.labelFilePattern.TabIndex = 3;
            this.labelFilePattern.Text = "File &Pattern:";
            // 
            // comboBoxFilePattern
            // 
            this.comboBoxFilePattern.FormattingEnabled = true;
            this.comboBoxFilePattern.Location = new System.Drawing.Point(85, 38);
            this.comboBoxFilePattern.Name = "comboBoxFilePattern";
            this.comboBoxFilePattern.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFilePattern.TabIndex = 4;
            this.comboBoxFilePattern.Text = "*.cs";
            // 
            // labelLimit
            // 
            this.labelLimit.AutoSize = true;
            this.labelLimit.Location = new System.Drawing.Point(12, 66);
            this.labelLimit.Name = "labelLimit";
            this.labelLimit.Size = new System.Drawing.Size(100, 12);
            this.labelLimit.TabIndex = 5;
            this.labelLimit.Text = "Limit (Characters):";
            // 
            // numericUpDownLimit
            // 
            this.numericUpDownLimit.Location = new System.Drawing.Point(118, 64);
            this.numericUpDownLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLimit.Name = "numericUpDownLimit";
            this.numericUpDownLimit.Size = new System.Drawing.Size(120, 19);
            this.numericUpDownLimit.TabIndex = 6;
            this.numericUpDownLimit.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // checkBoxCountInAscii
            // 
            this.checkBoxCountInAscii.AutoSize = true;
            this.checkBoxCountInAscii.Checked = true;
            this.checkBoxCountInAscii.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCountInAscii.Location = new System.Drawing.Point(244, 65);
            this.checkBoxCountInAscii.Name = "checkBoxCountInAscii";
            this.checkBoxCountInAscii.Size = new System.Drawing.Size(97, 16);
            this.checkBoxCountInAscii.TabIndex = 7;
            this.checkBoxCountInAscii.Text = "Count In &Ascii";
            this.checkBoxCountInAscii.UseVisualStyleBackColor = true;
            // 
            // listViewResults
            // 
            this.listViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFileName,
            this.columnHeaderLine,
            this.columnHeaderContents});
            this.listViewResults.FullRowSelect = true;
            this.listViewResults.GridLines = true;
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(12, 89);
            this.listViewResults.MultiSelect = false;
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(776, 320);
            this.listViewResults.TabIndex = 8;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            this.listViewResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewResults_KeyDown);
            this.listViewResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewResults_MouseDoubleClick);
            // 
            // columnHeaderFileName
            // 
            this.columnHeaderFileName.Text = "File Name";
            this.columnHeaderFileName.Width = 292;
            // 
            // columnHeaderLine
            // 
            this.columnHeaderLine.Text = "Line";
            this.columnHeaderLine.Width = 80;
            // 
            // columnHeaderContents
            // 
            this.columnHeaderContents.Text = "Contents";
            this.columnHeaderContents.Width = 400;
            // 
            // buttonBegin
            // 
            this.buttonBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBegin.Location = new System.Drawing.Point(632, 415);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(75, 23);
            this.buttonBegin.TabIndex = 9;
            this.buttonBegin.Text = "&Begin";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // buttonOutputReport
            // 
            this.buttonOutputReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOutputReport.Enabled = false;
            this.buttonOutputReport.Location = new System.Drawing.Point(713, 415);
            this.buttonOutputReport.Name = "buttonOutputReport";
            this.buttonOutputReport.Size = new System.Drawing.Size(75, 23);
            this.buttonOutputReport.TabIndex = 10;
            this.buttonOutputReport.Text = "&Report";
            this.buttonOutputReport.UseVisualStyleBackColor = true;
            this.buttonOutputReport.Click += new System.EventHandler(this.buttonOutputReport_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text File|*.txt|All Files|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOutputReport);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.checkBoxCountInAscii);
            this.Controls.Add(this.numericUpDownLimit);
            this.Controls.Add(this.labelLimit);
            this.Controls.Add(this.comboBoxFilePattern);
            this.Controls.Add(this.labelFilePattern);
            this.Controls.Add(this.checkBoxDirectoryRecursive);
            this.Controls.Add(this.comboBoxDirectory);
            this.Controls.Add(this.labelDirectory);
            this.Name = "FormMain";
            this.Text = "Line Length Check";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.ComboBox comboBoxDirectory;
        private System.Windows.Forms.CheckBox checkBoxDirectoryRecursive;
        private System.Windows.Forms.Label labelFilePattern;
        private System.Windows.Forms.ComboBox comboBoxFilePattern;
        private System.Windows.Forms.Label labelLimit;
        private System.Windows.Forms.NumericUpDown numericUpDownLimit;
        private System.Windows.Forms.CheckBox checkBoxCountInAscii;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ColumnHeader columnHeaderFileName;
        private System.Windows.Forms.ColumnHeader columnHeaderLine;
        private System.Windows.Forms.ColumnHeader columnHeaderContents;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.Button buttonOutputReport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

