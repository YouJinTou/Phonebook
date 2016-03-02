using System;
using System.IO;
using System.Windows.Forms;

namespace Client.Presenters
{
    public class ExportEntriesPresenter : BasePresenter
    {
        private PhonebookMainView mainView;

        public ExportEntriesPresenter(PhonebookMainView mainView)
        {
            this.mainView = mainView;
        }

        public void ExportEntries()
        {
            string outputFileLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "phonebook.txt");
            StreamWriter sw = new StreamWriter(outputFileLocation);

            try
            {
                using (sw)
                {
                    var phonebook = (DataGridView)this.mainView.Phonebook;
                   
                    foreach (DataGridViewRow row in phonebook.Rows)
                    {
                        var name = row.Cells["Name"].Value.ToString();
                        var phone = row.Cells["Phone"].Value.ToString();
                        var address = row.Cells["Address"].Value.ToString();
                        var group = row.Cells["Group"].Value.ToString();
                        var result = name + " - " + phone + " - " + address + " - " + group;

                        sw.WriteLine(result);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            MessageBox.Show("Selection exported successfully to: " + outputFileLocation);
        }

        public override void LoadView()
        {
        }

        public override void CloseView()
        {
        }
    }
}
