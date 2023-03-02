using Bookish.Controllers;
using Bookish.Models;

namespace Bookish;

public class validateServices
{
    public void validateAddBook(AddBookModel book)
    {
        if (String.IsNullOrEmpty(book.Title))
        {
            throw new ArgumentOutOfRangeException ("This input is invalid");
        }
    }

    // public void validateCheckOutBook()
    // {

    // }

}