using Client.Presenters;
using Client.Views;
using Client.Views.Interfaces;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        void IMainView.Show()
        {
            Application.Run(this);
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            this.AddEntryPresenter = new AddEntryPresenter(new AddEntryView());

            this.AddEntryPresenter.LoadView();
        }

        private void PhonebookMainView_Load(object sender, EventArgs e)
        {
            var entries = this.loader.GetEntries();

            this.presenter.AssignGridViewColumns(this.phoneListGrid, entries);
        }

        private void refreshGridButton_Click(object sender, EventArgs e)
        {
            DataLoader newLoader = new DataLoader();
            var entries = newLoader.GetEntries();

            this.presenter.AssignGridViewColumns(this.phoneListGrid, entries);
        }
    }
}
