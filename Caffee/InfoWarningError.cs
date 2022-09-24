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
    public partial class InfoWarningError : Form
    {
        private string s_info = "info";
        private string s_warning = "warning";
        private string s_error = "error";
        public InfoWarningError(string windowMessage, string imageType, string yesText, string noText)
        {
            InitializeComponent();
            labelMessageText.Text = windowMessage;
            buttonAnswerYes.Text = yesText;
            buttonAnswerNo.Text = noText;
            if(String.Equals(imageType,s_info))
            {
                pictureBoxImage.BackgroundImage = Properties.Resources.information;
                label_title.Text = "Info";
            }
            else if (String.Equals(imageType, s_warning))
            {
                pictureBoxImage.BackgroundImage = Properties.Resources.information;
                label_title.Text = "Warning";
            }
            else if(String.Equals(imageType,s_error))
            {
                pictureBoxImage.BackgroundImage = Properties.Resources.error;
                label_title.Text = "Error";
            }
            else
            {
                pictureBoxImage.BackgroundImage = Properties.Resources.remove_item_icon1; //test samo
            }

        }
    }
}
