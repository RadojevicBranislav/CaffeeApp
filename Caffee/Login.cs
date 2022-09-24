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

namespace Caffee
{
    public partial class Login : Form
    {
        public string passedusername;
        private readonly UserBusiness userBusiness;
        public Login()
        {
            InitializeComponent();
            userBusiness = new UserBusiness();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool proceed = false;
            bool ownership = false;

            List<User> users = this.userBusiness.getAllUsers();

            if(textBoxUserName.Text == string.Empty)
            {
                emptyTextBoxes();
                InfoWarningError infoWarning = new InfoWarningError("Your username cannot be empty!", "error", "OK", "CANCEL");
                infoWarning.ShowDialog();
            }

            if(textBoxPassword.Text == string.Empty)
            {
                emptyTextBoxes();
                InfoWarningError infoWarning = new InfoWarningError("Your password cannot be empty!", "error", "OK", "CANCEL");
                infoWarning.ShowDialog();
            }

            foreach(User u in users)
            {
                Console.WriteLine(u.UserName + " " + u.Password + " " + u.Ownership);

                if(textBoxUserName.Text == u.UserName && textBoxPassword.Text == u.Password)
                {
                    passedusername = textBoxUserName.Text;
                    Console.WriteLine(passedusername);
                    proceed = true;
                    if (u.Ownership)
                        ownership = true;
                }
            }


            if(proceed)
            {
                if(ownership)
                {
                    var cw = new ChooseWindow(passedusername);
                    cw.Closed += (s, args) => this.Close();
                    this.Hide();
                    cw.Show();
                }
                else
                {
                    var mw = new MainWindow(passedusername, ownership);
                    mw.Closed += (s, args) => this.Close();
                    this.Hide();
                    mw.Show();
                }
            }
            else
            {
                InfoWarningError infoWarning = new InfoWarningError("Wrong user name or password", "error", "OK", "CANCEL");
                infoWarning.ShowDialog();
                emptyTextBoxes();
            }
        }

        private void emptyTextBoxes()
        {
            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
