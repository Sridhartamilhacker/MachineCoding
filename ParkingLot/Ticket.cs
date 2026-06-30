using ParkingLot.Interfaces;

namespace ParkingLot;

public class Ticket(IVehicle vehicle, ISpot parkedSpot)
{
    public Guid Id { get; } = Guid.NewGuid();
    public ISpot ParkedSpot = parkedSpot;
    public string VehicleNumber { get; } = vehicle.VehicleNumber;
    public DateTime EntryTime { get; } = DateTime.Now;

}