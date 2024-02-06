public class Book : Borrowable
{
    public string Title;
    public string Author;
    public void Borrow()
    {
        System.Console.WriteLine("The book has been borrowed.");
    }
    public void ReturnBook()
    {
        System.Console.WriteLine("The book has been returned.");
    } 

}