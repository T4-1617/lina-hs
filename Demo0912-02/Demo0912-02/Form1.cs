using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo0912_02
{
    public partial class Form1 : Form
    {
        // A list of customers
        List<Customer> customers = new List<Customer>();
        // Random Number Generator
        Random RNG = new Random(); 

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add a customer to the list of customers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(txtFirstName.Text, txtLastName.Text);
            customer.ID = GenerateUniqueID();

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;

            customers.Add(customer);
            lbCustomers.Items.Add(string.Format("{0}", customer.GetFullName()));
            lblCustomerNum.Text = string.Format("You have {0} customers.", customers.Count);
        }

        /// <summary>
        /// Generate a unique ID from 100 (inclusive) and to 200 (inclusive) which is not already taken in the list
        /// </summary>
        /// <returns>Returns an integer containing the unique ID</returns>
        private int GenerateUniqueID()
        {
            int ID;
            bool unique = true;

            do
            {

                ID = RNG.Next(100, 201);

                foreach (Customer item in customers)
                {
                    unique = (item.ID != ID);

                    if (!unique)
                    {
                        break;
                    }
                }

            } while (!unique);

            return ID;

        }
        /// <summary>
        /// Display the customer information when a customer is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = lbCustomers.SelectedIndex;
            Customer c = customers[index];
            string CustomerInfo = string.Format("C.ID: {0}\nF.Name: {1}\nL.Name: {2}\nActive: {3}", c.ID, c.FirstName, c.LastName, c.Active);
            MessageBox.Show(CustomerInfo);

        }
    }
}
