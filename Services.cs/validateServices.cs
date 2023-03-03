using Bookish.Controllers;
using Bookish.Models;

namespace Bookish;

public class validateServices
{
    public void validateAddBook(AddBookModel book)
    {
        if (String.IsNullOrEmpty(book.Title))
        {
            throw new ArgumentOutOfRangeException("This input is invalid");
        }
    }

    public void validateCheckOutDate(CheckOutModel book)
    {
        //check the correct syntax of date empty value;
        if (book.CheckOut == null)
        {
            throw new ArgumentOutOfRangeException("This input is invalid");
        }
    }

}