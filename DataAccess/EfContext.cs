using System.Data.Entity;
using DataAccess.Entities;

namespace DataAccess
{
    public class EfContext : DbContext
    {
        public EfContext(string connection) : base(connection)
        { }

        public IDbSet<User> Users { get; set; }
        public IDbSet<Habit> Habits { get; set; }
        public IDbSet<Room> Rooms { get; set; }
        public IDbSet<RoomMembership> RoomMembership { get; set; }
    }
}