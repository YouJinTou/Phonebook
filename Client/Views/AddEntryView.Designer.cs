namespace Client.Views
{
    partial class AddEntryView
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
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.addPhonesTextBox = new System.Windows.Forms.TextBox();
            this.addPhonesLabel = new System.Windows.Forms.Label();
            this.addAddressLabel = new System.Windows.Forms.Label();
            this.addAddressTextBox = new System.Windows.Forms.TextBox();
            this.addGroupLabel = new System.Windows.Forms.Label();
            this.addGroupComboBox = new System.Windows.Forms.ComboBox();
            this.submitEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.Location = new System.Drawing.Point(81, 26);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.addNameTextBox.TabIndex = 0;
            // 
            // addNameLabel
            // 
            this.addNameLabel.AutoSize = true;
            this.addNameLabel.Location = new System.Drawing.Point(12, 29);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(35, 13);
            this.addNameLabel.TabIndex = 1;
            this.addNameLabel.Text = "Name";
            // 
            // addPhonesTextBox
            // 
            this.addPhonesTextBox.Location = new System.Drawing.Point(81, 52);
            this.addPhonesTextBox.Name = "addPhonesTextBox";
            this.addPhonesTextBox.Size = new System.Drawing.Size(191, 20);
            this.addPhonesTextBox.TabIndex = 2;
            // 
            // addPhonesLabel
            // 
            this.addPhonesLabel.AutoSize = true;
            this.addPhonesLabel.Location = new System.Drawing.Point(12, 55);
            this.addPhonesLabel.Name = "addPhonesLabel";
            this.addPhonesLabel.Size = new System.Drawing.Size(49, 13);
            this.addPhonesLabel.TabIndex = 3;
            this.addPhonesLabel.Text = "Phone(s)";
            // 
            // addAddressLabel
            // 
            this.addAddressLabel.AutoSize = true;
            this.addAddressLabel.Location = new System.Drawing.Point(12, 81);
            this.addAddressLabel.Name = "addAddressLabel";
            this.addAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.addAddressLabel.TabIndex = 5;
            this.addAddressLabel.Text = "Address";
            // 
            // addAddressTextBox
            // 
            this.addAddressTextBox.Location = new System.Drawing.Point(81, 78);
            this.addAddressTextBox.Name = "addAddressTextBox";
            this.addAddressTextBox.Size = new System.Drawing.Size(191, 20);
            this.addAddressTextBox.TabIndex = 4;
            // 
            // addGroupLabel
            // 
            this.addGroupLabel.AutoSize = true;
            this.addGroupLabel.Location = new System.Drawing.Point(12, 107);
            this.addGroupLabel.Name = "addGroupLabel";
            this.addGroupLabel.Size = new System.Drawing.Size(36, 13);
            this.addGroupLabel.TabIndex = 7;
            this.addGroupLabel.Text = "Group";
            // 
            // addGroupComboBox
            // 
            this.addGroupComboBox.FormattingEnabled = true;
            this.addGroupComboBox.Location = new System.Drawing.Point(81, 107);
            this.addGroupComboBox.Name = "addGroupComboBox";
            this.addGroupComboBox.Size = new System.Drawing.Size(191, 21);
            this.addGroupComboBox.TabIndex = 8;
            // 
            // submitEntryButton
            // 
            this.submitEntryButton.Location = new System.Drawing.Point(197, 177);
            this.submitEntryButton.Name = "submitEntryButton";
            this.submitEntryButton.Size = new System.Drawing.Size(75, 23);
            this.submitEntryButton.TabIndex = 9;
            this.submitEntryButton.Text = "Add Entry";
            this.submitEntryButton.UseVisualStyleBackColor = true;
            this.submitEntryButton.Click += new System.EventHandler(this.submitEntryButton_Click);
            // 
            // AddEntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.submitEntryButton);
            this.Controls.Add(this.addGroupComboBox);
            this.Controls.Add(this.addGroupLabel);
            this.Controls.Add(this.addAddressLabel);
            this.Controls.Add(this.addAddressTextBox);
            this.Controls.Add(this.addPhonesLabel);
            this.Controls.Add(this.addPhonesTextBox);
            this.Controls.Add(this.addNameLabel);
            this.Controls.Add(this.addNameTextBox);
            this.Name = "AddEntryView";
            this.Text = "Add Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addNameTextBox;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.TextBox addPhonesTextBox;
        private System.Windows.Forms.Label addPhonesLabel;
        private System.Windows.Forms.Label addAddressLabel;
        private System.Windows.Forms.TextBox addAddressTextBox;
        private System.Windows.Forms.Label addGroupLabel;
        private System.Windows.Forms.ComboBox addGroupComboBox;
        private System.Windows.Forms.Button submitEntryButton;
    }
}