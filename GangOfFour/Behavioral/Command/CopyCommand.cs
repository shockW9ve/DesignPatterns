namespace GangOfFour.Behavioral;

public class CopyCommand : ICommand
{
    private readonly TextEditor _textEditor;

    public CopyCommand(TextEditor textEditor)
    {
        _textEditor = textEditor;
    }

    public void Execute()
    {
        _textEditor.Copy();
    }

    public void Undo()
    {
        Console.WriteLine("Copy does not change state, no undo action needed.");
    }
}
