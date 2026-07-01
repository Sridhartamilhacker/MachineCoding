using VendingMachine.Interfaces;

namespace VendingMachine.Implementation.States;

public class DispensingState(Main.VendingMachine machine) : IVendingMachineState
{
    public void InsertMoney(decimal money)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The system is dispensing, can't insert money");
        Console.ResetColor();
    }

    public void SelectProduct(string productId)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The system is dispensing, can't select product");
        Console.ResetColor();
    }

    public void DispenseProduct()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Product is dispensing");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Change : {machine.CurrentInsertedMoney - machine.SelectedProductPrice}");
        machine.CurrentInsertedMoney = 0;
        machine.SetState(machine.IdleState);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Product has been dispensed");
        Console.ResetColor();
    }

    public void CancelTransaction()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Transaction has been canceled");
        Console.WriteLine($"Refunding {machine.CurrentInsertedMoney}");
        machine.CurrentInsertedMoney = 0;
        Console.ResetColor();
        machine.SetState(machine.IdleState);
    }
}