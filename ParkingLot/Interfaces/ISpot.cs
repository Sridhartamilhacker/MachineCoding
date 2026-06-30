using ParkingLot.Enums;

namespace ParkingLot.Interfaces;

public interface ISpot
{
    SpotType SpotType { get; }
    bool IsAvailable { get; }
    bool Park(IVehicle vehicle);
    void Remove();
}