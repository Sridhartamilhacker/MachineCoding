using ParkingLot.Implementation.Spots;
using ParkingLot.Interfaces;

namespace ParkingLot;

public class Floor(int floorNumber)
{
    public int FloorNumber => floorNumber;

    public List<ISpot> Spots { get; } =
    [
        new CompactSpot(),
        new CompactSpot(),
        new LargeSpot(),
        new LargeSpot(),
        new LargeSpot(),
        new MotorcycleSpot()
    ];

}