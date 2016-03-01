using Client.Models;
using Client.Views.Interfaces;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Client.Presenters
{
    class MainViewPresenter : BasePresenter
    {
        private IMainView view;

        public MainViewPresenter(IMainView view)
        {
            this.view = view;
        }

        // Passing form components like this probably isn't
        // entirely correct from an OOP standpoint.
        // Can't use ICollection<IEntry> for some reason
        public void AssignGridViewColumns(DataGridView grid, ICollection<Entry> entries)
        {
            var viewModel = new HashSet<EntryViewModel>();

            foreach (var entry in entries)
            {
                viewModel.Add(new EntryViewModel()
                {
                    Name = entry.Name,
                    Phone = entry.PhoneNumbers.FirstOrDefault(),
                    Address = entry.Address,
                    Group = (Group)entry.GroupId
                });
            }

            var source = new BindingSource();

            source.DataSource = viewModel;
            grid.DataSource = source;
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
