namespace Bookish.Models;

public class BookModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string? CheckOut { get; set; }
    public string? CheckIn { get; set; }
    public int? MemberId { get; set; }

//still not nullable;
    public BookModel (int id, string title, string author, string? checkOut, string? checkIn, int? memberId){
        Id = id;
        Title = title;
        Author = author;
        CheckOut = checkOut ?? "n/a";
        CheckIn = checkIn ?? "n/a";
        MemberId = memberId;
    }

    public BookModel (string title, string author){
        Title=title;
        Author=author;
    }
}

