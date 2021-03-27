using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace DataAccess.Entities
{
    public class Habit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NowResult { get; set; }
        public int GoalResult { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}