namespace ParkingLot.Interfaces;

public interface IFeeCalculationStrategy
{
    decimal CalculateFee(Ticket ticket);
}