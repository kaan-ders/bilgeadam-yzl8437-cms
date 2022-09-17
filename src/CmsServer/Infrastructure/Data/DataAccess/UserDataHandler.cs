using CmsServer.Infrastructure.Data.Models;

namespace CmsServer.Infrastructure.Data.DataAccess
{
    public class UserDataHandler : DataHandlerBase
    {
        public UserDataHandler(CmsDbContext dbContext) : base(dbContext) { }

        public User LoginAdmin(string username, string password)
        {
            //select top 1 * from User where IsDeleted = 0 and Email = @username and Password = @password
            return _dbContext.User.FirstOrDefault(x => x.IsDeleted == false && x.Email == username && x.Password == password && x.IsAdmin == true);
        }
    }
}