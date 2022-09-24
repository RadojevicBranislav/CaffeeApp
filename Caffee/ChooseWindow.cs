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
    public partial class ChooseWindow : Form
    {
        private string username = "";
        public ChooseWindow(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddNewWaiter_Click(object sender, EventArgs e)
        {
            var cwa = new CreateWaiterAccount();
            cwa.Closed += (s, args) => this.Close();
            this.Hide();
            cwa.Show();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            var mw = new MainWindow(username,true);
            mw.Closed += (s, args) => this.Close();
            this.Hide();
            mw.Show();
        }
    }
}
