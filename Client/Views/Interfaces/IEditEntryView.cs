namespace Client.Views.Interfaces
{
    public interface IEditEntryView : IAddEntryView
    {
        string CurrentEntryName { get; }
        string CurrentPhone { get; }
        string CurrentAddress { get; }
        int CurrentGroupId { get; }
    }   
}
