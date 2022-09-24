using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData.Models
{
    public class Bill
    {
        public int Id { get; set; }

        public DateTime DateOfIssue { get; set; }

        public int TableId { get; set; }
        public string formattedDate { get; set; }


      

        public Bill(int tableId)
        {
            DateOfIssue = DateTime.Now;
            formattedDate = DateOfIssue.ToString("yyyy-MM-dd HH:mm:ss.fff");
            TableId = tableId;
        }
        public Bill() { }
    }
}
