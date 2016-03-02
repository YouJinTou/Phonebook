using Models;
using System;
using System.Windows.Forms;

namespace Client.Presenters
{
    public class DeleteEntryPresenter : BasePresenter
    {
        public DeleteEntryPresenter()
        {
        }

        public void DeleteEntry(DataGridViewRow currentRow)
        {
            try
            {
                using (base.connection)
                {
                    base.connection.Open();

                    var name = currentRow.Cells["Name"].Value.ToString();
                    var phone = currentRow.Cells["Phone"].Value.ToString();
                    var address = currentRow.Cells["Address"].Value.ToString();
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

                    // Passing all necessary parameters so that the GetEntryId method in EntryRepository will work
                    var entry = new EditableEntry(name, null, address, groupToLoad,
                        name, phone, address, (int)groupToLoad);

                    base.data.Delete(entry);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }        

        public override void LoadView()
        {
        }

        public override void CloseView()
        {
        }
    }
}
