namespace GangOfFour.Behavioral;

public class TextEditor
{
    private string _text;
    private string _previousText;

    public TextEditor()
    {
        _text = "Initial Text.";
        _previousText = string.Empty;
    }

    public void Copy()
    {
        Console.WriteLine($"Copying text: '{_text}'");
        // In a real app, this would copy to a clipboard.
    }

    public void Paste(string textToPaste)
    {
        _previousText = _text;
        _text = textToPaste;
        Console.WriteLine($"Pasting text: '{textToPaste}'");
        Console.WriteLine($"Current text is now: '{_text}'");
    }

    public void Undo()
    {
        _text = _previousText;
        Console.WriteLine("Undoing last action.");
        Console.WriteLine($"Current text is now: '{_text}'");
    }
}
