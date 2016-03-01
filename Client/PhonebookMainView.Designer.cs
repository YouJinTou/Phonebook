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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.phoneListGrid = new System.Windows.Forms.DataGridView();
            this.refreshGridButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addEntryButton
            // 
            this.addEntryButton.Location = new System.Drawing.Point(12, 35);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(75, 23);
            this.addEntryButton.TabIndex = 1;
            this.addEntryButton.Text = "Add";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // phoneListGrid
            // 
            this.phoneListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneListGrid.Location = new System.Drawing.Point(115, 35);
            this.phoneListGrid.Name = "phoneListGrid";
            this.phoneListGrid.Size = new System.Drawing.Size(484, 150);
            this.phoneListGrid.TabIndex = 4;
            // 
            // refreshGridButton
            // 
            this.refreshGridButton.Location = new System.Drawing.Point(524, 191);
            this.refreshGridButton.Name = "refreshGridButton";
            this.refreshGridButton.Size = new System.Drawing.Size(75, 23);
            this.refreshGridButton.TabIndex = 5;
            this.refreshGridButton.Text = "Refresh";
            this.refreshGridButton.UseVisualStyleBackColor = true;
            this.refreshGridButton.Click += new System.EventHandler(this.refreshGridButton_Click);
            // 
            // PhonebookMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 331);
            this.Controls.Add(this.refreshGridButton);
            this.Controls.Add(this.phoneListGrid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addEntryButton);
            this.Name = "PhonebookMainView";
            this.Text = "Phonebook";
            this.Load += new System.EventHandler(this.PhonebookMainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView phoneListGrid;
        private System.Windows.Forms.Button refreshGridButton;
    }
}

