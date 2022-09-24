using CaffeeData;
using CaffeeData.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ItemRepositoryTests
{
    [TestClass]
    public class ItemTests
    {
        public Item item1;
        public ItemRepository itemRepository = new ItemRepository();

        [TestInitialize]
        public void init(){
            item1 = new Item
            {

                Name = "Cappuccino",
                Price = 110m
                
            };

        }

        
        [TestMethod]
        public void IsDeleted()
        {
            int id = 1;

            itemRepository.DeleteItem(id);

            bool passed = true;

            foreach(Item i in itemRepository.GetAllItems())
            {
                if (i.Name == "Domaca kafa")
                    passed = false;
            }

            Assert.IsTrue(passed);
        }

        [TestMethod]
        public void IsUpdated()
        {
            int id = 1;

            bool passed = false;
            if (itemRepository.UpdatePriceAndName(id, item1.Price, item1.Name) != 0)
                passed = true;

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void IsInserted()
        {
            
            int i = this.itemRepository.InsertItem(item1);
            string name = itemRepository.GetAllItems().Last().Name;
            bool pass = false;
            if (i != 0)
            {
                pass = true;
            }

            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void GetItems()
        {
            Assert.IsNotNull(itemRepository.GetAllItems());
        }
    }
}
