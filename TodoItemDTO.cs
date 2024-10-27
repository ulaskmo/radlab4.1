using System.Text.Json.Serialization;
using TodoApi;

public class TodoItemDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Status Status { get; set; }

    public int Priority { get; set; }

    public TodoItemDTO() { }
    public TodoItemDTO(Todo todoItem) =>
        (Id, Name, Status, Priority) = (todoItem.Id, todoItem.Name, todoItem.Status, todoItem.Priority);
}