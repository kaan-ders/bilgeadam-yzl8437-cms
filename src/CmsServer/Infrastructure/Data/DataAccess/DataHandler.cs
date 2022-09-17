namespace CmsServer.Infrastructure.Data.DataAccess
{
    public class DataHandler : IDataHandler
    {
        private CmsDbContext _dbContext;

        public DataHandler(CmsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private UserDataHandler _userDataHandler;
        public UserDataHandler User
        {
            get 
            {
                if (_userDataHandler == null)
                    _userDataHandler = new UserDataHandler(_dbContext);

                return _userDataHandler;
            }
        }

        private DergiDataHandler _dergiDataHandler;
        public DergiDataHandler Dergi
        {
            get
            {
                if (_dergiDataHandler == null)
                    _dergiDataHandler = new DergiDataHandler(_dbContext);

                return _dergiDataHandler;
            }
        }

        private SayiDataHandler _sayiDataHandler;
        public SayiDataHandler Sayi
        {
            get
            {
                if (_sayiDataHandler == null)
                    _sayiDataHandler = new SayiDataHandler(_dbContext);

                return _sayiDataHandler;
            }
        }
    }

    public interface IDataHandler
    {
        UserDataHandler User { get; }
        DergiDataHandler Dergi { get; }
        SayiDataHandler Sayi { get; }
    }
}