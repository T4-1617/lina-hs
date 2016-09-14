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
        bool isEditing;

        public Form1()
        {
            InitializeComponent();

            //// Listbox
            lstCars.DisplayMember = "make";
            // Create 5 DEMO cars and add to listbox
            for (int i = 0; i < 5; i++)
            {
                Car car = new Car() { make = string.Format("DemoMake{0}", i.ToString()) };
                lstCars.Items.Add(car);
            }

            //// Panel
            pnlCarInfo.Visible = false;
            // Panel textboxes
            EditCarInfo(false);
            txtMake.ReadOnly = true;
            txtRegNO.ReadOnly = true;
            txtHired.ReadOnly = true;
        }

        private void EditCarInfo(bool canEdit)
        {
            isEditing = canEdit;

            txtGroup.ReadOnly = !canEdit;

            btnEdit.Enabled = !canEdit;
            btnSave.Enabled = canEdit;
        }

        // Controller functions
        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car car = (Car)lstCars.SelectedItem;

            //// Panel
            pnlCarInfo.Visible = true;

            txtMake.Text = car.make;
            txtRegNO.Text = car.RegNO;
            txtHired.Text = car.hired ? "Hired" : "Not hired";
            txtGroup.Text = car.group;

            //// Disable editing
            EditCarInfo(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Enable editing
            EditCarInfo(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Give the car its new values
            Car car = (Car)lstCars.SelectedItem;

            car.make = txtMake.Text;
            car.group = txtGroup.Text;

            // Disable editing and panel
            pnlCarInfo.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Disable panel
            pnlCarInfo.Visible = false;
        }
    }
}
