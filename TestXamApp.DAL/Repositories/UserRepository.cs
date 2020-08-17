using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestXamApp.DAL.Entities;
using TestXamApp.DAL.Repositories.Interfaces;

namespace TestXamApp.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task Create(User user)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Edit(User user)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByCredentials(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public bool UserExists(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
