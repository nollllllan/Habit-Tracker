using System.Collections.Generic;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public interface IUserRepository
    {
        public void Add(User user);
        public User Get(int id);
        public IEnumerable<User> GetAll();
        public void Remove(int id);
        public void Update(User user);
    }
}