using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaffeeData;
using CaffeeData.Models;
namespace CaffeBusiness
{
    public class BillBusiness
    {
        //instance of BillRepository that allows us to access methods of data layer
        private readonly BillRepository billRepository = new BillRepository();
        private readonly OrderItemRepository orderItemRepository = new OrderItemRepository();
        //method that calls GetAllBills from billRepository class and returns list of all bills
        public List<Bill> getAllBills()
        {
            List<Bill> bills = billRepository.GetAllBills();
            return bills;
        }
        //method that inserts bill object to InsertBill method on dataLayer
        public bool insertBill(Bill b)
        {
            return billRepository.InsertBill(b) != 0;
        }
    }
}
