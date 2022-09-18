using CmsServer.Infrastructure.Authentication;
using CmsServer.Infrastructure.Data.DataAccess;
using CmsServer.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CmsServer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AuthActionFilter]
    public class HomeController : Controller
    {
        private IDataHandler _dataHandler;
        private IHttpContextAccessor _httpContextAccessor;
        public HomeController(IDataHandler dataHandler, IHttpContextAccessor httpContextAccessor)
        {
            _dataHandler = dataHandler;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            List<Dergi> liste = _dataHandler.Dergi.Listele();

            _httpContextAccessor.HttpContext.Session.Remove("DergiId");
            _httpContextAccessor.HttpContext.Session.Remove("SayiId");

            return View(liste);
        }

        public IActionResult Add(Guid? id)
        {
            if(id != null)
            {
                Dergi dergi = _dataHandler.Dergi.Getir(id.Value);
                return View(dergi);
            }
            else
                return View();
        }

        [HttpPost]
        public IActionResult Add(Dergi dergi)
        {
            if(dergi.Id == Guid.Empty)
            {
                dergi.YeniNesneOlarakDoldur();
                _dataHandler.Dergi.Insert(dergi);
            }
            else
            {
                dergi.ModifiyeEdilmisNesneOlarakDoldur();
                _dataHandler.Dergi.Update(dergi);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            Dergi dergi = _dataHandler.Dergi.Getir(id);
            dergi.ModifiyeEdilmisNesneOlarakDoldur();

            dergi.IsDeleted = true;

            _dataHandler.Dergi.Update(dergi);
            return RedirectToAction("Index");
        }
    }
}