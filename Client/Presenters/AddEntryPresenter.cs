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

        public void AddEntry()
        {
            try
            {
                using (base.connection)
                {
                    base.connection.Open();

                    var name = this.view.EntryName;
                    var phones = Array.ConvertAll(
                        this.view.Phones.Split(','), p => p.Trim());
                    var address = this.view.Address;
                    var group = this.view.Group;

                    var entry = new EditableEntry(name, phones, address, group,
                        null, null, null, 0);

                    base.data.Add(entry);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // I can't come up with a good solution for
        // passing the groups to the Loadiew() method
        public void LoadGroups(IList<Group> groups)
        {
            this.view.Groups = groups;
        }

        public override void LoadView()
        {
            this.view.Show();
        }

        public override void CloseView()
        {
            this.view.Close();
        }
    }
}
