using ParkingLot;
using ParkingLot.Implementation.Fees;
using ParkingLot.Implementation.Vehicles;
using ParkingLot.Interfaces;

IFeeCalculationStrategy feeCalculationStrategy = new HourlyFeeStrategy();
IVehicle car = new Car("Sridhar","234");
IVehicle bike = new Motorcycle("Madhan","345");

ParkingLotManager manger = new ParkingLotManager(feeCalculationStrategy);

Console.WriteLine("Parking Lot Manager");
var carTicket = manger.ParkVehicle(car);
var bikeTicket =  manger.ParkVehicle(bike);
if (CheckTheTicket(bikeTicket, bike))
{
    Console.WriteLine("The Vehicle is parking Lot ");
    CheckOut(bikeTicket, bike, manger);
}
if (CheckTheTicket(carTicket, car))
{
    Thread.Sleep(100);
    Console.WriteLine("The Vehicle is parking Lot ");
    CheckOut(carTicket, car, manger);
}


static bool CheckTheTicket(Ticket? ticket,IVehicle vehicle)
{
    if (ticket == null)
    {
        Console.WriteLine($"The Vehicle can't park {vehicle.VehicleNumber} ");
        return false;
    }
    return true;
}

static void CheckOut(Ticket ticket, IVehicle vehicle, ParkingLotManager manger)
{
    Console.WriteLine($"The Vehicle is removing {vehicle.VehicleNumber} ");
    var price = manger.RemoveVehicle(ticket);
    Console.WriteLine($"Removed {vehicle.VehicleNumber} : Final Price: {price}");
}
