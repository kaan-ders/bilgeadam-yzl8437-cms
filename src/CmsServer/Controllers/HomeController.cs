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
            var liste = _dataHandler.Dergi.Listele();
            return View(liste);
        }

        public IActionResult Sayilar(Guid id)
        {
            var dergi = _dataHandler.Dergi.Getir(id);
            ViewBag.DergiAdi = dergi.Name;

            var liste = _dataHandler.Sayi.Listele(id);
            return View(liste);
        }

        public IActionResult Makaleler(Guid id)
        {
            var sayi = _dataHandler.Sayi.Getir(id);
            //var dergi = _dataHandler.Dergi.Getir(sayi.DergiId);

            ViewBag.Sayi = sayi.No;
            ViewBag.DergiAdi = sayi.Dergi.Name;
            //ViewBag.DergiAdi = dergi.Name;

            var liste = _dataHandler.Makale.Listele(id);
            return View(liste);
        }

        public IActionResult Makale(Guid id)
        {
            var makale = _dataHandler.Makale.Getir(id);
            return View(makale);
        }
    }
}