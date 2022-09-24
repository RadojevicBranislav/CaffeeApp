using CaffeeData;
using CaffeeData.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TableRepositoryTests
{
    [TestClass]
    public class TableTests
    {
        Table t1;
        TableRepository tableRepository;

        [TestInitialize]
        public void init()
        {
            tableRepository = new TableRepository();
            t1 = new Table
            {
                Occupied = false,
                position_h = 444,
                position_w = 454
            };
        }

        [TestMethod]
        public void IsPulling()
        {
            Assert.IsNotNull(tableRepository.GetAllTables());
        }
        [TestMethod]
        public void isInserted()
        {
            Assert.IsTrue(this.tableRepository.InsertTable(t1) != 0);
        }
    }
}
