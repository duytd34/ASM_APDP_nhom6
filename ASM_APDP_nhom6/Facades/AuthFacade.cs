using ASM_APDP_nhom6.Facades;
using ASM_APDP_nhom6.Models;
using ASM_APDP_nhom6.Data;

namespace ASM_APDP_nhom6.Facades
{
    public class AuthFacade
    {
        private readonly IUserFacade _userFactory;
        private readonly ApplicationDbContext _context;

        public AuthFacade(IUserFacade userFactory, ApplicationDbContext context)
        {
            _userFactory = userFactory;
            _context = context;
        }

        public User RegisterUser(string username, string password, string email)
        {
            var user = _userFactory.CreateUser(username, password, email);
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User LoginUser(string username, string password)
        {
            return _context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
