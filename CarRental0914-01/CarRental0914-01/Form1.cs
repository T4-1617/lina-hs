﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental0914_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Listbox
            lstCars.DisplayMember = "make";
            // Create 5 DEMO cars and add to listbox
            for (int i = 0; i < 5; i++)
            {
                Car car = new Car();
                lstCars.Items.Add(car);
            }

        }
    }
}
