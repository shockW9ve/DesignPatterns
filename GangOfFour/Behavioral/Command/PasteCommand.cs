namespace GangOfFour.Behavioral;

public class PasteCommand : ICommand
{
    private readonly TextEditor _textEditor;
    private readonly string _textToPaste;

    public PasteCommand(TextEditor textEditor, string textToPaste)
    {
        _textEditor = textEditor;
        _textToPaste = textToPaste;
    }

    public void Execute()
    {
        _textEditor.Paste(_textToPaste);
    }

    public void Undo()
    {
        _textEditor.Undo();
    }
}
