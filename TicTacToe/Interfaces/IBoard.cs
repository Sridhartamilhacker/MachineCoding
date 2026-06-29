namespace TicTacToe.Interfaces;

public interface IBoard
{
    char[,] Grid { get; }
    bool PlaceSymbol(int row, int column, char symbol);
}