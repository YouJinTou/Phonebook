using Client.Presenters;
using Client.Views.Interfaces;
using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Views
{
    public partial class AddEntryView : Form, IAddEntryView
    {
        private DataLoader loader;
        private AddEntryPresenter presenter;

        public AddEntryView()
        {
            InitializeComponent();
            this.loader = new DataLoader();
            this.presenter = new AddEntryPresenter(this);

            var groups = this.loader.GetGroups();

            this.presenter.LoadGroups(groups);
        }
        
        public string Address
        {
            get { return this.addAddressTextBox.Text; }
            set { this.addAddressTextBox.Text = value; }
        }

        public Group Group
        {
            get { return (Group)this.addGroupComboBox.SelectedItem; }
            set { this.addGroupComboBox.SelectedItem = value; }
        }

        public string EntryName
        {
            get { return this.addNameTextBox.Text; }
            set { this.addNameTextBox.Text = value; }
        }

        public string Phones
        {
            get { return this.addPhonesTextBox.Text; }
            set { this.addPhonesTextBox.Text = value; }
        }

        public IList<Group> Groups
        {
            set { this.addGroupComboBox.DataSource = value; }
        }

        void IAddEntryView.Show()
        {
            this.ShowDialog();
        }

        void IAddEntryView.Close()
        {
            this.Close();
        }

        private void submitEntryButton_Click(object sender, EventArgs e)
        {
            this.presenter.AddEntry();
            this.Close();
        }

        private void addEntryTooltip_Popup(object sender, PopupEventArgs e)
        {
        }
    }
}
