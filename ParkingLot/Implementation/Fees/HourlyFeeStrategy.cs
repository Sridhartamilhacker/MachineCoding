using ParkingLot.Interfaces;

namespace ParkingLot.Implementation.Fees;

public class HourlyFeeStrategy : IFeeCalculationStrategy
{
    private readonly decimal _rate = 10m;
    public decimal CalculateFee(Ticket ticket)
    {
        TimeSpan difference =  DateTime.Now - ticket.EntryTime;
        double totalHours = Math.Ceiling(difference.TotalHours);
        return _rate * (decimal)totalHours;
    }
}