using ASM_APDP_nhom6.Facades;
using ASM_APDP_nhom6.Models;

namespace ASM_APDP_nhom6.Facades
{
    public interface IUserFacade
    {
        User CreateUser(string username, string password, string email);  
    }
}
