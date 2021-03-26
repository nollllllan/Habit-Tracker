using DataAccess.Enums;

namespace DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserCapability Capability { get; set; }
    }
}