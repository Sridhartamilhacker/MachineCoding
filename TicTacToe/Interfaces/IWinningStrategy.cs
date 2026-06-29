namespace TicTacToe.Interfaces;

public interface IWinningStrategy
{
    bool CheckWin(IBoard board, char playerSymbol);
}