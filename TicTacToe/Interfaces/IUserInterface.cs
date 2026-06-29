namespace TicTacToe.Interfaces;

public interface IUserInterface
{
    (int, int) GetTheInput();
    void Display(IBoard board);
}