using System;
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
            // Create and add 5 DEMO cars to listbox
            lstCars.Items.Add(new Car() { make = "Volvo" });
            lstCars.Items.Add(new Car() { make = "Volkswagen" });
            lstCars.Items.Add(new Car() { make = "Toyota" });
            lstCars.Items.Add(new Car() { make = "Ford" });
            lstCars.Items.Add(new Car() { make = "Mercedes-Benz" });

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
