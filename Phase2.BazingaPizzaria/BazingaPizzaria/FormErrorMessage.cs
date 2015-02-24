﻿using System;
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
    public partial class FormErrorMessage : Form
    {
        public FormErrorMessage()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get { return lbl_TG_ErrorMessage.Text; }
            set { lbl_TG_ErrorMessage.Text = value; }
        }

        private void btn_TG_Okay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
