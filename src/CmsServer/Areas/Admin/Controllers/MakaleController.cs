using CmsServer.Infrastructure.Authentication;
using CmsServer.Infrastructure.Data.DataAccess;
using CmsServer.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CmsServer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AuthActionFilter]
    public class MakaleController : Controller
    {
        private IDataHandler _dataHandler;
        private IHttpContextAccessor _httpContextAccessor;
        public MakaleController(IDataHandler dataHandler, IHttpContextAccessor httpContextAccessor)
        {
            _dataHandler = dataHandler;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index(Guid id)
        {
            List<Makale> liste = _dataHandler.Makale.Listele(id);
            if(_httpContextAccessor.HttpContext.Session.Keys.Contains("SayiId") == false)
                _httpContextAccessor.HttpContext.Session.SetString("SayiId", id.ToString());

            return View(liste);
        }

        public IActionResult Add(Guid? id)
        {
            if (id != null)
            {
                Makale makale = _dataHandler.Makale.Getir(id.Value);
                return View(makale);
            }
            else
                return View();
        }

        [HttpPost]
        public IActionResult Add(Makale makale)
        {
            if(makale.Id == Guid.Empty)
            {
                makale.YeniNesneOlarakDoldur();
                makale.SayiId = Guid.Parse(_httpContextAccessor.HttpContext.Session.GetString("SayiId"));

                _dataHandler.Makale.Insert(makale);
            }
            else
            {
                makale.ModifiyeEdilmisNesneOlarakDoldur();
                _dataHandler.Makale.Update(makale);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            Makale makale = _dataHandler.Makale.Getir(id);
            makale.ModifiyeEdilmisNesneOlarakDoldur();

            makale.IsDeleted = true;

            _dataHandler.Makale.Update(makale);
            return RedirectToAction("Index");
        }
    }
}