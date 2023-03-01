using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;



namespace Bookish.Controllers;

public class BooksController : Controller
{
    private readonly ILogger<BooksController> _logger;

    public BooksController(ILogger<BooksController> logger)
    {
        _logger = logger;
    }

    BookishContext context = new BookishContext();

    //get method;
    public IActionResult Books()
    {
        var book = context.Books!.ToList();
        // BookModel story = new BookModel (1,"story","Michael","2023-01-01","2023-01-15");
        return View(
            book
        );
    }

    [HttpPost]
    public IActionResult AddBook(AddBook book)
    {
        using (context)
        {
            var newBook = new BookModel (book.Title,book.Author);
            context.Books!.Add(newBook);
            context.SaveChanges();
        }

        return RedirectToAction("Books");
    }

// for saving data in the database;
    // public void Data()
    // {
    //     using (context)
    //     {
    //         var book = new BookModel(2, "A good story", "Michael", "2012", "2013", 1);
    //         context.Books!.Add(book);
    //         context.SaveChanges();
    //     }
    // }

}
