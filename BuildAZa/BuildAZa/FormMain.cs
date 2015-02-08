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
    public partial class FormMain : Form
    {
        //
        // Create a private instance of the Order that can be accesses by the forms controls.
        //
        private Order formCustomerOrder = new Order();

        public FormMain()
        {
            InitializeComponent();

        }

        //
        // Constructor that will take the order as an argument
        //
        public FormMain(Order customerOrder)
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
        }
    }
}
