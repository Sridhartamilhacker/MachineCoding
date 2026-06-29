namespace TicTacToe;

public class Player(string name, char symbol)
{
    public string Name { get; private set; } = name;
    public char Symbol { get; private set; } = symbol;

}