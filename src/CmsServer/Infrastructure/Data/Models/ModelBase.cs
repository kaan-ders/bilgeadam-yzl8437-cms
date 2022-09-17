namespace CmsServer.Infrastructure.Data.Models
{
    public abstract class ModelBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public void YeniNesneOlarakDoldur()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
            IsDeleted = false;
        }

        public void ModifiyeEdilmisNesneOlarakDoldur()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}