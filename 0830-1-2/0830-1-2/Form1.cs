using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0830_1_2
{
    public partial class Form1 : Form
    {

        string defFirstName;
        string defLastName;

        public Form1()
        {
            InitializeComponent();

            defFirstName = boxFirstName.Text;
            defLastName = boxLastName.Text;
            initFirstName = false;
            initLastName = false;
        }

        private void boxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
        private void boxLastName_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnHello_Click(object sender, EventArgs e)
        {

            bool modFirstName = defFirstName != boxFirstName.Text;
            bool modLastName = defLastName != boxLastName.Text;

            if (modFirstName && modLastName && boxFirstName.Text != "" && boxLastName.Text != "")
            {
                MessageBox.Show("Hey " + StringCapFirst(boxFirstName.Text) + " " + StringCapFirst(boxLastName.Text));
            }
            else
            {

                string showMsg = "";

                if (!modFirstName)
                {
                    showMsg += "You must enter a first name.\n";
                }
                if (!modLastName)
                {
                    showMsg += "You must enter a last name.\n";
                }
                if (boxFirstName.Text == "")
                {
                    showMsg += "You must enter a first name.\n";
                }
                if (boxLastName.Text == "")
                {
                    showMsg += "You must enter a last name.";
                }

                MessageBox.Show(showMsg);
            }

        }

        private string StringCapFirst(string msg) {
            /*
             *  Capitalizes the first character of a string.
             *  Does not take other factors into consideration, eg, is the character a number/symbol.
             */
            msg = Char.ToUpper(msg[0]).ToString() + msg.Substring(1);
            return msg;
        }
    }
}
