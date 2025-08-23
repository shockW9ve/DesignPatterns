namespace GangOfFour.Behavioral;

public interface IOrderProcessor
{
    IOrderProcessor SetNext(IOrderProcessor nextHandler);
    void ProcessOrder(decimal orderAmount);
}
