using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaffeeData;
using CaffeeData.Models;
namespace CaffeBusiness
{
    public class OrderItemBusiness
    {
        //instance of OrderItemRepository class that allows us to access data layer
        private readonly OrderItemRepository orderItemRepository = new OrderItemRepository();
        
        //method that calls GetAllOrderItems from OrderItemRepository class and returns list of all OrderedItems

        //method that calls insertOrderItem from OrderItemRepository class and returns true if number of affected rows is !=0
        public bool insertOrderItem(OrderItem o)
        {
            return orderItemRepository.InsertOrderItem(o) != 0;
        }

    }
}
