using VendingMachine.Interfaces;

namespace VendingMachine.Implementation.States;

public class OutOfStockState(Main.VendingMachine machine) : IVendingMachineState
{
    public void InsertMoney(decimal money)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please select a product!!");
        Console.ResetColor();
    }

    public void SelectProduct(string productId)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Stock is out of stock!");
        Console.ResetColor();
    }

    public void DispenseProduct()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please select a product!!");
        Console.ResetColor();
    }

    public void CancelTransaction()
    {
        throw new NotImplementedException();
    }
}