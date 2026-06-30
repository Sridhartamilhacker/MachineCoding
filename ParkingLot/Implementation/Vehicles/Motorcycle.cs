using ParkingLot.Enums;
using ParkingLot.Interfaces;

namespace ParkingLot.Implementation.Vehicles;

public class Motorcycle(string ownerName, string vehicleNumber) : IVehicle
{
    public string VehicleOwnerName { get; } = ownerName;
    public string VehicleNumber { get; } =  vehicleNumber;
    public VehicleType VehicleType => VehicleType.Motorcycle;
}