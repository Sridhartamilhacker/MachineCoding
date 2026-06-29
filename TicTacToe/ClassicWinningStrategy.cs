using TicTacToe.Interfaces;

namespace TicTacToe;

public class ClassicWinningStrategy : IWinningStrategy
{
    public bool CheckWin(IBoard board, char playerSymbol)
    {
        return HorizontalCheck(board, playerSymbol) ||
               VerticalCheck(board, playerSymbol) ||
               DiagonalCheck(board, playerSymbol) ||
               AntiDiagonalCheck(board, playerSymbol);
    }
    private bool HorizontalCheck(IBoard board, char playerSymbol)
    {
        int count = 0;
        for (int i = 0; i < board.Grid.GetLength(0); i++)
        {
            count = 0;
            for (int j = 0; j < board.Grid.GetLength(1); j++)
            {
                if (board.Grid[i, j] == playerSymbol)
                {
                    count++;
                }
            }

            if (count == board.Grid.GetLength(1))
            {
                return true;
            }
        }
        return count == board.Grid.GetLength(1);
    }
    private bool VerticalCheck(IBoard board, char playerSymbol)
    {
        int count = 0;
        for (int i = 0; i < board.Grid.GetLength(1); i++)
        {
            count = 0;
            for (int j = 0; j < board.Grid.GetLength(0); j++)
            {
                if (board.Grid[j, i] == playerSymbol)
                {
                    count++;
                }
            }

            if (count == board.Grid.GetLength(0))
            {
                return true;
            }
        }
        return count == board.Grid.GetLength(0);
    }
    private bool DiagonalCheck(IBoard board, char playerSymbol)
    {
        int count = 0;
        for (int i = 0; i < board.Grid.GetLength(0); i++)
        {
            if (board.Grid[i, i] == playerSymbol)
            {
                count++;
            }
        }
        return count == 3;
    }
    private bool AntiDiagonalCheck(IBoard board, char playerSymbol)
    {
        int count = 0;
        int j = 0;
        for (int i = board.Grid.GetLength(1) - 1; i >= 0; i--)
        {
            if (board.Grid[i, j] == playerSymbol)
            {
                count++;
            }
            j++;
        }
        return count == 3;
    }
}