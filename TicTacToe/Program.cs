using TicTacToe;
using TicTacToe.Interfaces;

IUserInterface ui = new ConsoleUserInterface();
IBoardFactory boardFactory = new BoardFactory();
IWinningStrategy winningStrategy = new ClassicWinningStrategy();
Game game = new Game(ui, boardFactory, winningStrategy);
game.Play();