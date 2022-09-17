namespace CmsServer.Infrastructure.Data.Models
{
    public class Makale : ModelBase
    {
        public Guid SayiId { get; set; }
        public Sayi Sayi { get; set; }

        public string Icerik { get; set; } //html içerik
    }
}