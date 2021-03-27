using System.Collections.Generic;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public class HabitRepository : IHabitRepository
    {
        private readonly EfContext _context;

        public HabitRepository(EfContext context)
        {
            _context = context;
        }

        public void Add(Habit habit)
        {
            _context.Habits.Add(habit);
            _context.SaveChanges();
        }

        public Habit Get(int id)
        {
            return _context.Habits.Find(id);
        }

        public IEnumerable<Habit> GetAll()
        {
            return _context.Habits;
        }

        public void Remove(int id)
        {
            var entity = _context.Habits.Find(id);

            _context.Habits.Remove(entity);
        }

        public void Update(Habit habit)
        {
            var entity = _context.Habits.Find(habit.Id);
            entity.GoalResult = habit.GoalResult;
            entity.Name = habit.Name;
            entity.NowResult = habit.NowResult;

            _context.SaveChanges();
        }
    }
}