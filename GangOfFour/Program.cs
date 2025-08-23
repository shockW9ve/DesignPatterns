using GangOfFour.Behavioral;

// command pattern
var textEditor = new TextEditor();
var menu = new Menu();

// The client configures the commands
var copyCommand = new CopyCommand(textEditor);
var pasteCommand = new PasteCommand(textEditor, "New Text to Paste.");

Console.WriteLine("Executing Copy Command:");
menu.SetCommand(copyCommand);
menu.PerformAction();
menu.UndoAction();

Console.WriteLine("\nExecuting Paste Command:");
menu.SetCommand(pasteCommand);
menu.PerformAction();
menu.UndoAction();

// chain of responsibility
var lowProcessor = new LowValueProcessor();
var mediumProcessor = new MediumValueProcessor();
var highProcessor = new HighValueProcessor();

// The client builds the chain
lowProcessor.SetNext(mediumProcessor).SetNext(highProcessor);

Console.WriteLine("Processing a low-value order...");
lowProcessor.ProcessOrder(50);

Console.WriteLine("\nProcessing a medium-value order...");
lowProcessor.ProcessOrder(500);

Console.WriteLine("\nProcessing a high-value order...");
lowProcessor.ProcessOrder(5000);

Console.WriteLine("\nProcessing a very high-value order that will fail...");
try
{
    lowProcessor.ProcessOrder(5001);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"An error occurred: {ex.Message}");
    Console.ResetColor();
}

