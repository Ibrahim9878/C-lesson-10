namespace ConsoleApp2.models;

public class ProDocumentProgram : documentProgram
{
    public override void OpenDocument()
    {
        base.OpenDocument();
    }
    public sealed override void EditDocument()
    {
        Console.WriteLine("Document Edited");
    }
    public override void SaveDocument()
    {
        Console.WriteLine(" Document Saved in doc format, for pdf format buy Expert packet");
    }
    public ProDocumentProgram()
    {
        
    }
    public ProDocumentProgram(string name)
    {
        Console.WriteLine(name);
    }
}
