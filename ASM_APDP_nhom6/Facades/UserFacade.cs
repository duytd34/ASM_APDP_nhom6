using ASM_APDP_nhom6.Data;
using ASM_APDP_nhom6.Facades;
using ASM_APDP_nhom6.Models;


namespace YourApp.Facades
{
    public class UserFacade : IUserFacade
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserFacade _userFactory;

        public UserFacade(ApplicationDbContext context, IUserFacade userFactory)
        {
            _context = context;
            _userFactory = userFactory;
        }

        public User CreateUser(string username, string password, string email)
        {
            var user = _userFactory.CreateUser(username, password, email);
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
