using System.Collections.Generic;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EfContext _context;

        public UserRepository(EfContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User Get(int id)
        {
            return _context.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public void Remove(int id)
        {
            var entity = _context.Users.Find(id);
            
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            var entity = _context.Users.Find(user.Id);

            _context.Entry(entity).CurrentValues.SetValues(user);
            _context.SaveChanges();
        }
    }
}