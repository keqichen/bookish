using Bookish.Controllers;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookish;
//use dependency injection;
public class bookServices : ICanDoTheThing
{
    private readonly validateServices _validation;

    public bookServices(validateServices validation)
    {
        _validation = validation;
    }

    BookishContext context = new BookishContext();

    //First method
    public List<BookModel> GenerateBookList()
    {
        return context.Books.ToList();
    }

    //Second method
    public void AddNewBook(AddBookModel book)
    {
        _validation.validateAddBook(book);
        using (context)
        {
            var newBook = new BookModel(book.Title, book.Author);
            context.Books!.Add(newBook);
            context.SaveChanges();
        }
    }

    public void CheckOutNewBook(CheckOutModel book)
    {
        _validation.validateCheckOutDate(book);
        using (context)
        {
            BookModel newCheckOut = new BookModel(book.BookId, book.CheckOut, book.MemberId);
            Console.WriteLine(book.CheckOut);

            //updating a existing book here
            BookModel? bookedit = context.Books.ToList().Find(i => i.Id == book.BookId);

            //pass in user's input to the Books DB;
            bookedit.MemberId = newCheckOut.MemberId;

            //need to change the formatting in the frontend;
            bookedit.CheckOut = newCheckOut.CheckOut;

            //we could generate the whole datetime automatically
            bookedit.CheckOut = DateTime.Now;
            context.SaveChanges();
        }

    }

public List<BookModel> SearchBook(SearchModel searchInput)
    {
        var matchingBooks = context.Books
            .Where(s => s.Title == searchInput.SearchInput || s.Author == searchInput.SearchInput)
            .ToList();   
        return matchingBooks;       
    }
}