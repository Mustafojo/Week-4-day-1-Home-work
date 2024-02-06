public class AbstractBook : Readable
{
    public string Title {get;set;}
    public string Author {get;set;}
    
    public void Read()
    {
        System.Console.WriteLine("The book is being read.");
    }
}