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
        return View(
            book
        );
    }

    [HttpPost]
    public IActionResult AddBook(AddBookModel book)
    {
        using (context)
        {
            var newBook = new BookModel(book.Title, book.Author);
            context.Books!.Add(newBook);
            context.SaveChanges();
        }
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
            //updating a existing book here
            BookModel? bookedit = context.Books.ToList().Find(i => i.Id == book.BookId);
            bookedit.MemberId = newCheckOut.MemberId;
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
