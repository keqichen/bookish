namespace Bookish.Models;

public class BookModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string CheckOut { get; set; }
    public string CheckIn { get; set; }

    public BookModel (int id, string title, string author, string checkOut, string checkIn){
        Id = id;
        Title = title;
        Author = author;
        CheckOut = checkOut;
        CheckIn = checkIn;
    }
}