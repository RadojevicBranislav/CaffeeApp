using CaffeBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Caffee
{
    public partial class MenuSettings : Form
    {
        private readonly ItemBusiness itemBusiness = new ItemBusiness();
        public MenuSettings()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_menuItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            e.CellStyle.SelectionBackColor = Color.FromArgb(255, 230, 204, 178);
            e.CellStyle.SelectionForeColor = Color.FromArgb(255, 99, 65, 44);
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_menuItems.SelectedRows[0].Cells[0].Value);
            using (DeleteItemConfirm confirmDelete = new DeleteItemConfirm())
            {
                confirmDelete.StartPosition = FormStartPosition.Manual;
                int dPosX = (Screen.PrimaryScreen.Bounds.Width / 2) - (confirmDelete.Size.Width / 2);
                int dposY = (Screen.PrimaryScreen.Bounds.Height / 2) - (confirmDelete.Size.Height / 2);
                confirmDelete.Location = new Point(dPosX, dposY);
                if (confirmDelete.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    itemBusiness.deleteItem(id);
                    RefreshData();
                }
            }
                       
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            using (AddItem addItem = new AddItem())
            {
                addItem.StartPosition = FormStartPosition.Manual;
                int dPosX = (Screen.PrimaryScreen.Bounds.Width / 2) - (addItem.Size.Width / 2);
                int dposY = (Screen.PrimaryScreen.Bounds.Height / 2) - (addItem.Size.Height / 2);
                addItem.Location = new Point(dPosX, dposY);
                if (addItem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    RefreshData();    
                }

            }  
            
        }

        private void buttonEditItem_Click(object sender, EventArgs e)
        {
            string Name = dataGridView_menuItems.SelectedRows[0].Cells[1].Value.ToString();
            decimal Price = Convert.ToDecimal (dataGridView_menuItems.SelectedRows[0].Cells[2].Value);
            int id = Convert.ToInt32(dataGridView_menuItems.SelectedRows[0].Cells[0].Value);
            Console.WriteLine(id);
            Console.WriteLine("Klasa menu settings "+ id);
            using (EditItem editItem = new EditItem(Name,Price,id))
            {
                editItem.StartPosition = FormStartPosition.Manual;
                int dPosX = (Screen.PrimaryScreen.Bounds.Width / 2) - (editItem.Size.Width / 2);
                int dposY = (Screen.PrimaryScreen.Bounds.Height / 2) - (editItem.Size.Height / 2);
                editItem.Location = new Point(dPosX, dposY);
                if (editItem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    RefreshData();
                }

            }
        }

        private void RefreshData()
        {
            dataGridView_menuItems.DataSource = itemBusiness.getAllItems();
   
        }

        private void FormLoad(object sender, EventArgs e)
        {
            RefreshData();
            dataGridView_menuItems.Columns[0].Visible = false;
            dataGridView_menuItems.Columns[2].FillWeight = 25;
        }
    }
}
