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

        List<CalcNum> listNum = new List<CalcNum>();
        int cNum = 0;
        int cParLvL = 0;
        bool errorFound;

        private class CalcNum
        {
            public CalcNum(int number, string o, int parameter)
            {
                num = number;
                op = o;
                parLvL = parameter;
            }
            public int num;             // The number currently being worked with.
            public string op;           // The arithmetic method this number has.
            public int parLvL;          // The parameter level this number has.
        }

        // Initialize form.
        public Form1()
        {
            InitializeComponent();
            listNum.Add(new CalcNum(0, "add", 0));
        }

        // Number pressed
        private void NumberPressed(int number)
        {
            cNum = cNum * 10 + number;
        }
        // Operator pressed
        private void OperatorPressed(string op)
        {
            if (GetOpPrio(op) <= GetOpPrio(listNum[listNum.Count - 1].op))
            {
                CalculateWithPrevCalcNum(op);
            }
            else
            {
                AddCalcNum(op);
            }
            // Compare arithmetic method to previous arithmetic. If equal or below then calculate.
        }
        // Parameter pressed
        private void ParameterPressed(string par)
        {
            // If start = increment par lvl
            // If end = decrement par lvl
        }
        // Generic functions
        private int GetOpPrio(string op)
        {
            /*
             *  1: Multi & Div
             *  0: Add & Subtract
             */
            switch (op)
            {
                case "add":
                    return 0;
                case "sub":
                    return 0;
                case "multi":
                    return 1;
                case "div":
                    return 1;
                default:
                    return -1;
            }
        }
        private void AddCalcNum(string op)
        {
            listNum.Add(new CalcNum(cNum, op, cParLvL));
            cNum = 0;
        }
        // Calculate
        private int Calculate(int n1, int n2, string op)
        {
            switch (op)
            {
                case "add":
                    return n1 + n2;
                case "sub":
                    return n1 - n2;
                case "multi":
                    return n1 * n2;
                case "div":
                    if (n2 == 0)
                    {
                        Error("Cannot divide by zero");
                        return 0;
                    }
                    else
                    {
                        return n1 / n2;
                    }
                default:
                    return -1;
            }
        }
        private void CalculateAllViable(string op)
        {
            // Betterments to CalculateWithPrevCalcNum
            // Work in progress
        }
        private void CalculateWithPrevCalcNum(string op)
        {
            int index = listNum.Count - 1;
            int lNum = listNum[index].num;

            int nNum = Calculate(lNum, cNum, listNum[index].op);

            if (!errorFound)
            {
                lbCalcDisplay.Items.Add(nNum.ToString());
                listNum[index].num = nNum;
                listNum[index].op = op;
                cNum = 0;
            }
            else
            {
                errorFound = false;
            }
        }
        private void CalculateAll()
        {
            int num = cNum;
            for (int i = listNum.Count - 1; i >= 0; i--)
            {
                num = Calculate(listNum[i].num, num, listNum[i].op);
                if (errorFound)
                {
                    errorFound = false;
                    break;
                }
            }
            lbCalcDisplay.Items.Add(num.ToString());
        }
        // Reset values
        private void ResetAll()
        {
            listNum.Clear();
            listNum.Add(new CalcNum(0, "add", 0));
            cNum = 0;
            cParLvL = 0;
        }
        // Clear screen
        private void ClearAll()
        {
            ResetAll();

            lbCalcDisplay.Items.Clear();
        }
        // Error messages
        private void Error(string msgError)
        {
            ResetAll();
            msgError = string.Format("ERROR: {0}. \n", msgError);
            lbCalcDisplay.Items.Add(msgError);
            lbCalcDisplay.Items.Add("Program has been reset.");
            errorFound = true;
        }

        // Number buttons
        private void btnZero_Click(object sender, EventArgs e)
        {
            NumberPressed(0);
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            NumberPressed(1);
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            NumberPressed(2);
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            NumberPressed(3);
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            NumberPressed(4);
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            NumberPressed(5);
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            NumberPressed(6);
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            NumberPressed(7);
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            NumberPressed(8);
        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            NumberPressed(9);
        }

        // Operator Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperatorPressed("add");
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            OperatorPressed("sub");
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            OperatorPressed("multi");
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            OperatorPressed("div");
        }

        // Calculate Button
        private void btnCalc_Click(object sender, EventArgs e)
        {
            CalculateAll();
            ResetAll();
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

    }
}