using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAuth.Models.Repository
{
    public static class UserRepository
    {
        public static User Get(string userName, string password){
            var users = new List<User>{
                new User {Id = 1, UserName = "Batman", Password = "123456", Role = "Manager"},
                new User {Id = 2, UserName = "Robin", Password = "1234567", Role = "Employee"},
            };
            return users
            .FirstOrDefault(x => string.Equals(x.UserName, userName, StringComparison.CurrentCultureIgnoreCase) && x.Password == password);

        }
    }
}