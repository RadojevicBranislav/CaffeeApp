using CaffeeData;
using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeBusiness
{
    public class ItemBusiness
    {
        //instance of ItemRepository class that allows us to access data layer
        private readonly ItemRepository itemRepository = new ItemRepository();
        //invokes GetAllItems method from ItemRepository on DataLayer and return list of all items from database
        public List<Item> getAllItems()
        {
            List<Item> items = itemRepository.GetAllItems();
            return items;
        }
        //invokes InsertItem method from ItemRepository on DataLayer and returns true if number of affected rows is !=0
        public bool insertItem(Item i)
        {
            return itemRepository.InsertItem(i) != 0;
        }
        //invokes UpdatePrice method from ItemRepository on DataLayer and returns true if number of affected rows is !=0
        public bool updatePrice(int id, decimal price, string name)
        {
            return itemRepository.UpdatePriceAndName(id,price,name) != 0;
        }
        public bool deleteItem(int id)
        {
            return itemRepository.DeleteItem(id) != 0;      
        }
        public int GetIdOfItemName(string itemName)
        {
            return itemRepository.GetIdOfNameItem(itemName);
        }
        public decimal GetPriceOfItemByName(int itemId)
        {
            return itemRepository.GetPriceOfItemById(itemId);
        }
    }
}
