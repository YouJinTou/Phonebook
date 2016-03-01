using Client.Views.Interfaces;
using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Presenters
{
    public class AddEntryPresenter : BasePresenter
    {
        private IAddEntryView view;
        private DataLoader loader;

        public AddEntryPresenter(IAddEntryView view)
        {
            this.view = view;
            this.loader = new DataLoader();
        }

        public void AddEntry(IAddEntryView viewModel)
        {
            try
            {
                using (base.connection)
                {
                    base.connection.Open();

                    var name = viewModel.EntryName;
                    var phones = Array.ConvertAll(
                        viewModel.Phones.Split(','), p => p.Trim());
                    var address = viewModel.Address;
                    var group = viewModel.Group;

                    var entry = new Entry(name, phones, address, group);

                    base.data.Add(entry);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public override void LoadView()
        {
            this.view.Show();
        }

        public override void CloseView()
        {
            this.view.Close();
        }

        // I can't come up with a good solution for
        // how to pass the groups to the Loadiew() method
        public void LoadGroups(IList<Group> groups)
        {
            this.view.Groups = groups;
        }
    }
}
