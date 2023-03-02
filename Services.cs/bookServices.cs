using Bookish.Controllers;
using Bookish.Models;
namespace Bookish;

public class bookServices : ICanDoTheThing
{

    BookishContext context = new BookishContext();
    //First method
    public List<BookModel> GenerateBookList()
    {
        return context.Books.ToList();
    }

    //Second method
    public void AddNewBook(AddBookModel book)
    {
        using (context)
        {
            var newBook = new BookModel(book.Title, book.Author);
            context.Books!.Add(newBook);
            context.SaveChanges();
        }
    }

}