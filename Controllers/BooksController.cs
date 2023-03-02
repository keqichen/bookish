using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish;

namespace Bookish.Controllers;

//Dependency injection;
public interface ICanDoTheThing
{
    List<BookModel> GenerateBookList();
    void AddNewBook(AddBookModel book);
    void CheckOutNewBook(CheckOutModel book);

    // String Method2();
}

public class BooksController : Controller
{
    private readonly ILogger<BooksController> _logger;

    //Dependency Injection;
    private readonly ICanDoTheThing _bookServices;

    //Constructor of BooksController;
    public BooksController(ILogger<BooksController> logger, ICanDoTheThing bookServices)
    {
        _logger = logger;
        _bookServices = bookServices;
    }

    BookishContext context = new BookishContext();

    //get method;
    [ActivatorUtilitiesConstructor]
    public IActionResult Books()
    {
        //var book = context.Books!.ToList();
        var book = _bookServices.GenerateBookList();
        return View(
            book
        );
    }

    [HttpPost]
    public IActionResult AddBook(AddBookModel book)
    // we still need the parameter as we need to pass in user's input from the form.
    {
        _bookServices.AddNewBook(book);
        //and here we can use the "book" argument directly;
        return RedirectToAction("Books");
    }

    public IActionResult AddBook()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CheckOut(CheckOutModel book)
    {
        _bookServices.CheckOutNewBook(book);
        return RedirectToAction("Books");
    }

    public IActionResult Checkout()
    {
        return View();
    }
}
