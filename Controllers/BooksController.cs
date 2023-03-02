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
    public IActionResult AddBook()
    {
        _bookServices.AddNewBook(AddBookModel book);
        // using (context)
        // {
        //     var newBook = new BookModel(book.Title, book.Author);
        //     context.Books!.Add(newBook);
        //     context.SaveChanges();
        // }
        return RedirectToAction("Books");
    }

    public IActionResult AddBook()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CheckOut(CheckOutModel book)
    {
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

        return RedirectToAction("Books");
    }

   
    public IActionResult Checkout()
    {
        return View();
    }


    /*
        public IActionResult AddMember(AddMemberModel member)
        {
            using (context)
            {
                var newMember = new MemberModel (member.FirstName, member.LastName, member.Address);
                context.Members!.Add(newMember);
                context.SaveChanges();
            }
            return RedirectToAction("Members");
        }

            public IActionResult AddMember()
        {
            return View();
        }
    */
}
