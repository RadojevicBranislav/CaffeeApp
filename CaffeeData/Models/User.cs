using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData.Models
{
    public class User
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool Ownership { get; set; }
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
            Ownership = false;
        }

        public User(string userName, string password, bool ownership)
        {
            UserName = userName;
            Password = password;
            Ownership = ownership;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", UserName, Password, Ownership);
        }

    }
}
