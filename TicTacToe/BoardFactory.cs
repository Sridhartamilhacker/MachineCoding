using TicTacToe.Interfaces;

namespace TicTacToe;

public class BoardFactory : IBoardFactory
{
    public IBoard CreateBoard()
    {
        return new Board(3, 3);
    }
}