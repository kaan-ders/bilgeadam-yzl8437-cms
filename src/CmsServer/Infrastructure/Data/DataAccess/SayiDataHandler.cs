using CmsServer.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CmsServer.Infrastructure.Data.DataAccess
{
    public class SayiDataHandler : DataHandlerBase
    {
        public SayiDataHandler(CmsDbContext dbContext) : base(dbContext) { }

        public List<Sayi> Listele(Guid dergiId)
        {
            //select * from Sayi where IsDeleted = 0 and DergiId = @dergiId order by name desc
            return _dbContext.Sayi
                .Where(x => x.IsDeleted == false && x.DergiId == dergiId)
                .OrderByDescending(x=> x.No)
                .ToList();
        }

        public Sayi Getir(Guid id)
        {
            //select top 1 * from Sayi as s inner join Dergi as d on d.Id = s.DergiId where Id = @id
            return _dbContext.Sayi.Include("Dergi").FirstOrDefault(x => x.Id == id);
        }
    }
}