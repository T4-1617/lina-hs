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

        // Bug: The property of the car the listbox points to DOES change
        // The listbox does not change and refresh() does not seem to work.
        // Temporary work around, the RegNO of the car appears instead.

        public Form1()
        {
            InitializeComponent();

            // Listbox
            lstCars.DisplayMember = "RegNO";
            // Create 5 DEMO cars and add to listbox
            for (int i = 0; i < 5; i++)
            {
                Car car = new Car() { RegNO = i.ToString() };
                lstCars.Items.Add(car);
            }

            // Panel
            pnlCarInfo.Visible = false;
            // Panel textboxes
            EditCarInfo(false);
            txtRegNO.ReadOnly = true;
            txtHired.ReadOnly = true;
        }

        private void EditCarInfo(bool canEdit)
        {
            isEditing = canEdit;

            txtMake.ReadOnly = !canEdit;
            txtGroup.ReadOnly = !canEdit;
        }

        // Controller functions
        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car car = (Car)lstCars.SelectedItem;

            pnlCarInfo.Visible = true;

            txtMake.Text = car.make;
            txtRegNO.Text = car.RegNO;
            txtHired.Text = car.hired ? "Hired" : "Not hired";
            txtGroup.Text = car.group;

            EditCarInfo(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditCarInfo(!isEditing);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Car car = (Car)lstCars.SelectedItem;

            car.make = txtMake.Text;
            car.group = txtGroup.Text;

            EditCarInfo(false);
            pnlCarInfo.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlCarInfo.Visible = false;
        }
    }
}
