namespace Bookish.Models;

public class CheckOutModel
{
    public int BookId { get; set; }
    public string CheckOut { get; set; }
    public Nullable<int> MemberId { get; set; }
}

