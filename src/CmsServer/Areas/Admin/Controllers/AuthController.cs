using CmsServer.Infrastructure.Data.DataAccess;
using CmsServer.Infrastructure.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CmsServer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private IDataHandler _dataHandler;
        public AuthController(IDataHandler dataHandler)
        {
            _dataHandler = dataHandler;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel viewModel)
        {
            var user = _dataHandler.User.LoginAdmin(viewModel.UserName, viewModel.Password);
            if(user != null)
            {
                HttpContext.Session.SetString("UserId", user.Id.ToString());
                HttpContext.Session.SetString("UserNameSurname", user.NameSurname);

                return RedirectToAction("Index", "Home");
            }
            else
                return View("Login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserId");
            HttpContext.Session.Remove("UserNameSurname");

            return View("Login");
        }
    }
}