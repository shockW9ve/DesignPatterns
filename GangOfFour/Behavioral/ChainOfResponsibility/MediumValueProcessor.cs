namespace GangOfFour.Behavioral;

public class MediumValueProcessor : AbstractOrderProcessor
{
    public override void ProcessOrder(decimal orderAmount)
    {
        if (orderAmount > 100 && orderAmount <= 1000)
        {
            Console.WriteLine($"MediumValueProcessor handled order of ${orderAmount}. Approved.");
        }
        else
        {
            Console.WriteLine($"MediumValueProcessor cannot handle order of ${orderAmount}. Passing to next handler.");
            base.ProcessOrder(orderAmount);
        }
    }
}

