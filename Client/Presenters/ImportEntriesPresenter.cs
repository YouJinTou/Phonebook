using System;
using System.IO;
using System.Windows.Forms;

namespace Client.Presenters
{
    public class ImportEntriesPresenter : BasePresenter
    {
        private PhonebookMainView mainView;

        public ImportEntriesPresenter(PhonebookMainView mainView)
        {
            this.mainView = mainView;
        }

        public void ImportEntries(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);

            try
            {
                using (sr)
                {
                    // While (sr.ReadLine != null)
                    // Parse input line by line
                    // Add entry to database
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
