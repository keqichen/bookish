namespace Bookish.Models;

public class SearchModel
{
    private string _Input;
    public string SearchInput { 
        get { return _Input ?? string.Empty; }
        set { _Input = value; }
    }
}

