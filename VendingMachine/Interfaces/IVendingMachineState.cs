namespace VendingMachine.Interfaces;

public interface IVendingMachineState
{
    public void InsertMoney(decimal money);
    public void SelectProduct(string productId);
    public void DispenseProduct();
    public void CancelTransaction();
}