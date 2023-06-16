using Humanizer;

namespace ToDoApp.Library;

public class ToDoItemsManager
{
    public ToDoItemsManager()
    {
        _items = new List<ToDoItem>();
    }

    public void AddItem(ToDoItem item)
    {
        _items.Add(item);
    }

    public void UpdateItem(ToDoItem item)
    {
        var existing = _items.FirstOrDefault(x => x.Id == item.Id);

        if (existing != null)
        {
            existing.Name = item.Name;
            existing.Description = item.Description;
            existing.PlannedOn = item.PlannedOn;
            existing.IsCompleted = item.IsCompleted;
        }
    }

    public void DeleteItem(int id)
    {
        var existing = _items.FirstOrDefault(x => x.Id == id);

        if (existing != null)
        {
            _items.Remove(existing); 
        }
    }

    //public List<ToDoItem> GetAll()
    //{
    //    return _items;      // Guess what is the issue
    //}

    public List<ToDoItem> GetAll()
    {
        var list = new List<ToDoItem>();
        foreach (var item in _items)
        {
            var newItem = new ToDoItem()
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                PlannedOn = item.PlannedOn,
                //HumanizedPlannedOn = item.HumanizedPlannedOn.Humanize(),
                IsCompleted = item.IsCompleted
            };
            list.Add(newItem);
        }
        return list;      // Guess what is the issue
    }

    // Add a method to export data from list to excel

    private readonly List<ToDoItem> _items;
}
