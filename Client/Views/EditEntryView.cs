using Client.Presenters;
using Client.Views.Interfaces;
using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Views
{
    public partial class EditEntryView : Form, IEditEntryView
    {
        private DataLoader loader;
        private EditEntryPresenter presenter;

        public EditEntryView()
        {
            InitializeComponent();
            this.loader = new DataLoader();
            this.presenter = new EditEntryPresenter(this);

            var groups = this.loader.GetGroups();

            this.presenter.LoadGroups(groups);
        }

        public string CurrentEntryName
        {
            get { return this.editNameReadOnlyTextBox.Text; }
        }

        public string CurrentPhone
        {
            get { return this.editPhonesReadOnlyTextBox.Text; }
        }

        public string CurrentAddress
        {
            get { return this.editAddressReadOnlyTextBox.Text; }
        }

        public int CurrentGroupId
        {
            get
            {
                // Acquaintance by default
                int groupId = 3;

                foreach (var group in Enum.GetValues(typeof(Group)))
                {
                    if (group.ToString() == this.editGroupReadOnlyTextBox.Text)
                    {
                        groupId = (int)group;

                        break;
                    }
                }

                return groupId;
            }
        }

        public string Address
        {
            get { return this.editAddressTextBox.Text; }
            set
            {
                this.editAddressReadOnlyTextBox.Text = value;
                this.editAddressTextBox.Text = value;
            }
        }

        public Group Group
        {
            get { return (Group)this.editGroupComboBox.SelectedItem; }
            set { this.editGroupReadOnlyTextBox.Text = value.ToString(); }
        }

        public string EntryName
        {
            get { return this.editNameTextBox.Text; }
            set
            {
                this.editNameReadOnlyTextBox.Text = value;
                this.editNameTextBox.Text = value;
            }
        }

        public string Phones
        {
            get { return this.editPhonesTextBox.Text; }
            set
            {
                this.editPhonesReadOnlyTextBox.Text = value;
                this.editPhonesTextBox.Text = value;
            }
        }

        // This property is used to initially populate the Groups combobox
        public IList<Group> Groups
        {
            set { this.editGroupComboBox.DataSource = value; }
        }

        // IEditEntryView inherits IAddEntryView
        void IAddEntryView.Show()
        {
            this.ShowDialog();
        }

        void IAddEntryView.Close()
        {
            this.Close();
        }

        private void submitEditButton_Click(object sender, EventArgs e)
        {
            this.presenter.EditEntry();
            this.Close();
        }

        private void editEntryTooltip_Popup(object sender, PopupEventArgs e)
        {
        }
    }
}
