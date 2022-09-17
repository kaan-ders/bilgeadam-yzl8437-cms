using CmsServer.Infrastructure.Data.Models;

namespace CmsServer.Infrastructure.Data.DataAccess
{
    public class SayiDataHandler : DataHandlerBase
    {
        public SayiDataHandler(CmsDbContext dbContext) : base(dbContext) { }

        public List<Sayi> Listele()
        {
            //select * from Sayi where IsDeleted = 0 order by name desc
            return _dbContext.Sayi
                .Where(x => x.IsDeleted == false)
                .OrderByDescending(x=> x.No)
                .ToList();
        }

        public Sayi Getir(Guid id)
        {
            //select top 1 * from Sayi where Id = @id
            return _dbContext.Sayi.FirstOrDefault(x => x.Id == id);
        }
    }
}