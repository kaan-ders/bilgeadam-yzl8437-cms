namespace CmsWindowsClient.Models
{
    public class Makale : ModelBase
    {
        public Guid SayiId { get; set; }
        public string Baslik { get; set; }
        public string Ozet { get; set; }
        public string Icerik { get; set; } //html içerik
    }
}