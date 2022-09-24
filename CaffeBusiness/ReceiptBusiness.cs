using CaffeeData;
using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeBusiness
{
    public class ReceiptBusiness
    {
        public ReceiptRepository receiptRepository = new ReceiptRepository();

        public List<Receipt> GetAllReceipts()
        {
            return this.receiptRepository.GetAllReceipts();
        }

        public bool InsertReceipt(Receipt r)
        {
            return receiptRepository.InsertReceipt(r) == 0;
        }

    }
}
