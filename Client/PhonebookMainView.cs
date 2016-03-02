using Client.Presenters;
using Client.Views;
using Client.Views.Interfaces;
using Data;
using System;
using System.Windows.Forms;

namespace Client
{
    public partial class PhonebookMainView : Form, IMainView
    {
        private DataLoader loader;
        private MainViewPresenter presenter;

        public PhonebookMainView()
        {
            InitializeComponent();            

            this.loader = new DataLoader();
            this.presenter = new MainViewPresenter(this);
        }

        public AddEntryPresenter AddEntryPresenter { get; set; }
        public EditEntryPresenter EditEntryPresenter { get; set; }
        public DeleteEntryPresenter DeleteEntryPresenter { get; set; }
        public ImportEntriesPresenter ImportEntriesPresenter { get; set; }
        public ExportEntriesPresenter ExportEntriesPresenter { get; set; }

        public object Phonebook
        {
            get { return this.phoneListGrid; }
        }

        void IMainView.Show()
        {
            Application.Run(this);
        }

        private void PhonebookMainView_Load(object sender, EventArgs e)
        {
            var entries = this.loader.GetEntries();

            this.filterByGroupComboBox.SelectedIndex = 0;
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            this.AddEntryPresenter = new AddEntryPresenter(new AddEntryView());

            this.AddEntryPresenter.LoadView();
        }     

        private void editEntryButton_Click(object sender, EventArgs e)
        {
            this.EditEntryPresenter = new EditEntryPresenter(new EditEntryView());

            var currentRow = this.phoneListGrid.CurrentRow;

            this.EditEntryPresenter.LoadEditableData(currentRow);

            this.EditEntryPresenter.LoadView();            
        }

        private void deleteEntryButton_Click(object sender, EventArgs e)
        {
            this.DeleteEntryPresenter = new DeleteEntryPresenter();

            var currentRow = this.phoneListGrid.CurrentRow;

            this.DeleteEntryPresenter.DeleteEntry(currentRow);

            // Refreshing the datagrid
            DataLoader newLoader = new DataLoader();
            var entries = newLoader.GetEntries();

            this.presenter.RefreshGrid(this.phoneListGrid, entries, 0);
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            DialogResult result = mainOpenFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = mainOpenFileDialog.FileName;
                this.ImportEntriesPresenter = new ImportEntriesPresenter(this);

                this.ImportEntriesPresenter.ImportEntries(filePath);
            }            
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            this.ExportEntriesPresenter = new ExportEntriesPresenter(this);

            this.ExportEntriesPresenter.ExportEntries();
        }

        private void refreshGridButton_Click(object sender, EventArgs e)
        {
            DataLoader newLoader = new DataLoader();
            var entries = newLoader.GetEntries();
            var groupFilterIndex = this.filterByGroupComboBox.SelectedIndex;

            this.presenter.RefreshGrid(this.phoneListGrid, entries, groupFilterIndex);
        }

        private void filterByGroupComboBox_OnIndexChange(object sender, EventArgs e)
        {
            refreshGridButton_Click(this, null);
        }        
    }
}
