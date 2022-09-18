using CmsServer.Infrastructure.Data.Models;

namespace CmsServer.Infrastructure.Data.DataAccess
{
    public class MakaleDataHandler : DataHandlerBase
    {
        public MakaleDataHandler(CmsDbContext dbContext) : base(dbContext) { }

        public List<Makale> Listele(Guid sayiId)
        {
            //select * from Makale where IsDeleted = 0 and SayiId = @sayiId order by name desc
            return _dbContext.Makale
                .Where(x => x.IsDeleted == false && x.SayiId == sayiId)
                .OrderBy(x=> x.Baslik)
                .ToList();
        }

        public Makale Getir(Guid id)
        {
            //select top 1 * from Makale where Id = @id
            return _dbContext.Makale.FirstOrDefault(x => x.Id == id);
        }
    }
}