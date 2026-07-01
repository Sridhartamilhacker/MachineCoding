using VendingMachine.Implementation.States;
using VendingMachine.Interfaces;

namespace VendingMachine.Main;

public class VendingMachine
{
    private IVendingMachineState _currentState;
    public IdleState IdleState { get; }
    public DispensingState DispensingState { get; }
    public WaitingForMoneyState WaitingForMoneyState { get; }
    public OutOfStockState OutOfStockState { get; }
    public decimal SelectedProductPrice { get; set; }
    public decimal CurrentInsertedMoney { get; set; }
    public VendingMachine()
    {
        IdleState = new(this);
        WaitingForMoneyState = new(this);
        DispensingState = new(this);
        OutOfStockState = new(this);
        _currentState = IdleState;
    }

    public void InsertCoin(decimal coin)
    {
        _currentState.InsertMoney(coin);
    }

    public void DispenseProduct()
    {
        _currentState.DispenseProduct();
    }

    public void SelectProduct(string productId)
    {
        _currentState.SelectProduct(productId);
    }

    public void CancelTransaction()
    {
        _currentState.CancelTransaction();
    }
    public void SetState(IVendingMachineState state)
    {
        _currentState = state;
    }
}