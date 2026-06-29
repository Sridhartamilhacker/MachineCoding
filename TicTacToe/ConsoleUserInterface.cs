using TicTacToe.Interfaces;

namespace TicTacToe;

public class ConsoleUserInterface : IUserInterface
{
    public (int,int) GetTheInput()
    {
        Console.Write("> ");
        Console.Write("Enter X coordinate: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("> ");
        Console.Write("Enter Y coordinate: ");
        int col = Convert.ToInt32(Console.ReadLine());
        return (row, col);

    }

    public void Display(IBoard board)
    {
        for (int i = 0; i < board.Grid.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < board.Grid.GetLength(1); j++)
            {
                Console.Write($"{board.Grid[i, j]} ");
            }
            Console.Write(" ]");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}