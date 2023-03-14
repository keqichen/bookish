namespace Bookish.Models;
using Bookish.Models;

public class BookViewModel
{
    //public List<BookModel> BookList { get; set; } //the whole book list;
    public List<BookModel> SearchResultList { get; set; }

    public BookViewModel() 
    {
        SearchResultList = new List<BookModel>();
    }

    public BookViewModel(List<BookModel> books) 
    {
        SearchResultList = books;
    }
    public SearchModel Search {get;set;}
}
