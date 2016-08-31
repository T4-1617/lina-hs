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
        // 'Global' variables
        string arithmetic;
        Button highlight = null;

        // Initialize form.
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate values
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int num1;
            int num2;

            bool error = false;
            string msgError = String.Empty;

            string msgCalc = String.Empty;

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
                    bool foundArithmetic = true;

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
                            if (num2 == 0)
                            {
                                error = true;
                                msgError = "Cannot divide by zero.";
                            }
                            else
                            {
                                calc = num1 / num2;
                            }
                            break;
                        default:
                            foundArithmetic = false;
                            break;
                    }
                    if (foundArithmetic)
                    {
                        msgCalc = String.Format("{0} {1} {2} = {3}", num1.ToString(), arithmetic, num2.ToString(), calc.ToString());
                    }
                    else
                    {
                        error = true;
                        msgError = "Arithmetic method not found.";
                    }
                }
            }
            if (!isNum)
            {
                error = true;
                msgError = "Number(s) not found.";
            }

            if (!error)
            {
                lbCalcWindow.Items.Add(msgCalc);
            }
            else
            {
                lbCalcWindow.Items.Add(String.Format("Error: {0}", msgError));
            }

            int visibleItems = lbCalcWindow.ClientSize.Height / lbCalcWindow.ItemHeight;
            lbCalcWindow.TopIndex = Math.Max(lbCalcWindow.Items.Count - visibleItems + 1, 0);
        }

        // Set arithmetic method
        private void btnAdd_Click(object sender, EventArgs e)
        {
            arithmetic = "+";
            HighlightButton(btnAdd);
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            arithmetic = "-";
            HighlightButton(btnSub);
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            arithmetic = "x";
            HighlightButton(btnMulti);
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            arithmetic = "/";
            HighlightButton(btnDiv);
        }

        // Clear calculator
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the textboxes.
            tbNumber1.Text = String.Empty;
            tbNumber2.Text = String.Empty;

            // Clear the arithmetic method.
            arithmetic = String.Empty;
            HighlightButton(null);

            // Clear the listbox.
            lbCalcWindow.Items.Clear();
        }

        // Custom functions
        private void HighlightButton(Button button)
        {
            /*
             *  Highlight arithmetic method
             * 
             *  Clear highlight if button is null.
             */

            if (highlight != null)
            {
                highlight.BackColor = DefaultBackColor;
            }
            if (button != null)
            {
                button.BackColor = Color.FromArgb(100, 231, 76, 60);
                highlight = button;
            }
            else
            {
                highlight = null;
            }
        }
    }
}
