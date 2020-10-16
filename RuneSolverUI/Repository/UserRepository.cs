using RuneSolverUI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RuneSolverUI.Repository
{    
    interface IUserRepository
    {
        public Users VerifyLogin(string username, string password);
    }

    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {

        }

        public Users VerifyLogin(string username, string password)
        {
            using var context = new runesolverContext();
            var user = context.Users.Where(user => user.Username == username && user.Password == password);
            return (user.Count() == 1) ? user.First() : null;
        }
    }
}
