﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental0915_01
{
    public partial class CarRental : Form
    {

        System.Collections.ArrayList carList;
        int numCarsAvailable;
        Panel showPanel;

        public CarRental()
        {
            InitializeComponent();

            // Hide Panels
            HidePanels();

            // Create demo cars and add to car list
            numCarsAvailable = 0;

            carList = new System.Collections.ArrayList();
            carList.Add(new Car() { make = "Volkswagen", model = "Passat", color = "Red" });
            carList.Add(new Car() { make = "Renault", model = "Clio", color = "Blue" });
            carList.Add(new Car() { make = "Volvo", model = "V70", color = "Silver" });


            // Add cars to appropriate listbox
            foreach (Car car in carList)
            {
                switch (car.forRent)
                {
                    case true:
                        lstAvailableCars.Items.Add(car);
                        numCarsAvailable++;
                        break;
                    case false:
                        lstReturnCars.Items.Add(car);
                        break;
                    default:
                        break;
                }
            }

            // Show available cars
            UpdatelblCarNum();

        }

        // Utility functions
        void HidePanels()
        {
            // Hide all panels
            pnlRentCar.Visible = false;
            pnlAddCar.Visible = false;
            pnlReturnCar.Visible = false;
            pnlRentThank.Visible = false;
            pnlReturnThank.Visible = false;
        }
        void HideShowPanel()
        {
            if (showPanel != null)
            {
                showPanel.Visible = false;
            }
        }
        void UpdatelblCarNum()
        {
            lblCarNum.Text = string.Format("We have {0} cars available.", numCarsAvailable);
        }
        void PanelShow(Panel panel)
        {
            // Hide previous panel
            HideShowPanel();

            // Show pressed panel
            panel.Visible = true;
            showPanel = panel;
        }

        // Show panels
        private void btnRentCar_Click(object sender, EventArgs e)
        {
            PanelShow(pnlRentCar);
        }
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            PanelShow(pnlAddCar);
        }
        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            PanelShow(pnlReturnCar);
        }

        // Rent car
        private void btnRent_Click(object sender, EventArgs e)
        {
            int index = lstAvailableCars.SelectedIndex;

            // If a car has been selected
            if (index != -1)
            {
                // Get rented car
                Car rentCar = (Car)lstAvailableCars.SelectedItem;

                // Set car to rented
                rentCar.forRent = true;

                // Remove car from available list
                lstAvailableCars.Items.RemoveAt(index);

                // Alter number available cars
                numCarsAvailable--;
                UpdatelblCarNum();

                // Add car to rented list
                lstReturnCars.Items.Add(rentCar);

                // Hide panel and show thank you panel
                pnlRentCar.Visible = false;
                pnlRentThank.Visible = true;
                showPanel = pnlRentThank;
                
                // Return to 'main menu'
                return;
            }

            // In case no car has been selected
            MessageBox.Show("You must select a car to rent.");
        }

        // Return car
        private void btnReturn_Click(object sender, EventArgs e)
        {
            int index = lstReturnCars.SelectedIndex;

            // If a car has been selected
            if (index != -1)
            {
                // Get rented car
                Car returnCar = (Car)lstReturnCars.SelectedItem;

                // Set car to available
                returnCar.forRent = false;

                // Remove car from rented list
                lstReturnCars.Items.RemoveAt(index);

                // Add car to available list
                lstAvailableCars.Items.Add(returnCar);

                // Alter number available cars
                numCarsAvailable++;
                UpdatelblCarNum();

                // Hide panel and show thank you panel
                pnlReturnCar.Visible = false;
                pnlReturnThank.Visible = true;
                showPanel = pnlReturnThank;
                
                // Return to 'main menu'
                return;
            }

            // In case no car has been selected
            MessageBox.Show("You must select a car to return.");
        }

        // Add car
        private void btnAdd_Click(object sender, EventArgs e)
        {

            bool allTextboxesHaveValues = (tbxAddMake.Text != string.Empty && tbxAddModel.Text != string.Empty && tbxAddColor.Text != string.Empty);

            if (allTextboxesHaveValues)
            {
                // Create new car
                Car newCar = new Car();
                newCar.make = tbxAddMake.Text;
                newCar.model = tbxAddModel.Text;
                newCar.color = tbxAddColor.Text;

                // Add new car to list
                carList.Add(newCar);

                // Adjust available cars
                lstAvailableCars.Items.Add(newCar);
                numCarsAvailable++;
                UpdatelblCarNum();

                // Clear the textboxes
                tbxAddMake.Text = string.Empty;
                tbxAddModel.Text = string.Empty;
                tbxAddColor.Text = string.Empty;

                // Return to 'main menu'
                return;
            }

            MessageBox.Show("You must enter values in all textboxes!");

        }
    }
}
