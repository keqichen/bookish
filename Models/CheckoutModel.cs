namespace Bookish.Models;

public class CheckOutModel
{
    public int BookId { get; set; }
    public Nullable<DateTime> CheckOut { get; set; }
    public Nullable<int> MemberId { get; set; }

}

