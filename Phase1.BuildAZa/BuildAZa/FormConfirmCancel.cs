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
    public partial class FormConfirmCancel : Form
    {
        public FormConfirmCancel()
        {
            InitializeComponent();

        }

        private void pictureBoxNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
