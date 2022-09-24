using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData.Models
{
    public class Receipt
    {

        public int Id { get; set; }

        public DateTime Date {get;set;}

        public decimal Price { get; set;}

    }
}
