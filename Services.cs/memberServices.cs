using Bookish.Controllers;
using Bookish.Models;
namespace Bookish;

public class memberServices : MembersManagement
{
    BookishContext context = new BookishContext();
    //First method
    public List<MemberModel> GenerateMemberList()
    {
        return context.Members.ToList();
    }
}