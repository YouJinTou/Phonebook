using Models.Interfaces;
using System.Collections.Generic;

namespace Models
{
    // A class to hold all fields for a single phonebook entry
    public class Entry : IEntry
    {
        private int id;
        private int groupId;
        private string EntryName;
        private ICollection<string> phoneNumbers;
        private string address;

        public Entry(string name, ICollection<string> phoneNumbers)
            : this(name, phoneNumbers, null, Group.Acquaintance)
        {
        }

        public Entry(string name, ICollection<string> phoneNumbers, string address)
            : this(name, phoneNumbers, address, Group.Acquaintance)
        {
        }

        public Entry(string name, ICollection<string> phoneNumbers, string address, Group group)
        {
            this.EntryName = name;
            this.phoneNumbers = phoneNumbers;
            this.address = address;
            this.groupId = (int)group;
        }

        #region Properties
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.EntryName; }
            set { this.EntryName = value; }
        }

        public ICollection<string> PhoneNumbers
        {
            get { return this.phoneNumbers; }
            set { this.phoneNumbers = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public int GroupId
        {
            get { return this.groupId; }
            set { this.groupId = value; }
        }
        #endregion
    }
}
