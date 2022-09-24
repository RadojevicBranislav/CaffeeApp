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
using CaffeBusiness;
using CaffeeData.Models;

namespace Caffee
{
    public partial class CreateWaiterAccount : Form
    {
        private readonly UserBusiness userBusiness;
        public CreateWaiterAccount()
        {
            InitializeComponent();
            userBusiness = new UserBusiness();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreateOwnerAcc_Click(object sender, EventArgs e)
        {
            //upisivanje u fajl za konobare
            //prikazivanje infoboxa da je uspesno kreiran konobar i pitanje da li zelimo da dodamo jos (yes no dialog)
            //yes --> ciscenje textboxova i dodavanje jos jednog konobara
            //no --> prelazak na login formu
            //ciscenje texboxova
            var Passwordpattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*?&])[A-Za-z0-9@$!%*?&]{8,20}$";
            var Userpattern = @"^([a-zA-Z])([a-zA-Z0-9]){4,20}$";
            int check = 0;
            Match match = Regex.Match(textBoxUserName.Text, Userpattern, RegexOptions.None);

            if (match.Success && textBoxUserName.Text != string.Empty)
            {
                check += 1;
            }
            else
            {
                InfoWarningError infoWarning = new InfoWarningError("Your username must begin with a letter, cannot contain . and _ next to eachother and must end in a letter or a digit!", "error", "OK", "CANCEL");
                infoWarning.ShowDialog();
                check = 0;

            }
            if (Regex.IsMatch(textBoxPassword.Text, Passwordpattern) && textBoxUserName.Text != string.Empty)
            {
                check += 1;

            }
            else
            {
                InfoWarningError infoWarning = new InfoWarningError("Your password must containa uppercase letter, lowercase letter, a digit and a special character!", "error", "OK", "CANCEL");
                infoWarning.ShowDialog();
                check = 0;
            }

            if (Regex.IsMatch(textBoxConfirmPassword.Text, Passwordpattern) && textBoxUserName.Text != string.Empty && textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                check += 1;
            }
            else
            {
                InfoWarningError infoWarning = new InfoWarningError("Your password does not match!", "error", "OK", "CANCEL");
                infoWarning.ShowDialog();
                check = 0;
            }
            if (check == 3)
            {
                if (!this.userBusiness.VerifyUserName(textBoxUserName.Text))
                {
                    User user = new User(textBoxUserName.Text, textBoxPassword.Text);
                    userBusiness.insertNewUser(user);
                    InfoWarningError iwe = new InfoWarningError("You have successfully created waiter account!", "info", "OK", "CANCEL");
                    resetTextBoxes();
                    buttonExit.Text = "CONTINUE";
                    iwe.ShowDialog();
                    check = 0;
                }
                else
                {
                    InfoWarningError infoWarning = new InfoWarningError("User name already exists!\nTry another one!", "error", "OK", "CANCEL");
                    resetTextBoxes();
                    infoWarning.ShowDialog();
                    check = 0;
                }

            }



        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //gasenje ove forme i prelazak na login formu
            var lgn = new Login();
            lgn.Closed += (s, args) => this.Close();
            this.Hide();
            lgn.Show();
        }

        private void resetTextBoxes()
        {
            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
        }
    }
}
