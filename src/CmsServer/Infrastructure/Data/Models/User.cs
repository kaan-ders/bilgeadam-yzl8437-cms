namespace CmsServer.Infrastructure.Data.Models
{
    public class User : ModelBase
    {
        public string NameSurname { get; set; }
        public string Email { get; set; } //username
        public string Password { get; set; } //hash
        public bool IsAdmin { get; set; }
    }
}