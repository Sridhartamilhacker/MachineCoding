using VendingMachine.Interfaces;

namespace VendingMachine.Implementation.States;

public class WaitingForMoneyState(Main.VendingMachine machine) : IVendingMachineState
{
    public void InsertMoney(decimal money)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{money} money has been inserted");
        machine.CurrentInsertedMoney += money;
        Console.ResetColor();
        if (machine.CurrentInsertedMoney >= machine.SelectedProductPrice)
        {
            machine.SetState(machine.DispensingState);
        }
    }

    public void SelectProduct(string productId)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{productId} has been selected");
        Console.ResetColor();
    }

    public void DispenseProduct()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Insert the money to dispense");
        Console.ResetColor();
    }

    public void CancelTransaction()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("No Transaction has currently active!");
        Console.ResetColor();
        machine.SetState(machine.IdleState);
    }
}