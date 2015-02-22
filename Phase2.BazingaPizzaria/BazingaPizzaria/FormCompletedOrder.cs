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
    public partial class FormCompletedOrder : Form
    {
        public FormCompletedOrder()
        {
            InitializeComponent();
        }

        public Color colMedLightBlue = Color.FromArgb(188, 215, 238);
        private FormMain frmMainForm = null;
        private TabPage tabPageStart = null;
        public FormCompletedOrder(FormMain frmCallingMainForm)
        {
            frmMainForm = frmCallingMainForm as FormMain;
            tabPageStart = frmCallingMainForm.tabPageStart as TabPage;
            InitializeComponent();
        }

        private void btn_JV_ReturnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            this.frmMainForm.tabControlOrderSequence.SelectedTab = tabPageStart;
        }

        private void btn_JV_ReturnMainMenu_MouseEnter(object sender, EventArgs e)
        {
            btn_JV_ReturnMainMenu.ForeColor = colMedLightBlue;
        }

        private void btn_JV_ReturnMainMenu_MouseLeave(object sender, EventArgs e)
        {
            btn_JV_ReturnMainMenu.ForeColor = Color.White;
        }

    }
}
