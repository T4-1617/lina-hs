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
        public CarRental()
        {
            InitializeComponent();

            // Hide Panels
            HidePanels();
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
