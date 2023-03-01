
namespace Bookish.Models;

public class MemberModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }

    // how to link BookModel.Id here?
    
    
    public MemberModel (int id, string firstName, string lastName, string address){
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
    }

    public MemberModel (string firstName, string lastName, string address){
        FirstName = firstName;
        LastName = lastName;
        Address = address;
    }
}