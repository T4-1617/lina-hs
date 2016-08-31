using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo0831_2
{
    public partial class Form1 : Form
    {
        string arithmetic;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int num1;
            int num2;

            /*
             * Check if textboxes contain only numbers.
             * Calculate if they do.
             * 
             * Show the results.
             */

            bool isNum = int.TryParse(tbNumber1.Text, out num1);
            if (isNum)
            {
                isNum = int.TryParse(tbNumber2.Text, out num2);
                if (isNum)
                {
                    int calc;

                    switch (arithmetic)
                    {
                        case "add":
                            calc = num1 + num2;
                            break;
                        case "sub":
                            calc = num1 - num2;
                            break;
                        case "multi":
                            calc = num1 * num2;
                            break;
                        case "div":
                            calc = num1 / num2;
                            break;
                        default:
                            calc = 0;
                            break;
                    }

                    MessageBox.Show(calc.ToString());

                }
            }
            if (!isNum)
            {
                MessageBox.Show("Please enter numbers in both boxes.");
            }

        }

        /*
         * Set calculation method.
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            arithmetic = "add";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            arithmetic = "sub";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            arithmetic = "multi";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            arithmetic = "div";
        }
    }
}
