namespace Bookish.Models;

public class BookModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    // public string CheckOut { get; set; }
    // public string CheckIn { get; set; }
    public Nullable<DateTime> CheckOut { get; set; }
    public Nullable<DateTime> CheckIn { get; set; }
    public Nullable<int> MemberId { get; set; }

//still not nullable;
    public BookModel (int id, string title, string author, Nullable<DateTime> checkOut, Nullable<DateTime> checkIn, Nullable<int> memberId){
        Id = id;
        Title = title;
        Author = author;
        CheckOut = checkOut;
        CheckIn = checkIn;
        MemberId = memberId;
    }

    public BookModel (string title, string author){
        Title=title;
        Author=author;
    }

    public BookModel (int id, Nullable<DateTime> checkOut, Nullable<int> memberId){
        Id = id;
        CheckOut = checkOut;
        MemberId = memberId;
    }
}

