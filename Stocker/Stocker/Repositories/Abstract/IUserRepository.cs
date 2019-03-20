using Stocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocker.Repositories.Abstract
{
    public interface IUserRepository
    {
        User GetById(int userId);
        User Authenticate(string email, string password); //Other models will be a Get
        bool AddUpdate(User user);
        bool Delete(User user);
        List<User> GetAllUsers();

    }
}
