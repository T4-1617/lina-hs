using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM0920
{
    public partial class CRMForm : Form
    {
        public CRMForm()
        {
            InitializeComponent();

            // Hide panels
            pnlList.Visible = false;
            pnlAdd.Visible = false;

            // Hide extra arg labels
            lblAddExtraArg1.Visible = false;
            lblAddExtraArg2.Visible = false;
            lblAddExtraArg3.Visible = false;
            lblEditExtraArg1.Visible = false;
            lblEditExtraArg2.Visible = false;
            lblEditExtraArg3.Visible = false;

            // Hide extra arg textboxes
            tbxAddExtraArg1.Visible = false;
            tbxAddExtraArg2.Visible = false;
            tbxAddExtraArg3.Visible = false;
            tbxEditExtraArg1.Visible = false;
            tbxEditExtraArg2.Visible = false;
            tbxEditExtraArg3.Visible = false;

            // Disable all visible textboxes
            tbxAddFName.Enabled = false;
            tbxAddLName.Enabled = false;
            tbxAddPhoneNum.Enabled = false;
            tbxEditFName.Enabled = false;
            tbxEditLName.Enabled = false;
            tbxEditPhoneNum.Enabled = false;

        }
    }
}
