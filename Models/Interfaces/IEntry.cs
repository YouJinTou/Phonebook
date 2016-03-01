using System.Collections.Generic;

namespace Models.Interfaces
{
    public interface IEntry
    {
        int Id { get; set; }
        string Name { get; set; }
        ICollection<string> PhoneNumbers { get; set; }
        string Address { get; set; }
        int GroupId { get; set; }
    }
}
