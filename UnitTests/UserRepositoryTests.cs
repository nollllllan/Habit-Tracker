using System.Linq;
using DataAccess;
using DataAccess.Entities;
using DataAccess.Enums;
using DataAccess.Repositories;
using NUnit.Framework;

namespace UnitTests
{
    public class Tests
    {
        private UserRepository _repository; 

        [SetUp]
        public void Setup()
        {
            _repository = new UserRepository(new EfContextFactory().Create());
        }

        [Test]
        public void Add_User()
        {
            var user = new User
            {
                Capability = UserCapability.Basic,
                Login = "Test",
                Password = "test"
            };

            _repository.Add(user);
        }

        [Test]
        public void UpdateUser()
        {
            var user = new User
            {
                Id = 2,
                Login = "test2",
                Password = "test"
            };

            _repository.Update(user);
        }

        [Test]
        public void Get_All()
        {
            var users = _repository.GetAll().ToList();
        }

        [Test]
        public void Remove_User()
        {
            const int id = 1;

            _repository.Remove(id);
        }

        [Test]
        public void Get_User()
        {
            const int id = 2;

            var user = _repository.Get(id);
        }
    }
}