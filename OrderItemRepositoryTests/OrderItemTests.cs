using CaffeeData;
using CaffeeData.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OrderItemRepositoryTests
{
    [TestClass]
    public class OrderItemTests
    {
        OrderItemRepository orderItemRepository = new OrderItemRepository();
        OrderItem oi1;

        [TestInitialize]
        public void init()
        {
            oi1 = new OrderItem
            {
                ItemId = 1,
                ItemQuantity = 7,
                BillId = 1002
            };
        }

        [TestMethod]
        public void InsertOI()
        {
            //DataReader Exception
            bool passed = false;

            if(orderItemRepository.InsertOrderItem(oi1) != 0)
            {
                passed = true;
            }

            Assert.IsTrue(passed);
        }
    }
}
