using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData.Models
{
    public class Owner : User
    {
        public Owner(string userName, string password) : base(userName, password)
        {
            this.Ownership = true;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
