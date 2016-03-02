using Client.Models;
using Client.Views.Interfaces;
using Equin.ApplicationFramework;
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
        public void RefreshGrid(DataGridView grid, ICollection<Entry> entries, int groupIndex)
        {
            var viewModel = new List<EntryViewModel>();

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

            // Using an external library for sorting and filtering in the DataGridView
            var bindingList = new BindingListView<EntryViewModel>(viewModel);

            if (groupIndex != 0)
            {
                bindingList.ApplyFilter(f => (int)f.Group == groupIndex);
            }

            source.DataSource = bindingList;
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
