// Implement a task filtering service.

// Create a `TaskItem` class with a title, completion status, and due date. Write a method that:

// - Uses LINQ to find incomplete tasks.
// - Selects tasks whose due dates are before today.
// - Sorts them by due date.
// - Returns an empty collection when no tasks qualify.

using System.Linq;
using Microsoft.VisualBasic;


public class TaskItem
{
    public string Tittle {get; set;} = "";
    public bool CompletionStatus {get; set;}
    public DateOnly Duedate = new DateOnly();

}

public class FilterItems
{
    public List<TaskItem> FilterTasks (List<TaskItem> task)
{
    DateOnly Today = new DateOnly(2026, 11, 4);

    List<TaskItem> filtered = task
    .Where(f => f.CompletionStatus == false)
    .Where(f => f.Duedate < Today)
    .OrderBy(f => f.Duedate).ToList();

    return filtered;
}
}

class Program
{
    public static void Main(string[] args)
    {
        List<TaskItem> items = new List<TaskItem>
        {
            new TaskItem{Tittle = "author", CompletionStatus = false, Duedate = new DateOnly(2023,12,9)},
            new TaskItem{Tittle = "Writer", CompletionStatus = false, Duedate = new DateOnly(2023,2,4)},
            new TaskItem{Tittle = "reader", CompletionStatus = false, Duedate = new DateOnly(2023,1,5)},
            new TaskItem{Tittle = "publisher", CompletionStatus = true, Duedate = new DateOnly(2023,11,04)},
        };

        FilterItems filterItems = new FilterItems();
        var result =  filterItems.FilterTasks(items);

        foreach(var t in result)
        {
            Console.WriteLine($"{t.Tittle}: {t.Duedate}");
        }
    }



}




    


    

    
