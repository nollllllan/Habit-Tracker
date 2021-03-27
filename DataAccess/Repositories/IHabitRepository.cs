using System.Collections.Generic;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public interface IHabitRepository
    {
        public void Add(Habit habit);
        public Habit Get(int id);
        public IEnumerable<Habit> GetAll();
        public void Remove(int id);
        public void Update(Habit habit);
    }
}