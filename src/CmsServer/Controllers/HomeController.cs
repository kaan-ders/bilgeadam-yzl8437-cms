using Microsoft.AspNetCore.Mvc;

namespace CmsServer.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
            //DataHandler handler = new DataHandler();

            //handler.UserHandler.GetList(id)
        }
    }
}