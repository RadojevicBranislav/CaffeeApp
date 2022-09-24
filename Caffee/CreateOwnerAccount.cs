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
using System.IO;
namespace Caffee
{
    public partial class CreateOwnerAccount : Form
    {
        private readonly UserBusiness userBusiness = new UserBusiness();
        public CreateOwnerAccount()
        {
            InitializeComponent();
            //proveravanje da li vec postoji vlasnicki nalog
            //ako ne postoji, nista se ne desava,ova forma se normalno pokrece
            //ako postoji, otvara se sledeca forma za login 
            //ova forma se inace otvara samo jednom i to po instalaciji programa
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreateOwnerAcc_Click(object sender, EventArgs e)
        {
            //validiraju se textboxovi
            //login informacije se upisuju u eksterni fajl
            //obavestenje da je uspesno kreiran nalog za vlasnika
            //prelazi se na sledecu formu (ovo ispod)
            var Passwordpattern= @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*?&])[A-Za-z0-9@$!%*?&]{8,20}$";
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
            if (check==3)
            {

                
                Owner owner = new Owner(textBoxUserName.Text,textBoxPassword.Text);
                userBusiness.insertNewOwner(owner);
                InfoWarningError iwe = new InfoWarningError("You have successfully created owner account!", "info", "OK", "CANCEL");
                iwe.ShowDialog();
            }

            var cwa = new CreateWaiterAccount();
            cwa.Closed += (s, args) => this.Close();
            this.Hide();
            cwa.Show();
        }
    }
}
