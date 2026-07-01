using VendingMachine.Interfaces;

namespace VendingMachine.Implementation.States;

public class IdleState(Main.VendingMachine machine) : IVendingMachineState
{
    public void InsertMoney(decimal money)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please select a product!!");
        Console.ResetColor();
    }

    public void SelectProduct(string productId)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Selecting product: {productId}");
        Console.ResetColor();
        machine.SetState(machine.WaitingForMoneyState);
    }

    public void DispenseProduct()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please select a product!!");
        Console.ResetColor();
    }

    public void CancelTransaction()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("No Transaction has currently active!");
        Console.ResetColor();
    }
}