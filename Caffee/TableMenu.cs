using CaffeBusiness;
using CaffeeData;
using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Caffee
{
    public partial class TableMenu : Form
    {
        private readonly ItemBusiness itemBusiness = new ItemBusiness();
        private readonly BillBusiness billBusiness = new BillBusiness();
        private readonly OrderItemBusiness orderItemBusiness = new OrderItemBusiness();
        private readonly TableBusiness tableBusiness = new TableBusiness();
        private readonly ReceiptBusiness receiptBusiness = new ReceiptBusiness();
        private int idTable;
        private bool occ;
        public int billGlobal;
        public TableMenu(int idTable)
        {
            this.idTable = idTable;
            InitializeComponent();

        }

        private void TableMenu_Load(object sender, EventArgs e)
        {
            dataGridViewOrders.ColumnCount = 2;
            dataGridViewOrders.Columns[0].Name = "Item name";
            dataGridViewOrders.Columns[1].Name = "Ammount";
            dataGridViewOrders.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewOrders.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewOrders.Columns[0].FillWeight = 400;
            dataGridViewOrders.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 230, 204, 178);
            dataGridViewOrders.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 99, 65, 44);
            dataGridViewOrders.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 230, 204, 178);
            dataGridViewOrders.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 99, 65, 44);
            dataGridViewOrders.DefaultCellStyle.ForeColor = Color.FromArgb(255, 99, 65, 44);
            dataGridViewOrders.DefaultCellStyle.BackColor = Color.FromArgb(255, 237, 224, 212);

            foreach (Item item in itemBusiness.getAllItems())
            {
                comboBox_Article.Items.Add(item.Name);
            }
            List<string> all = new List<string>();
            all = File.ReadAllLines(Constants.GetPath() + "Sto" + this.idTable + ".txt").ToList();

            foreach (string item in all)
            {
                string[] items = item.Split('+');
                dataGridViewOrders.Rows.Add(items[0], items[1]);
            }
            occ = false;
            label_Total_Price.Text = "Total Price: " + RefreshPrice() + " RSD";
   }

        
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AddToOrder_Click(object sender, EventArgs e)
        {
            string comboItem;
            if (comboBox_Article.Text != null && comboBox_Article.Text != "")
            {
                comboItem = comboBox_Article.Text;
                int ammount = Convert.ToInt32(numericUpDown_Amount.Value);
                numericUpDown_Amount.Value = 1;
                comboBox_Article.SelectedIndex = -1;

                using (StreamWriter streamWriter = new StreamWriter(Constants.GetPath() + "Sto" + this.idTable + ".txt", append: true))
                {
                    streamWriter.WriteLine(comboItem + "+" + ammount);
                }
                dataGridViewOrders.Rows.Add(comboItem, ammount);

                label_Total_Price.Text = "Total Price: " + RefreshPrice() + " RSD";

                occ = true;

                tableBusiness.changeOccupancy(idTable, occ);

            }
            else
            {
                InfoWarningError infoWarningError = new InfoWarningError("You have not selected anything from the list of items","error","OK","CANCEL");
                infoWarningError.ShowDialog();
            }
        }

        private void button_Charge_Click(object sender, EventArgs e)
        {
            Bill b = new Bill(idTable);

            List<OrderItem> orderItems = GetOrderItemsFromFile(idTable);

            billBusiness.insertBill(b);

            int billId = this.billBusiness.getAllBills().Last().Id;

            foreach (OrderItem oi in orderItems)
            {
                oi.BillId = billId;
                orderItemBusiness.insertOrderItem(oi);
            }
            dataGridViewOrders.Rows.Clear();

            occ = false;

            tableBusiness.changeOccupancy(idTable, occ);

            Receipt receipt = new Receipt();

            receipt.Date = DateTime.Now;

            receipt.Price = RefreshPrice();

            receiptBusiness.InsertReceipt(receipt);

            label_Total_Price.Text = "Total price: 00.00 RSD";

            File.WriteAllText(Constants.GetPath() + "Sto" + this.idTable+".txt","");
        }
        private List<OrderItem> GetOrderItemsFromFile(int tableId)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            List<string> all = new List<string>();
            all = File.ReadAllLines(Constants.GetPath() + "Sto" + this.idTable + ".txt").ToList();

            foreach (string item in all)
            {
                string[] items = item.Split('+');
                OrderItem oi = new OrderItem();

                oi.ItemId = itemBusiness.GetIdOfItemName(items[0]);
                oi.ItemQuantity = Convert.ToInt32(items[1]);
                orderItems.Add(oi);
            }

            return orderItems;
        }

        private decimal RefreshPrice()
        {
            decimal currentPrice = 0;

            List<OrderItem> orderItems = GetOrderItemsFromFile(idTable);

            foreach(OrderItem orderItem in orderItems)
            {
                int itemId = orderItem.ItemId;

                decimal priceOfItem = itemBusiness.GetPriceOfItemByName(itemId);

                currentPrice += priceOfItem * orderItem.ItemQuantity;
            }

            return currentPrice;
        }

        private void dataGridViewOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Font = new Font("Microsoft SanS Serif", 10f, FontStyle.Bold);
            e.CellStyle.SelectionBackColor = Color.FromArgb(255, 230, 204, 178);
            e.CellStyle.SelectionForeColor = Color.FromArgb(255, 99, 65, 44);
        }
    }
}
