namespace Client.Views
{
    partial class EditEntryView
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
            this.components = new System.ComponentModel.Container();
            this.editGroupLabel = new System.Windows.Forms.Label();
            this.editAddressLabel = new System.Windows.Forms.Label();
            this.editAddressReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.editPhonesLabel = new System.Windows.Forms.Label();
            this.editPhonesReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.editNameLabel = new System.Windows.Forms.Label();
            this.editNameReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.editGroupReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.editAddressTextBox = new System.Windows.Forms.TextBox();
            this.editPhonesTextBox = new System.Windows.Forms.TextBox();
            this.editNameTextBox = new System.Windows.Forms.TextBox();
            this.submitEditButton = new System.Windows.Forms.Button();
            this.editGroupComboBox = new System.Windows.Forms.ComboBox();
            this.editEntryTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // editGroupLabel
            // 
            this.editGroupLabel.AutoSize = true;
            this.editGroupLabel.Location = new System.Drawing.Point(12, 102);
            this.editGroupLabel.Name = "editGroupLabel";
            this.editGroupLabel.Size = new System.Drawing.Size(36, 13);
            this.editGroupLabel.TabIndex = 15;
            this.editGroupLabel.Text = "Group";
            // 
            // editAddressLabel
            // 
            this.editAddressLabel.AutoSize = true;
            this.editAddressLabel.Location = new System.Drawing.Point(12, 76);
            this.editAddressLabel.Name = "editAddressLabel";
            this.editAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.editAddressLabel.TabIndex = 14;
            this.editAddressLabel.Text = "Address";
            // 
            // editAddressReadOnlyTextBox
            // 
            this.editAddressReadOnlyTextBox.Location = new System.Drawing.Point(81, 73);
            this.editAddressReadOnlyTextBox.Name = "editAddressReadOnlyTextBox";
            this.editAddressReadOnlyTextBox.ReadOnly = true;
            this.editAddressReadOnlyTextBox.Size = new System.Drawing.Size(135, 20);
            this.editAddressReadOnlyTextBox.TabIndex = 13;
            // 
            // editPhonesLabel
            // 
            this.editPhonesLabel.AutoSize = true;
            this.editPhonesLabel.Location = new System.Drawing.Point(12, 50);
            this.editPhonesLabel.Name = "editPhonesLabel";
            this.editPhonesLabel.Size = new System.Drawing.Size(49, 13);
            this.editPhonesLabel.TabIndex = 12;
            this.editPhonesLabel.Text = "Phone(s)";
            // 
            // editPhonesReadOnlyTextBox
            // 
            this.editPhonesReadOnlyTextBox.Location = new System.Drawing.Point(81, 47);
            this.editPhonesReadOnlyTextBox.Name = "editPhonesReadOnlyTextBox";
            this.editPhonesReadOnlyTextBox.ReadOnly = true;
            this.editPhonesReadOnlyTextBox.Size = new System.Drawing.Size(135, 20);
            this.editPhonesReadOnlyTextBox.TabIndex = 11;
            // 
            // editNameLabel
            // 
            this.editNameLabel.AutoSize = true;
            this.editNameLabel.Location = new System.Drawing.Point(12, 24);
            this.editNameLabel.Name = "editNameLabel";
            this.editNameLabel.Size = new System.Drawing.Size(35, 13);
            this.editNameLabel.TabIndex = 10;
            this.editNameLabel.Text = "Name";
            // 
            // editNameReadOnlyTextBox
            // 
            this.editNameReadOnlyTextBox.Location = new System.Drawing.Point(81, 21);
            this.editNameReadOnlyTextBox.Name = "editNameReadOnlyTextBox";
            this.editNameReadOnlyTextBox.ReadOnly = true;
            this.editNameReadOnlyTextBox.Size = new System.Drawing.Size(135, 20);
            this.editNameReadOnlyTextBox.TabIndex = 9;
            // 
            // editGroupReadOnlyTextBox
            // 
            this.editGroupReadOnlyTextBox.Location = new System.Drawing.Point(81, 102);
            this.editGroupReadOnlyTextBox.Name = "editGroupReadOnlyTextBox";
            this.editGroupReadOnlyTextBox.ReadOnly = true;
            this.editGroupReadOnlyTextBox.Size = new System.Drawing.Size(135, 20);
            this.editGroupReadOnlyTextBox.TabIndex = 16;
            // 
            // editAddressTextBox
            // 
            this.editAddressTextBox.Location = new System.Drawing.Point(222, 73);
            this.editAddressTextBox.Name = "editAddressTextBox";
            this.editAddressTextBox.Size = new System.Drawing.Size(211, 20);
            this.editAddressTextBox.TabIndex = 19;
            // 
            // editPhonesTextBox
            // 
            this.editPhonesTextBox.Location = new System.Drawing.Point(222, 47);
            this.editPhonesTextBox.Name = "editPhonesTextBox";
            this.editPhonesTextBox.Size = new System.Drawing.Size(211, 20);
            this.editPhonesTextBox.TabIndex = 18;
            this.editEntryTooltip.SetToolTip(this.editPhonesTextBox, "Separate by a comma");
            // 
            // editNameTextBox
            // 
            this.editNameTextBox.Location = new System.Drawing.Point(222, 21);
            this.editNameTextBox.Name = "editNameTextBox";
            this.editNameTextBox.Size = new System.Drawing.Size(211, 20);
            this.editNameTextBox.TabIndex = 17;
            // 
            // submitEditButton
            // 
            this.submitEditButton.Location = new System.Drawing.Point(358, 128);
            this.submitEditButton.Name = "submitEditButton";
            this.submitEditButton.Size = new System.Drawing.Size(75, 23);
            this.submitEditButton.TabIndex = 21;
            this.submitEditButton.Text = "Save";
            this.submitEditButton.UseVisualStyleBackColor = true;
            this.submitEditButton.Click += new System.EventHandler(this.submitEditButton_Click);
            // 
            // editGroupComboBox
            // 
            this.editGroupComboBox.FormattingEnabled = true;
            this.editGroupComboBox.Location = new System.Drawing.Point(222, 99);
            this.editGroupComboBox.Name = "editGroupComboBox";
            this.editGroupComboBox.Size = new System.Drawing.Size(211, 21);
            this.editGroupComboBox.TabIndex = 22;
            // 
            // editEntryTooltip
            // 
            this.editEntryTooltip.ToolTipTitle = "Tooltip!";
            this.editEntryTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.editEntryTooltip_Popup);
            // 
            // EditEntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 206);
            this.Controls.Add(this.editGroupComboBox);
            this.Controls.Add(this.submitEditButton);
            this.Controls.Add(this.editAddressTextBox);
            this.Controls.Add(this.editPhonesTextBox);
            this.Controls.Add(this.editNameTextBox);
            this.Controls.Add(this.editGroupReadOnlyTextBox);
            this.Controls.Add(this.editGroupLabel);
            this.Controls.Add(this.editAddressLabel);
            this.Controls.Add(this.editAddressReadOnlyTextBox);
            this.Controls.Add(this.editPhonesLabel);
            this.Controls.Add(this.editPhonesReadOnlyTextBox);
            this.Controls.Add(this.editNameLabel);
            this.Controls.Add(this.editNameReadOnlyTextBox);
            this.Name = "EditEntryView";
            this.Text = "Edit Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label editGroupLabel;
        private System.Windows.Forms.Label editAddressLabel;
        private System.Windows.Forms.TextBox editAddressReadOnlyTextBox;
        private System.Windows.Forms.Label editPhonesLabel;
        private System.Windows.Forms.TextBox editPhonesReadOnlyTextBox;
        private System.Windows.Forms.Label editNameLabel;
        private System.Windows.Forms.TextBox editNameReadOnlyTextBox;
        private System.Windows.Forms.TextBox editGroupReadOnlyTextBox;
        private System.Windows.Forms.TextBox editAddressTextBox;
        private System.Windows.Forms.TextBox editPhonesTextBox;
        private System.Windows.Forms.TextBox editNameTextBox;
        private System.Windows.Forms.Button submitEditButton;
        private System.Windows.Forms.ComboBox editGroupComboBox;
        private System.Windows.Forms.ToolTip editEntryTooltip;
    }
}