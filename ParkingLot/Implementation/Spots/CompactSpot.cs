using ParkingLot.Enums;
using ParkingLot.Interfaces;

namespace ParkingLot.Implementation.Spots;

public class CompactSpot : ISpot
{
    public SpotType SpotType => SpotType.Compact;
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