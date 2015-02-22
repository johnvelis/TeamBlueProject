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
            string senderString = sender.ToString().Replace("System.Windows.Forms.Button, Text: ", "");

            switch (senderString)
            {
                case "&Yes, Please":
                    btnYesPlease.ForeColor = colMedLightBlue;
                    break;
                case "&No Way!!!":
                    btnNoWay.ForeColor = colMedLightBlue;
                    break;
            }

        }

        private void StandardButtonLeave(object sender, EventArgs e)
        {
            string senderString = sender.ToString().Replace("System.Windows.Forms.Button, Text: ", "");

            switch (senderString)
            {
                case "&Yes, Please":
                    btnYesPlease.ForeColor = Color.White;
                    break;
                case "&No Way!!!":
                    btnNoWay.ForeColor = Color.White;
                    break;
            }
        }

        private void btnYesPlease_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNoWay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
