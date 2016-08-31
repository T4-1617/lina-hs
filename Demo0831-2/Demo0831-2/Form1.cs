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
                    int calc = 0;
                    bool canCalc = true;

                    switch (arithmetic)
                    {
                        case "+":
                            calc = num1 + num2;
                            break;
                        case "-":
                            calc = num1 - num2;
                            break;
                        case "x":
                            calc = num1 * num2;
                            break;
                        case "/":
                            calc = num1 / num2;
                            break;
                        default:
                            canCalc = false;
                            break;
                    }

                    if (canCalc)
                    {
                        string show = String.Format("{0} {1} {2} = {3}", num1.ToString(), arithmetic, num2.ToString(), calc.ToString());
                        lbCalcWindow.Items.Add(show);
                    }
                    else
                    {
                        string show = "ERROR: Arithmetic method not found.";
                        lbCalcWindow.Items.Add(show);
                    }

                }
            }
            if (!isNum)
            {
                string show = "ERROR: Number(s) not found.";
                lbCalcWindow.Items.Add(show);
            }

        }

        /*
         * Set calculation method.
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            arithmetic = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            arithmetic = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            arithmetic = "x";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            arithmetic = "/";
        }
    }
}
