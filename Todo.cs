namespace TodoApi
{
    public class Todo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Status Status { get; set; }
        public int Priority { get; set; }
    }

    public enum Status
    {
        NotStarted,
        InProgress,
        Completed,
        OnHold
    }
}
