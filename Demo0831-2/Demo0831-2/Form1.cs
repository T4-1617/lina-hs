﻿using System;
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

        // Calculate
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
