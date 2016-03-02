using Client.Views.Interfaces;
using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Presenters
{
    public class EditEntryPresenter : BasePresenter
    {
        private IEditEntryView view;
        private DataLoader loader;

        public EditEntryPresenter(IEditEntryView view)
        {
            this.view = view;
            this.loader = new DataLoader();
        }

        public void EditEntry()
        {
            try
            {
                using (base.connection)
                {
                    base.connection.Open();

                    var currentName = this.view.CurrentEntryName;
                    var currentPhone = this.view.CurrentPhone;
                    var currentAddress = this.view.CurrentAddress;
                    var currentGroupId = this.view.CurrentGroupId;

                    var newName = this.view.EntryName;
                    var newPhones = Array.ConvertAll(
                        this.view.Phones.Split(','), p => p.Trim());
                    var newAddress = this.view.Address;
                    var newGroup = this.view.Group;

                    var entry = new EditableEntry(newName, newPhones, newAddress,
                        newGroup, currentName, currentPhone, currentAddress, currentGroupId);

                    base.data.Edit(entry);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // I can't come up with a good solution for
        // how to pass the groups to the LoadView() method
        public void LoadGroups(IList<Group> groups)
        {
            this.view.Groups = groups;
        }

        public void LoadEditableData(DataGridViewRow currentRow)
        {            
            this.view.EntryName = currentRow.Cells["Name"].Value.ToString();
            this.view.Phones = currentRow.Cells["Phone"].Value.ToString();
            this.view.Address = currentRow.Cells["Address"].Value.ToString();
            var group = currentRow.Cells["Group"].Value.ToString();
            Group groupToLoad = Group.Acquaintance;

            foreach (var enumGroup in Enum.GetValues(typeof(Group)))
            {
                if (enumGroup.ToString() == group)
                {
                    groupToLoad = (Group)enumGroup;

                    break;
                }
            }

            this.view.Group = groupToLoad;
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
