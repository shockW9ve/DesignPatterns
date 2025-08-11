using GangOfFour.Behavioral;

// command pattern
var textEditor = new TextEditor();
var menu = new Menu();

var copyCommand = new CopyCommand(textEditor);
var pasteCommand = new PasteCommand(textEditor, "New text to paste.");

Console.WriteLine("Executing copy command:");
menu.SetCommand(copyCommand);
menu.PerformAction();
menu.UndoAction();

Console.WriteLine("Executing paste command:");
menu.SetCommand(pasteCommand);
menu.PerformAction();
menu.UndoAction();

