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

        // Bug: listbox does not update when the make changes
        // The property of the car the listbox points to DOES change

        public Form1()
        {
            InitializeComponent();

            // Listbox
            lstCars.DisplayMember = "make";
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
        }

        private void EditCarInfo(bool canEdit)
        {
            isEditing = canEdit;

            txtMake.ReadOnly = !canEdit;
            txtHired.ReadOnly = !canEdit;
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
            lstCars.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlCarInfo.Visible = false;
        }
    }
}
