namespace ToDoApp.Library;

public class ToDoItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime PlannedOn { get; set; }
    //public string HumanizedPlannedOn { get; init; }
    public bool IsCompleted { get; set; }
}
