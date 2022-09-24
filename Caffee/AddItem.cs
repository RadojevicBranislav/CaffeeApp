using CaffeBusiness;
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
using System.Text.RegularExpressions;
namespace Caffee
{
    public partial class AddItem : Form
    {
        private readonly ItemBusiness itemBusiness = new ItemBusiness();
        public AddItem()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            string Itemnamepattern= @"^[a-zA-Z]([a-zA-Z0-9\s]){3,20}$";
            Item item = new Item(); 
            item.Name = textBoxItemName.Text;
            item.Price = decimal.Parse(textBoxItemPrice.Text);
            Match match = Regex.Match(item.Name, Itemnamepattern);
            if (match.Success && item.Price>0)
            {
                itemBusiness.insertItem(item);
            }
            else
            {
                InfoWarningError infoWarning = new InfoWarningError("Invalid item name!", "error", "OK", "CANCEL");
                infoWarning.ShowDialog();   
            }

        }
    }
}
