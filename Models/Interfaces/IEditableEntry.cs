namespace Models.Interfaces
{
    public interface IEditableEntry : IEntry
    {
        string CurrentEntryName { get; }
        string CurrentPhone { get; }
        string CurrentAddress { get; }
        int CurrentGroupId { get; }
    }
}
