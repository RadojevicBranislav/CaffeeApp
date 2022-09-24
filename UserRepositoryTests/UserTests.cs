using CaffeeData;
using CaffeeData.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UserRepositoryTests
{
    [TestClass]
    public class UserTests
    {
        private User u;
        private UserRepository userRepository;
        [TestInitialize]
        public void init()
        {
            userRepository = new UserRepository();
            u = new User("Bane234", "Pajo1231*vas");
        }
        [TestMethod]
        public void IsPullingData()
        {

            Assert.IsNotNull(this.userRepository.GetAllUsers());
        }
        [TestMethod]
        public void IsInserting()
        {
            this.userRepository.InsertNewUser(u);

            bool helpbool = false;

            foreach(User user in userRepository.GetAllUsers())
            {
                if(user.UserName == u.UserName && user.Password == u.Password)
                {
                    helpbool = true;
                }
            }

            Assert.IsTrue(helpbool) ;
        }
    }
}
