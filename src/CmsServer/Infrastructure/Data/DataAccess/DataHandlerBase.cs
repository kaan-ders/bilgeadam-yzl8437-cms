namespace CmsServer.Infrastructure.Data.DataAccess
{
    public abstract class DataHandlerBase
    {
        protected CmsDbContext _dbContext;

        public DataHandlerBase(CmsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Insert(object model)
        {
            _dbContext.Add(model);
            _dbContext.SaveChanges();
        }

        public void Update(object model)
        {
            _dbContext.Update(model);
            _dbContext.SaveChanges();
        }

        public void Delete(object model)
        {
            _dbContext.Remove(model);
            _dbContext.SaveChanges();
        }
    }
}