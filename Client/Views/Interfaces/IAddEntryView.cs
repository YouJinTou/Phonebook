using Models;
using System.Collections.Generic;

namespace Client.Views.Interfaces
{
    public interface IAddEntryView
    {
        string EntryName { get; set; }
        string Phones { get; set; }
        string Address { get; set; }
        Group Group { get; set; }
        IList<Group> Groups { set; }

        void Show();
        void Close();
    }   
}
