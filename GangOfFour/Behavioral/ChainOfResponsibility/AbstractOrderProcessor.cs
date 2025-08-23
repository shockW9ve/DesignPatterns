namespace GangOfFour.Behavioral;

public abstract class AbstractOrderProcessor : IOrderProcessor
{
    private IOrderProcessor? _nextHandler;

    public IOrderProcessor SetNext(IOrderProcessor nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public virtual void ProcessOrder(decimal orderAmount)
    {
        if (_nextHandler != null)
        {
            _nextHandler.ProcessOrder(orderAmount);
        }
    }
}
