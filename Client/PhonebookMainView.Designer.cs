namespace Client
{
    partial class PhonebookMainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addEntryButton = new System.Windows.Forms.Button();
            this.editEntryButton = new System.Windows.Forms.Button();
            this.deleteEntryButton = new System.Windows.Forms.Button();
            this.phoneListGrid = new System.Windows.Forms.DataGridView();
            this.refreshGridButton = new System.Windows.Forms.Button();
            this.filterByGroupComboBox = new System.Windows.Forms.ComboBox();
            this.filterByGroupLabel = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addEntryButton
            // 
            this.addEntryButton.Location = new System.Drawing.Point(13, 50);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(75, 23);
            this.addEntryButton.TabIndex = 1;
            this.addEntryButton.Text = "Add";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // editEntryButton
            // 
            this.editEntryButton.Location = new System.Drawing.Point(13, 79);
            this.editEntryButton.Name = "editEntryButton";
            this.editEntryButton.Size = new System.Drawing.Size(75, 23);
            this.editEntryButton.TabIndex = 2;
            this.editEntryButton.Text = "Edit";
            this.editEntryButton.UseVisualStyleBackColor = true;
            this.editEntryButton.Click += new System.EventHandler(this.editEntryButton_Click);
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.Location = new System.Drawing.Point(12, 108);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(76, 23);
            this.deleteEntryButton.TabIndex = 3;
            this.deleteEntryButton.Text = "Delete";
            this.deleteEntryButton.UseVisualStyleBackColor = true;
            this.deleteEntryButton.Click += new System.EventHandler(this.deleteEntryButton_Click);
            // 
            // phoneListGrid
            // 
            this.phoneListGrid.AllowUserToAddRows = false;
            this.phoneListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneListGrid.Location = new System.Drawing.Point(116, 50);
            this.phoneListGrid.Name = "phoneListGrid";
            this.phoneListGrid.Size = new System.Drawing.Size(444, 150);
            this.phoneListGrid.TabIndex = 4;
            // 
            // refreshGridButton
            // 
            this.refreshGridButton.Location = new System.Drawing.Point(485, 206);
            this.refreshGridButton.Name = "refreshGridButton";
            this.refreshGridButton.Size = new System.Drawing.Size(75, 23);
            this.refreshGridButton.TabIndex = 5;
            this.refreshGridButton.Text = "Refresh";
            this.refreshGridButton.UseVisualStyleBackColor = true;
            this.refreshGridButton.Click += new System.EventHandler(this.refreshGridButton_Click);
            // 
            // filterByGroupComboBox
            // 
            this.filterByGroupComboBox.FormattingEnabled = true;
            this.filterByGroupComboBox.Items.AddRange(new object[] {
            "All",
            "Friend",
            "Family",
            "Acquaintance"});
            this.filterByGroupComboBox.Location = new System.Drawing.Point(457, 27);
            this.filterByGroupComboBox.Name = "filterByGroupComboBox";
            this.filterByGroupComboBox.Size = new System.Drawing.Size(103, 21);
            this.filterByGroupComboBox.TabIndex = 6;
            this.filterByGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.filterByGroupComboBox_OnIndexChange);
            // 
            // filterByGroupLabel
            // 
            this.filterByGroupLabel.AutoSize = true;
            this.filterByGroupLabel.Location = new System.Drawing.Point(454, 11);
            this.filterByGroupLabel.Name = "filterByGroupLabel";
            this.filterByGroupLabel.Size = new System.Drawing.Size(75, 13);
            this.filterByGroupLabel.TabIndex = 7;
            this.filterByGroupLabel.Text = "Filter by Group";
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(13, 137);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(76, 23);
            this.importButton.TabIndex = 8;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.FileName = "openFileDialog1";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(13, 166);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(76, 23);
            this.exportButton.TabIndex = 9;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // PhonebookMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 331);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.filterByGroupLabel);
            this.Controls.Add(this.filterByGroupComboBox);
            this.Controls.Add(this.refreshGridButton);
            this.Controls.Add(this.phoneListGrid);
            this.Controls.Add(this.deleteEntryButton);
            this.Controls.Add(this.editEntryButton);
            this.Controls.Add(this.addEntryButton);
            this.Name = "PhonebookMainView";
            this.Text = "Phonebook";
            this.Load += new System.EventHandler(this.PhonebookMainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Button editEntryButton;
        private System.Windows.Forms.Button deleteEntryButton;
        private System.Windows.Forms.DataGridView phoneListGrid;
        private System.Windows.Forms.Button refreshGridButton;
        private System.Windows.Forms.ComboBox filterByGroupComboBox;
        private System.Windows.Forms.Label filterByGroupLabel;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        private System.Windows.Forms.Button exportButton;
    }
}

