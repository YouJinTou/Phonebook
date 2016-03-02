using Models.Interfaces;
using System.Collections.Generic;

namespace Models
{
    // An editable entry is an entry that has two additional fields.
    // That way we can tell the database which entry needs to be edited
    // --- This class is the result of my failing to think far enough ahead ---
    public class EditableEntry : Entry, IEditableEntry
    {
        private string currentEntryName;
        private string currentPhone;
        private string currentAddress;
        private int currentGroupId;

        public EditableEntry(string name, ICollection<string> phoneNumbers, string address,
            Group group, string currentEntryName, string currentPhone,
            string currentAddress, int currentGroupId)
            : base(name, phoneNumbers, address, group)
        {
            this.currentEntryName = currentEntryName;
            this.currentPhone = currentPhone;
            this.currentAddress = currentAddress;
            this.currentGroupId = currentGroupId;
        }

        public string CurrentEntryName
        {
            get { return this.currentEntryName; }
        }

        public string CurrentPhone
        {
            get { return this.currentPhone; }
        }

        public string CurrentAddress
        {
            get { return this.currentAddress; }
        }
        public int CurrentGroupId
        {
            get { return this.currentGroupId; }
        }
    }
}
