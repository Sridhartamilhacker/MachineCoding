using ParkingLot.Enums;

namespace ParkingLot.Interfaces;

public interface IVehicle
{
    public string VehicleOwnerName { get; }
    public string VehicleNumber { get; }
    public VehicleType VehicleType { get; }

}