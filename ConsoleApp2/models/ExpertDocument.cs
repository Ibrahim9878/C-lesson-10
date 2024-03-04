namespace ConsoleApp2.models;

public class ExpertDocument:ProDocumentProgram
{
    public override void OpenDocument()
    {
        base.OpenDocument();
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Document Saved in pdf format");
    }
    public ExpertDocument(string name):base()
    {
        
    }
}
