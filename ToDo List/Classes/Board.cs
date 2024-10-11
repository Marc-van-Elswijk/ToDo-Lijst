using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List.Classes;

public class Board
{
    public string Title { get; set; }
    public Task[] Tasks { get; set; }

    public Board(string title, Task[] tasks)
    {
        Title = title;
        Tasks = tasks;
    }

    public void AddTask(Task task)
    {
        Tasks.Append(task);
    }

    public void RemoveTask()
    {
        Tasks = Tasks[1..];
    }

    public Task[] GetTasks()
    {
        return Tasks;
    }

    public void TransferTask(Board board, Task task)
    {
        board.AddTask(task);
        RemoveTask();
    }
}
