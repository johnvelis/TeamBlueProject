using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAndObjects
{
    public partial class Form1 : Form
    {
        //
        // Create a private instance of the Order that can be accesses by the forms controls.
        //
        private Order formCustomerOrder = new Order();

        public Form1()
        {
            InitializeComponent();

        }

        //
        // Constructor that will take the order as an argument
        //
        public Form1(Order customerOrder)
        {
            InitializeComponent();

            //
            // Set the local instance of the Order to the parameter in the constructor.
            //
            formCustomerOrder = customerOrder;

            lblTestFirstName.Text = formCustomerOrder.firstName;
            lblTestLastName.Text = formCustomerOrder.lastName;
            lblTestOrderDate.Text = formCustomerOrder.orderDate.ToShortDateString();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            formCustomerOrder.firstName = textBoxFirstName.Text;
            formCustomerOrder.lastName = textBoxLastName.Text;
            formCustomerOrder.orderDate = DateTime.Today;

            lblTestFirstName.Text = formCustomerOrder.firstName;
            lblTestLastName.Text = formCustomerOrder.lastName;
        }
        
        private void btnNextForm_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPageStart_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            lblSecondFirstName.Text = formCustomerOrder.firstName;
        }
    }
}
