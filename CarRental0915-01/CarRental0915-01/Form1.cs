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

        /*
         *      Known problem(s):
         *          - Inconsistent variable naming, especially for the controls
         *          - Variable carList stores cars but serves NO purpose. (as of yet)
         * 
         */

        /// <summary>
        /// A list of all cars in the database
        /// </summary>
        System.Collections.ArrayList carList;
        /// <summary>
        /// Number of cars available for rent.
        /// </summary>
        int numCarsAvailable;
        /// <summary>
        /// Stores the panel which is currently visible
        /// </summary>
        Panel pnlShow;

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

        //// DRY functions
        /// <summary>
        /// Updates the label lblCarNum to represent the current number of cars available
        /// </summary>
        void UpdatelblCarNum()
        {
            lblCarNum.Text = string.Format("We have {0} car(s) available.", numCarsAvailable);
        }
        /// <summary>
        /// Shows the panel and hides the previous panel
        /// </summary>
        /// <param name="panel">The panel to be shown</param>
        void PanelShow(Panel panel)
        {
            // Hide previous panel
            if (pnlShow != null)
            {
                pnlShow.Visible = false;
            }

            // Show new panel
            panel.Visible = true;
            pnlShow = panel;
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
                    // If car is being neither rented nor returned
                    return;
            }

            changedCar.rented = rented;
            UpdatelblCarNum();
        }

        //// Show panel
        // Show rent car panel
        private void btnRentCar_Click(object sender, EventArgs e)
        {
            PanelShow(pnlRentCar);
        }
        // Show add car panel
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            PanelShow(pnlAddCar);
        }
        // Show return car panel
        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            PanelShow(pnlReturnCar);
        }

        //// Program functionality
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

            // Error message: no car selected
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

            // Error message: no car selected
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

                // Skip error message
                return;
            }

            // Error message: textboxes missing values
            MessageBox.Show("You must enter values in all textboxes!");

        }
    }
}
