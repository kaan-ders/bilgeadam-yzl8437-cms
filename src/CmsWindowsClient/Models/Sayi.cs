namespace CmsWindowsClient.Models
{
    public class Sayi : ModelBase
    {
        public Guid DergiId { get; set; }
        public int No { get; set; }
        public DateTime YayinTarihi { get; set; }
    }
}