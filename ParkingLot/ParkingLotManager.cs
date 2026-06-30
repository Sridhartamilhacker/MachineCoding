using ParkingLot.Enums;
using ParkingLot.Interfaces;

namespace ParkingLot;

public class ParkingLotManager(IFeeCalculationStrategy feeCalculationStrategy)
{
    private readonly List<Floor> _floors =
    [
        new Floor(1),
        new Floor(2),
        new Floor(3)
    ];

    public Ticket? ParkVehicle(IVehicle vehicle)
    {
        foreach (Floor floor in _floors)
        {
            foreach (var spot in floor.Spots)
            {
                if (spot.SpotType == SpotType.Compact && vehicle.VehicleType == VehicleType.Car)
                {
                    if (spot.Park(vehicle))
                    {
                        return new Ticket(vehicle,spot);
                    }
                }
                else if (spot.SpotType == SpotType.Large && vehicle.VehicleType == VehicleType.Truck)
                {
                    if (spot.Park(vehicle))
                    {
                        return new Ticket(vehicle,spot);
                    }
                }
                else if(spot.SpotType == SpotType.Motorcycle && vehicle.VehicleType == VehicleType.Motorcycle)
                {
                    if (spot.Park(vehicle))
                    {
                        return new Ticket(vehicle,spot);
                    }
                }
            }
        }

        return null;
    }

    public decimal RemoveVehicle(Ticket ticket)
    {
        ticket.ParkedSpot.Remove();
        var price = feeCalculationStrategy.CalculateFee(ticket);
        return price;
    }
}