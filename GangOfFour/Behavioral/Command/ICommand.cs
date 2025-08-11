namespace GangOfFour.Behavioral;

public interface ICommand
{
    void Execute();
    void Undo();
}
