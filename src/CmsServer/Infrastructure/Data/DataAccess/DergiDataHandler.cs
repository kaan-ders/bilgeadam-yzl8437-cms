using CmsServer.Infrastructure.Data.Models;

namespace CmsServer.Infrastructure.Data.DataAccess
{
    public class DergiDataHandler : DataHandlerBase
    {
        public DergiDataHandler(CmsDbContext dbContext) : base(dbContext) { }

        public List<Dergi> Listele()
        {
            //select * from Dergi where IsDeleted = 0 order by name
            return _dbContext.Dergi
                .Where(x => x.IsDeleted == false)
                .OrderBy(x=> x.Name)
                .ToList();
        }

        public Dergi Getir(Guid id)
        {
            //select top 1 * from Dergi where Id = @id
            return _dbContext.Dergi.FirstOrDefault(x => x.Id == id);
        }
    }
}