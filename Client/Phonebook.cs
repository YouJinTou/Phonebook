using Client.Presenters;
using Client.Views.Interfaces;
using Data;
using System;
using System.Windows.Forms;

namespace Client
{
    static class Phonebook
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseInitializer.Initializer.InitializeDatabase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainView phonebook = new PhonebookMainView();
            MainViewPresenter presenter = new MainViewPresenter(phonebook);

            presenter.LoadView(); 
        }
    }
}
