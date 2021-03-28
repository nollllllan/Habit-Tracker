using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    public class RoomMembership
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual Room Room { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Room")]
        public int RoomId { get; set; }
    }
}