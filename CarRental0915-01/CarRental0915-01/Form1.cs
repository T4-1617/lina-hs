using System;
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

            // Hide all panels
            pnlRentCar.Visible = false;
            pnlAddCar.Visible = false;
            pnlReturnCar.Visible = false;
            pnlRentThank.Visible = false;
            pnlReturnThank.Visible = false;

            // Create demo cars and add to car list
            numCarsAvailable = 0;

            carList = new System.Collections.ArrayList();
            carList.Add(new Car() { make = "Volkswagen", model = "Passat", color = "Red" });
            carList.Add(new Car() { make = "Renault", model = "Clio", color = "Blue" });
            carList.Add(new Car() { make = "Volvo", model = "V70", color = "Silver" });


            // Add cars to appropriate listbox
            foreach (Car car in carList)
            {
                switch (car.rented)
                {
                    case false:
                        // Car is for rent
                        lstAvailableCars.Items.Add(car);
                        numCarsAvailable++;
                        break;
                    case true:
                        // Car is rented
                        lstReturnCars.Items.Add(car);
                        break;
                    default:
                        break;
                }
            }

            // Show available cars
            UpdatelblCarNum();

        }

        // DRY functions
        /// <summary>
        /// Updates the label lblCarNum to represent the current number of cars available
        /// </summary>
        void UpdatelblCarNum()
        {
            lblCarNum.Text = string.Format("We have {0} cars available.", numCarsAvailable);
        }
        /// <summary>
        /// Shows the panel and hides the previous panel
        /// </summary>
        /// <param name="panel">The panel to be shown</param>
        void PanelShow(Panel panel)
        {
            // Hide previous panel
            if (showPanel != null)
            {
                showPanel.Visible = false;
            }

            // Show pressed panel
            panel.Visible = true;
            showPanel = panel;
        }
        /// <summary>
        /// Rent or return the car
        /// </summary>
        /// <param name="rented">Bool representing whether the car will be rentable or not.</param>
        void ChangeCarStatus(bool rented)
        {
            Car changedCar;

            switch (rented)
            {
                case true:
                    // If car is being rented
                    changedCar = (Car)lstAvailableCars.SelectedItem;
                    lstAvailableCars.Items.RemoveAt(lstAvailableCars.SelectedIndex);
                    numCarsAvailable--;
                    lstReturnCars.Items.Add(changedCar);
                    break;
                case false:
                    // If car is being returned
                    changedCar = (Car)lstReturnCars.SelectedItem;
                    lstReturnCars.Items.RemoveAt(lstReturnCars.SelectedIndex);
                    lstAvailableCars.Items.Add(changedCar);
                    numCarsAvailable++;
                    break;
                default:
                    return;
            }

            UpdatelblCarNum();
            changedCar.rented = rented;
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
                // Rent a car
                ChangeCarStatus(true);

                // Show thank you panel
                PanelShow(pnlRentThank);
                
                // Skip error message
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
                // Return a car
                ChangeCarStatus(false);

                // Show thank you panel
                PanelShow(pnlReturnThank);

                // Skip error message
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
