using TicTacToe.Interfaces;

namespace TicTacToe;

public class Board(int rows, int columns) : IBoard
{

    private const char Symbol = ' ';
    private readonly char[,] _grid = InitGrid(rows, columns);
    public char[,] Grid => _grid;
    private static char[,] InitGrid(int row, int column)
    {
        char[,] grid = new char[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                grid[i, j] = Symbol;
            }
        }
        return grid;
    }

    public bool PlaceSymbol(int row, int column, char symbol)
    {
        if (row < 0 || row >= _grid.GetLength(0) || column < 0 || column >= _grid.GetLength(1))
        {
            return false;
        }
        if (_grid[row, column] != Symbol)
        {
            return false;
        }
        _grid[row, column] = symbol;
        return true;
    }
}