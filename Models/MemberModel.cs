
namespace Bookish.Models;

public class MemberModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }

    // how to link BookModel.Id here?
    public int BookId { get; set; }
    
    public MemberModel (int id, string firstName, string lastName, string address, int bookId){
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        BookId = bookId;
    }
}

