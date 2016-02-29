using System.Collections.Generic;

namespace Models
{
    // A class to hold all fields for a single phonebook entry
    public class Entry
    {
        private Category category;
        private string name;
        private ICollection<string> phoneNumbers;
        private string address;

        public Entry(string name, ICollection<string> phoneNumbers)
            : this(name, phoneNumbers, null, Category.Acquaintances)
        {
        }

        public Entry(string name, ICollection<string> phoneNumbers, string address)
            : this(name, phoneNumbers, address, Category.Acquaintances)
        {
        }

        public Entry(string name, ICollection<string> phoneNumbers, string address, Category category)
        {
            this.name = name;
            this.phoneNumbers = new HashSet<string>();
            this.address = address;
            this.category = category;
        }
    }
}
