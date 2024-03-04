
using ConsoleApp2.models;

string basic;
string pro;
string expert;
Console.Write("Enter name 1: ");
basic = Console.ReadLine();
Console.Write("Enter name 2: ");
pro = Console.ReadLine();
Console.Write("Enter name 3: ");
expert = Console.ReadLine();

documentProgram doc = new documentProgram(basic);
ProDocumentProgram prodoc = new ProDocumentProgram(pro);
ExpertDocument expertdoc = new ExpertDocument(expert);
doc.OpenDocument();
doc.SaveDocument();
doc.EditDocument();
prodoc.SaveDocument();
prodoc.EditDocument();
prodoc.SaveDocument();
expertdoc.SaveDocument();
expertdoc.EditDocument();
expertdoc.OpenDocument();