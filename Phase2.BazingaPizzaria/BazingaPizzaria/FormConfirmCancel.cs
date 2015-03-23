using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazingaPizzaria
{
    public partial class FormConfirmCancel : Form
    {
        public Color colMedLightBlue = Color.FromArgb(188, 215, 238);

        public FormConfirmCancel()
        {
            InitializeComponent();

        }

        private void StandardButtonEnter(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            currentButton.ForeColor = colMedLightBlue;
        }


        private void StandardButtonLeave(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            currentButton.ForeColor = Color.White;
        }

        private void btnYesPlease_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnNoWay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
