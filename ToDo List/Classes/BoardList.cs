using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List.Classes;

public class BoardList
{
    public Board[] Boards { get; set; }

    public BoardList(Board[] boards)
    {
        Boards = boards;
    }

    public void AddBoard(Board board)
    {
        Boards.Append(board);
    }

    public void RemoveBoard()
    {
        Boards = Boards[1..];
    }

    public Board[] GetBoards()
    {
        return Boards;
    }
}
