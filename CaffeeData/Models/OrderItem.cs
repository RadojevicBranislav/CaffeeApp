using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int ItemQuantity { get; set; }

        public int ItemId { get; set; }

        public int BillId { get; set; }

        public OrderItem(int BillId, int itemId, int itemQuantity)
        {
            this.ItemQuantity = itemQuantity;

            this.ItemId = itemId;

            this.BillId = this.BillId;
        }
        public OrderItem()
        {

        }

    }
}
