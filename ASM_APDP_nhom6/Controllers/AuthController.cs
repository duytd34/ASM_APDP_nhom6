using ASM_APDP_nhom6.Models;
using Microsoft.AspNetCore.Mvc;
using ASM_APDP_nhom6.Facades;


namespace ASM_APDP_nhom6.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthFacade _authFacade;

        public AuthController(AuthFacade authFacade)
        {
            _authFacade = authFacade;
        }

        // GET: Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(string username, string password, string email)
        {
            if (ModelState.IsValid)
            {
                var user = _authFacade.RegisterUser(username, password, email);
                return RedirectToAction("Login");
            }
            return View();
        }

        // GET: Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string username, string password)
        {
            var user = _authFacade.LoginUser(username, password);
            if (user != null)
            {
                return RedirectToAction("Dashboard");
            }
            ModelState.AddModelError("", "Invalid username or password");
            return View();
        }

        // GET: Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
