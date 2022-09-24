using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaffeeData;
using CaffeeData.Models;
namespace CaffeBusiness
{
    public class UserBusiness
    {
        private readonly UserRepository userRepository = new UserRepository();
        
        public List<User> getAllUsers()
        {
            List<User> users = userRepository.GetAllUsers();
            return users;
        }
        public void insertNewUser(User user)
        {
            userRepository.InsertNewUser(user) ;
        }
        public void insertNewOwner(Owner owner)
        {
            userRepository.InsertNewOwner(owner) ;  
        }

        public bool VerifyUserName(string uname)
        {
            bool exists = false;

            foreach (User u in userRepository.GetAllUsers())
            {
                if (uname == u.UserName)
                    exists = true;
            }

            return exists;
        }
    }
}
