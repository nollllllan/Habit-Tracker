using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace DataAccess.Entities
{
    public class Habit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NowResult { get; set; }
        public int GoalResult { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public int? RoomId { get; set; }
        public virtual Room Room { get; set; }

    }
}