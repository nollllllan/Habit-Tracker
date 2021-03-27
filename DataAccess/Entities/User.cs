using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;
using DataAccess.Enums;

namespace DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(450)]
        [Index(IsUnique = true)]
        public string Login { get; set; }
        public string Password { get; set; }
        public UserCapability Capability { get; set; }
        public IEnumerable<Habit> Habits { get; set; } = new List<Habit>();
    }
}