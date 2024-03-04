namespace ConsoleApp2.models;

public class documentProgram
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Document OPened");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Can Edit in Pro and Expert versions");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Can Save in Pro and Expert versions");
    }
    public documentProgram()
    {

    }
    public documentProgram(string name)
    {
        
    }
}
