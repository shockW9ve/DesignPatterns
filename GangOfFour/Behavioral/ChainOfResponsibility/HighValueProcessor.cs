namespace GangOfFour.Behavioral;

public class HighValueProcessor : AbstractOrderProcessor
{
    public override void ProcessOrder(decimal orderAmount)
    {
        if (orderAmount > 5000)
        {
            throw new ArgumentOutOfRangeException(nameof(orderAmount), "Order value exceeds the maximum limit for this processor.");
        }
        else if (orderAmount > 1000)
        {
            Console.WriteLine($"HighValueProcessor handled order of ${orderAmount}. Requires manager approval.");
        }
        else
        {
            Console.WriteLine($"HighValueProcessor cannot handle order of ${orderAmount}. End of chain.");
        }
    }
}
