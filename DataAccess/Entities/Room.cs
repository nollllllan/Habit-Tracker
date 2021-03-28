using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<User> Users { get; set; } = new List<User>();
        public int MemberCount => Users.Count();
    }
}