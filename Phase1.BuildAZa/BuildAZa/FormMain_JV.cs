using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildAZa
{
    public partial class FormMain_JV : Form
    {
        //
        // Create a private instance of the Order that can be accesses by the forms controls.
        //
        private Order formCustomerOrder = new Order();

        public FormMain_JV()
        {
            InitializeComponent();

        }

        //
        // Constructor that will take the order as an argument
        //
        public FormMain_JV(Order customerOrder)
        {
            InitializeComponent();
            this.tabControlOrderSequence.ItemSize = new Size(0, 1);
            this.tabControlOrderSequence.SizeMode = TabSizeMode.Fixed;
            this.tabControlOrderSequence.Appearance = TabAppearance.FlatButtons;

        }

        private void pictureBoxCancelOrder_Click(object sender, EventArgs e)
        {
            FormConfirmCancel frmConfirmCancel = new FormConfirmCancel();
            frmConfirmCancel.ShowDialog();
        }

        private void pictureBoxTabPageStart_Click(object sender, EventArgs e)
        {
            tabControlOrderSequence.SelectedTab = tabPageStart;
        }

        private void pictureBoxTabPageSizeCrust_Click(object sender, EventArgs e)
        {
            tabControlOrderSequence.SelectedTab = tabPageSizeCrust;
        }

        private void pictureBoxTabPageSpecialtyPizzas_Click(object sender, EventArgs e)
        {
            tabControlOrderSequence.SelectedTab = tabPageSpecialtyPizzas;
        }

        private void pictureBoxTabPageCheckOut_Click(object sender, EventArgs e)
        {
            tabControlOrderSequence.SelectedTab = tabPageCheckOut;
            tabPageCheckOutPopulateData();
        }

        private void tabPageCheckOutPopulateData()
        {
            listBox_JV_OrderItemQuantity.Items.Clear();
            listBox_JV_OrderItemName.Items.Clear();
            listBox_JV_OrderItemPrice.Items.Clear();
           
            //
            // Add demo text to Pizza Order listboxes
            //
            listBox_JV_OrderItemQuantity.Items.Add("1");
            listBox_JV_OrderItemQuantity.Items.Add("1");
            listBox_JV_OrderItemName.Items.Add("Meatlovers Special");
            listBox_JV_OrderItemName.Items.Add("Hawaiian Special");
            listBox_JV_OrderItemPrice.Items.Add("$15.95");
            listBox_JV_OrderItemPrice.Items.Add("$17.95");
            textBox_JV_OrderSubtotal.Text = "$33.90";
            textBox_JV_OrderTax.Text = "$  2.03";
            textBox_JV_OrderTotal.Text = "$35.93";

            textBox_JV_NameOnCard.Text = "John Velis";
        }

    }
}
