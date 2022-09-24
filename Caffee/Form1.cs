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
using System.IO;
using SautinSoft.Document;

namespace Caffee
{
    public partial class MainWindow : Form
    {
        private readonly TableBusiness tableBusiness = new TableBusiness();
        private readonly ReceiptBusiness receiptBusiness = new ReceiptBusiness();
        private string username;
        private string rolename;
        private bool ownership;

        ToolTip tableToolTip = new ToolTip();
        public MainWindow(string user_name, bool ownership)
        {
            this.ownership = ownership;
            username = user_name;
            if (ownership)
                rolename = "Owner";
            else
                rolename = "Waiter";

            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Window starts maximized, not resizable and showing taskbar
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            this.WindowState = FormWindowState.Normal;
            this.Location = new Point(0, 0);
            this.Size =  new Size(w, h);

            //Side panel settings
            HideSideMenuContent();
            panel_sideMenu.Size = new Size(38, panel_sideMenu.Height);

            if(tableBusiness.getAllTables().Count > 0)
            {
                foreach(Table table in tableBusiness.getAllTables())
                {
                    TableButton tb = new TableButton();
                    tb.id = table.Id;
                    tb.Location = new Point(table.position_w, table.position_h);

                    tableToolTip.SetToolTip(tb, "Drag to move.\nRight-click to remove.");
                    panelFloor.Controls.Add(tb);
                    
                }
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            foreach (Table table in tableBusiness.getAllTables())
            {
                tableBusiness.updateTable(table.Id,table.position_w,table.position_h);

            }
            this.Close(); 
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_hideMenu_Click(object sender, EventArgs e)
        {
            panel_sideMenu.Size = new Size(38, panel_sideMenu.Height);
            button_showMenu.Visible = true;
            button_hideMenu.Visible = false;
            HideSideMenuContent();
        }

        private void button_showMenu_Click(object sender, EventArgs e)
        {
            panel_sideMenu.Size = new Size(216, panel_sideMenu.Height);
            button_showMenu.Visible = false;
            button_hideMenu.Visible = true;
            ShowSideMenuContent();
        }

        private void ShowSideMenuContent()
        {
            button_addTable.Visible = true;
            button_menu.Visible = true;
            button_dailyRecap.Visible = true;
            button_logout.Visible = true;
            pictureBox_accountPicture.Visible = true;
            label_accountUsername.Visible = true;
            label_accountUsername.Text = username;
            label_accountRole.Visible = true;
            label_accountRole.Text = rolename;
            panel_accountPanel.BackColor = System.Drawing.Color.FromArgb(255, 176, 137, 104);

            if(ownership)
            {
                pictureBox_accountPicture.BackgroundImage = Properties.Resources.owner;
                button_dailyRecap.Enabled = true;
            }
            else
            {
                pictureBox_accountPicture.BackgroundImage = Properties.Resources.waiter;
                button_dailyRecap.Enabled = false;
            }
        }

        private void HideSideMenuContent()
        {
            button_addTable.Visible = false;
            button_menu.Visible = false;
            button_dailyRecap.Visible = false;
            button_logout.Visible = false;
            pictureBox_accountPicture.Visible = false;
            label_accountUsername.Visible = false;
            label_accountRole.Visible = false;
            panel_accountPanel.BackColor = panel_sideMenu.BackColor;

        }

        private void button_addTable_Click(object sender, EventArgs e)
        {
            TableButton tb = new TableButton();
            tb.Location = new Point(panelFloor.Width / 2, panelFloor.Height / 2);
            Table table = new Table();
            table.Occupied = false;
            table.position_h = panelFloor.Height / 2;
            table.position_w = panelFloor.Width / 2;
            tableBusiness.insertTable(table);
            tb.id = tableBusiness.getAllTables().Last().Id;
            tableToolTip.SetToolTip(tb, "Drag to move.\nRight-click to remove.");
            panelFloor.Controls.Add(tb);

            string path = Constants.GetPath() + "Sto" + tableBusiness.getAllTables().Last().Id + ".txt";

            using (FileStream fs = File.Create(path)){}

            Console.WriteLine(tableBusiness.getAllTables().Last().Id);
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            
            MenuSettings ms = new MenuSettings();
            ms.StartPosition = FormStartPosition.Manual;
            int dPosX = (Screen.PrimaryScreen.Bounds.Width / 2) - (ms.Size.Width / 2);
            int dposY = (Screen.PrimaryScreen.Bounds.Height / 2) - (ms.Size.Height / 2);
            ms.Location = new Point(dPosX, dposY);
            ms.ShowDialog();              
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            pictureBox_accountPicture.BackgroundImage = null;
            this.Hide();
            var lg = new Login();
            lg.Closed += (s, args) => this.Close();
            lg.Show();
        }

        private void button_dailyRecap_Click(object sender, EventArgs e)
        {
            string results = "";
            decimal price = 0;
            foreach(Receipt receipt in receiptBusiness.GetAllReceipts())
            {
                results += receipt.Date + "..............." + receipt.Price + "\n";
                price += receipt.Price;
            }
            results += "\n" + "Total earnings for today: " + price;


            DocumentCore dc = new DocumentCore();
            dc.Content.End.Insert("Daily earning report\n\n", new CharacterFormat() { FontName = "Verdana", Size = 28f, FontColor = SautinSoft.Document.Color.Black });
            dc.Content.End.Insert(results, new CharacterFormat() { FontName = "Verdana", Size = 16f, FontColor = SautinSoft.Document.Color.Black});
            dc.Save("Report.pdf");
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("Report.pdf") { UseShellExecute = true });
        }
    }
}
