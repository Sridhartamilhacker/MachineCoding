using ParkingLot.Enums;
using ParkingLot.Interfaces;

namespace ParkingLot.Implementation.Spots;

public class LargeSpot : ISpot
{
    public SpotType SpotType => SpotType.Large;
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