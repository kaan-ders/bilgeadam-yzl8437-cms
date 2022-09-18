using Microsoft.AspNetCore.Mvc;
using CmsServer.Infrastructure.Data.DataAccess;
using CmsServer.Infrastructure.Data.Models;

namespace CmsServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentApiController : ControllerBase
    {
        private IDataHandler _dataHandler;
        public ContentApiController(IDataHandler dataHandler)
        {
            _dataHandler = dataHandler;
        }

        [HttpGet("DergiListele")]
        public List<Dergi> DergiListele()
        {
            return _dataHandler.Dergi.Listele();
        }

        [HttpGet("DergiDetay/{id}")]
        public Dergi DergiDetay(Guid id)
        {
            return _dataHandler.Dergi.Getir(id);
        }

        [HttpGet("SayiListele/{id}")]
        public List<Sayi> SayiListele(Guid id)
        {
            return _dataHandler.Sayi.Listele(id);
        }

        [HttpGet("SayiDetay/{id}")]
        public Sayi SayiDetay(Guid id)
        {
            return _dataHandler.Sayi.Getir(id);
        }

        [HttpGet("MakaleListele/{id}")]
        public List<Makale> MakaleListele(Guid id)
        {
            return _dataHandler.Makale.Listele(id);
        }

        [HttpGet("MakaleDetay/{id}")]
        public Makale MakaleDetay(Guid id)
        {
            return _dataHandler.Makale.Getir(id);
        }
    }
}