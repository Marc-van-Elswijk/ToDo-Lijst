using System.Windows.Documents;

namespace ToDo_List.Classes;

/// <summary>
/// Main task class.
/// </summary>
public class Task
{
    private string TaskName { get; set; }
    private string TaskDescription { get; set; }
    private string? TaskLabel { get; set; }
    private DateTime? TaskDueDate { get; set; }
    private List<List>? SubTasks { get; set; }


    public Task(string taskName, string taskDescription, string taskLabel, DateTime? taskDueDate, List<List>? subTasks)
    {
        TaskName = taskName;
        TaskDescription = taskDescription;
        TaskLabel = taskLabel;
        TaskDueDate = taskDueDate;
        SubTasks = subTasks;
    }

    public string GetTaskName()
    {
        return TaskName;
    }

    public string GetTaskDescription()
    {
        return TaskDescription;
    }

    public string? GetTaskLabel()
    {
        return TaskLabel;
    }

    /// <summary>
    /// Used to retrieve the due date of a task.
    /// </summary>
    /// <returns> DateTime </returns>
    public DateTime? GetTaskDueDate()
    {
        return TaskDueDate;
    }

    /// <summary>
    /// Used to retrieve the subtasks of the task.
    /// </summary>
    /// <returns> List&lt;List&gt; </returns>
    public List<List>? GetSubTasks()
    {
        return SubTasks;
    }
}