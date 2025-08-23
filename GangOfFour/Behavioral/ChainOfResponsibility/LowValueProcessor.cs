namespace GangOfFour.Behavioral;

public class LowValueProcessor : AbstractOrderProcessor
{
    public override void ProcessOrder(decimal orderAmount)
    {
        if (orderAmount <= 100)
        {
            Console.WriteLine($"LowValueProcessor handled order of ${orderAmount}. Approved.");
        }
        else
        {
            Console.WriteLine($"LowValueProcessor cannot handle order of ${orderAmount}. Passing to next handler.");
            base.ProcessOrder(orderAmount);
        }
    }
}
