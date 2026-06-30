using ParkingLot.Interfaces;

namespace ParkingLot.Implementation.Fees;

public class FlatRateFeeStrategy : IFeeCalculationStrategy
{
    public decimal CalculateFee(Ticket ticket)
    {
        return 120M;
    }
}