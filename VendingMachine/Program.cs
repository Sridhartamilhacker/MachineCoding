
VendingMachine.Main.VendingMachine machine = new();

machine.SelectProduct("Coke");
machine.SelectedProductPrice = 10;
machine.InsertCoin(20);
machine.DispenseProduct();

machine.SelectProduct("Milk");
machine.SelectedProductPrice = 20;
machine.InsertCoin(40);
machine.CancelTransaction();
machine.DispenseProduct();


