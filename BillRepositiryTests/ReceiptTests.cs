using CaffeeData;
using CaffeeData.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ReceiptRepositoryTests
{
    [TestClass]
    public class ReceiptTests
    {
        private Receipt r1;
        private ReceiptRepository receiptRepository;
        [TestInitialize]
        public void init()
        {
            receiptRepository = new ReceiptRepository();
            r1 = new Receipt
            {
                Date = DateTime.Now,
                Price = 725m
            };
        }

        [TestMethod]
        public void IsInserted()
        {
            bool inserted = false;

            inserted = this.receiptRepository.InsertReceipt(r1) != 0;

            Assert.IsTrue(inserted);
        }
        [TestMethod]
        public void IsGetting()
        {
            Assert.IsNotNull(this.receiptRepository.GetAllReceipts());
        }
    }
}
