using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CaffeeData.Models
{
    public class Table
    {
        public int Id { get; set; }

        public bool Occupied { get; set; }

        public int position_w { get; set; }

        public int position_h { get; set; }

    }
}
