using CmsServer.Infrastructure.Data.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace CmsServer.Controllers
{
    public class HomeController : Controller
    {
        private IDataHandler _dataHandler;
        public HomeController(IDataHandler dataHandler)
        {
            _dataHandler = dataHandler;
        }

        public IActionResult Index()
        {
            //_dataHandler.User.AdminleriGetir();

            return View();
            //DataHandler handler = new DataHandler();
            //handler.UserHandler.GetList(id)
        }
    }
}