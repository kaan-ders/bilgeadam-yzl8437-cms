using CmsServer.Infrastructure.Data.DataAccess;
using CmsServer.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CmsServer.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[AuthActionFilter]
    public class SayiController : Controller
    {
        private IDataHandler _dataHandler;
        private IHttpContextAccessor _httpContextAccessor;
        public SayiController(IDataHandler dataHandler, IHttpContextAccessor httpContextAccessor)
        {
            _dataHandler = dataHandler;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index(Guid id)
        {
            List<Sayi> liste = _dataHandler.Sayi.Listele();
            _httpContextAccessor.HttpContext.Session.SetString("DergiId", id.ToString());

            return View(liste);
        }

        public IActionResult Add(Guid? id)
        {
            if (id != null)
            {
                Sayi sayi = _dataHandler.Sayi.Getir(id.Value);                
                return View(sayi);
            }
            else
                return View();
        }

        [HttpPost]
        public IActionResult Add(Sayi sayi)
        {
            if(sayi.Id == Guid.Empty)
            {
                sayi.YeniNesneOlarakDoldur();
                sayi.DergiId = Guid.Parse(_httpContextAccessor.HttpContext.Session.GetString("DergiId"));

                _dataHandler.Dergi.Insert(sayi);
            }
            else
            {
                sayi.ModifiyeEdilmisNesneOlarakDoldur();
                _dataHandler.Dergi.Update(sayi);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            Sayi sayi = _dataHandler.Sayi.Getir(id);
            sayi.ModifiyeEdilmisNesneOlarakDoldur();

            sayi.IsDeleted = true;

            _dataHandler.Sayi.Update(sayi);
            return RedirectToAction("Index");
        }
    }
}