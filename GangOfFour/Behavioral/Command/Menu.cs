namespace GangOfFour.Behavioral;

public class Menu
{
    private ICommand? _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PerformAction()
    {
        _command?.Execute();
    }

    public void UndoAction()
    {
        _command?.Undo();
    }
}

