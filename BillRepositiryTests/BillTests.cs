using CaffeeData;
using CaffeeData.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BillRepositiryTests
{
    [TestClass]
    public class BillTests
    {
        Bill bill;
        BillRepository billRepository;
        [TestInitialize]
        public void init()
        {
            billRepository = new BillRepository();
            bill = new Bill
            {
                DateOfIssue = DateTime.Now,
                TableId = 10002
            };
        }
        [TestMethod]
        public void isInserted()
        {
            Assert.IsTrue(this.billRepository.InsertBill(bill) != 0);
        }

        [TestMethod]
        public void isPulling()
        {
            Assert.IsNotNull(this.billRepository.GetAllBills());
        }
    }
}
