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
                Calculate(op);
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
        private void Calculate(string op)
        {

            int index = listNum.Count - 1;
            int nNum;
            int lNum = listNum[index].num;

            switch (listNum[index].op)
            {
                case "add":
                    nNum = lNum + cNum;
                    break;
                case "sub":
                    nNum = lNum - cNum;
                    break;
                case "multi":
                    nNum = lNum * cNum;
                    break;
                case "div":
                    nNum = lNum / cNum;
                    break;
                default:
                    nNum = 0;
                    break;
            }

            MessageBox.Show(nNum.ToString());
            listNum[index].num = nNum;
            listNum[index].op = op;
            cNum = 0;

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
            Calculate(String.Empty);
        }


    }
}