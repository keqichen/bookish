using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;


namespace Bookish.Controllers;

public class MembersController : Controller
{
    private readonly ILogger<MembersController> _logger;

    public MembersController(ILogger<MembersController> logger)
    {
        _logger = logger;
    }

    BookishContext context = new BookishContext();

    //get method;
    public IActionResult Members()
    {
        var member = context.Members!.ToList();
        return View(
            member
        );
    }

// for saving data in the database;
    // public void Data()
    // {
    //     using (context)
    //     {
    //         var member = new MemberModel(2, "John", "Smith", "1600 Pensylvania Avenue", );
    //        // context.Books.Add(member);
    //         context.SaveChanges();
    //     }
    // }

}
