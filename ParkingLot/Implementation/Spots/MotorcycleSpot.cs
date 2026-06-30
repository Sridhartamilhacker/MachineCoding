using ParkingLot.Enums;
using ParkingLot.Interfaces;

namespace ParkingLot.Implementation.Spots;

public class MotorcycleSpot : ISpot
{
    public SpotType SpotType => SpotType.Motorcycle;
    private IVehicle? _parkedVehicle;
    public bool IsAvailable => _parkedVehicle == null;

    public bool Park(IVehicle vehicle)
    {
        if(!IsAvailable) return false;
        _parkedVehicle = vehicle;
        return true;
    }

    public void Remove()
    {
        _parkedVehicle = null;
    }
}