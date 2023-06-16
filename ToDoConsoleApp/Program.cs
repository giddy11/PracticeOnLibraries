using ToDoApp.Library;


var manager = new ToDoItemsManager();

// Add few items
for (int i = 1; i < 6; i++)
{
    manager.AddItem(new ToDoItem()
    {
        Id = i,
        Name = "Test " + i,
        Description = "Description " + i,
        PlannedOn = DateTime.Now.AddMinutes(1),
        IsCompleted = false,
    }); 
}

// Update an item
var item = new ToDoItem()
{
    Id = 2,
    Name = "Updated Test 2",
    Description = "Updated Description 2",
    PlannedOn = DateTime.Now.AddMinutes(2),
    IsCompleted = false,
};
manager.UpdateItem(item);

// Delete an item
manager.DeleteItem(4);

// Display items on the console
var itemList = manager.GetAll();
foreach (var entry in itemList)
{
    Console.WriteLine($"{entry.Id} -  {entry.Name}");
    Console.WriteLine($"Description:  {entry.Description}");
    Console.WriteLine($"Plannned on:  {entry.PlannedOn}");
    //Console.WriteLine($"Plannned on:  {entry.HumanizedPlannedOn}");

    Console.WriteLine($"Is Completed: {entry.IsCompleted}");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();
}