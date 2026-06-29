using TicTacToe.Interfaces;

namespace TicTacToe;

public class Game(IUserInterface userInterface, IBoardFactory boardFactory, IWinningStrategy winningStrategy)
{
    private readonly IBoard _board = boardFactory.CreateBoard();
    public void Play()
    {
        Player p1 = new Player("P1", 'X');
        Player p2 = new Player("P2", 'O');
        Player currentPlayer = p1;
        while (true)
        {
            userInterface.Display(_board);
            Console.WriteLine($"{currentPlayer.Name} Enter the move : {currentPlayer.Symbol}");
            var(row,col) = userInterface.GetTheInput();
            var placed = _board.PlaceSymbol(row, col, currentPlayer.Symbol);
            while (!placed)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Entered {currentPlayer.Name} move or wrong place, try again!");
                Console.ResetColor();
                userInterface.Display(_board);
                (row,col) = userInterface.GetTheInput();
                placed = _board.PlaceSymbol(row, col, currentPlayer.Symbol);
            }
            if (winningStrategy.CheckWin(_board, currentPlayer.Symbol))
            {
                Console.WriteLine($"{currentPlayer.Name} Wins!");
                break;
            }

            currentPlayer = currentPlayer == p1 ? p2 : p1;
        }

    }
}