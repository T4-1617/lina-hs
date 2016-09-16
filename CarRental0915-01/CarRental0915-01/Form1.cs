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

        public CarRental()
        {
            InitializeComponent();

            // Hide Panels
            HidePanels();

            // Create car list w/ demo cars
            carList = new System.Collections.ArrayList();
            carList.Add(new Car() { make = "Volkswagen", model = "Passat", color = "Red" });
            carList.Add(new Car() { make = "Renault", model = "Clio", color = "Blue" });
            carList.Add(new Car() { make = "Volvo", model = "V70", color = "Silver" });
        }

        // Utility functions
        void HidePanels()
        {
            // Hide all panels
            pnlRentCar.Visible = false;
            pnlAddCar.Visible = false;
            pnlReturnCar.Visible = false;
        }

        // Show panels
        private void btnRentCar_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlRentCar.Visible = true;
        }
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlAddCar.Visible = true;
        }
        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlReturnCar.Visible = true;
        }
    }
}
