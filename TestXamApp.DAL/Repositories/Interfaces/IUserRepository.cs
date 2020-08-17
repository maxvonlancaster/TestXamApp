﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestXamApp.DAL.Entities;

namespace TestXamApp.DAL.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task Create(User user);
        Task Delete(int id);
        Task Edit(User user);
        //Task<User> Get(int id);
        Task<User> GetByCredentials(string userName, string password);
        Task<List<User>> GetAll();
        Task<User> GetByUserName(string userName);
        bool UserExists(string userName);
    }
}
