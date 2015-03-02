﻿/**********************************
Authors: Team Blue - Roxy Scrivener
                     Sue Lovell
                     John Velis
                     Taman Gerring
Group Project: Phase 1
Purpose:  Customer ordering kiosk interface for fast food pizzeria
Date: 2/18/2015
************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazingaPizzaria.Model;

namespace BazingaPizzaria
{
    public partial class FormMain : Form
    {
        //Roxy's 2nd GitHub test

        //
        // generate an instance of a customer class and populate with data to test forms
        //
        Customer currentCustomer = GenerateTestData.GenerateTestCustomerData();
        FormErrorMessage frmErrorMess = new FormErrorMessage();

        //
        // Team Blue's custom colors
        //
        #region customColors

        public Color colRed = Color.FromArgb(192, 0, 0);
        public Color colLightBlue = Color.FromArgb(222, 234, 246);
        public Color colMedLightBlue = Color.FromArgb(188, 215, 238);
        public Color colMedDarkBlue = Color.FromArgb(157, 195, 232);
        public Color colDarkBlue = Color.FromArgb(89, 153, 214);
        public Color colFormValidationError = Color.Pink;
        public Color colFormValidationErrorLabel = Color.Red;
        public Color colFormBackColor = Color.White;
        public Color colFormNormalText = Color.Black;

        #endregion

        public FormMain()
        {
            InitializeComponent();

            //
            // comment/uncomment the line below to show/hide the tabs on the main form
            //
            this.tabControlOrderSequence.ItemSize = new Size(0, 1);

            this.tabControlOrderSequence.SizeMode = TabSizeMode.Fixed;
            this.tabControlOrderSequence.Appearance = TabAppearance.FlatButtons;

            // this hides the tabs for the Start menu
            this.tabControl2.ItemSize = new Size(0, 1);
            this.tabControl2.SizeMode = TabSizeMode.Fixed;
            this.tabControl2.Appearance = TabAppearance.FlatButtons;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_TG_NameDineIn;
        }

        //Navigation button visual response and cancel order button
        #region navigationButtons
        //
        // The following four click event handlers are for the navigation visual response
        // and the navigation to tabs
        //

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.ForeColor = colRed;
            btnSize.ForeColor = Color.Black;
            btnSpecialty.ForeColor = Color.Black;
            btnCheckOut.ForeColor = Color.Black;
            tabControlOrderSequence.SelectedTab = tabPageStart;
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.Black;
            btnSize.ForeColor = colRed;
            btnSpecialty.ForeColor = Color.Black;
            btnCheckOut.ForeColor = Color.Black;
            tabControlOrderSequence.SelectedTab = tabPageSizeCrust;
        }

        private void btnSpecialty_Click(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.Black;
            btnSize.ForeColor = Color.Black;
            btnSpecialty.ForeColor = colRed;
            btnCheckOut.ForeColor = Color.Black;
            tabControlOrderSequence.SelectedTab = tabPageSpecialtyPizzas;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.Black;
            btnSize.ForeColor = Color.Black;
            btnSpecialty.ForeColor = Color.Black;
            btnCheckOut.ForeColor = colRed;
            tabControlOrderSequence.SelectedTab = tabPageCheckOut;
            //
            // method to demo Current Pizza Order info
            //
            tabPageCheckOutPopulateData();
        }

        //
        // The following two event handlers (buttonMouseEnter and buttonMouseLeave) are to provide
        // visual response to button mouseover
        //

        private void buttonMouseEnter(object sender, EventArgs e)
        {
            if (sender == btnStart)
            {
                if (btnStart.ForeColor == Color.Black)
                {
                    btnStart.ForeColor = Color.White;
                }
                else
                {
                    btnStart.ForeColor = Color.Snow;
                }
            }
            else if (sender == btnSize)
            {
                if (btnSize.ForeColor == Color.Black)
                {
                    btnSize.ForeColor = Color.White;
                }
                else
                {
                    btnSize.ForeColor = Color.Snow;
                }
            }
            else if (sender == btnSpecialty)
            {
                if (btnSpecialty.ForeColor == Color.Black)
                {
                    btnSpecialty.ForeColor = Color.White;
                }
                else
                {
                    btnSpecialty.ForeColor = Color.Snow;
                }
            }
            else if (sender == btnCheckOut)
            {
                if (btnCheckOut.ForeColor == Color.Black)
                {
                    btnCheckOut.ForeColor = Color.White;
                }
                else
                {
                    btnCheckOut.ForeColor = Color.Snow;
                }
            }
        }

        private void buttonMouseLeave(object sender, EventArgs e)
        {
            if (sender == btnStart)
            {
                if (btnStart.ForeColor == Color.Snow || btnStart.ForeColor == colRed)
                {
                    btnStart.ForeColor = colRed;
                }
                else
                {
                    btnStart.ForeColor = Color.Black;
                }
            }
            else if (sender == btnSize)
            {
                if (btnSize.ForeColor == Color.Snow || btnSize.ForeColor == colRed)
                {
                    btnSize.ForeColor = colRed;
                }
                else
                {
                    btnSize.ForeColor = Color.Black;
                }
            }
            else if (sender == btnSpecialty)
            {
                if (btnSpecialty.ForeColor == Color.Snow || btnSpecialty.ForeColor == colRed)
                {
                    btnSpecialty.ForeColor = colRed;
                }
                else
                {
                    btnSpecialty.ForeColor = Color.Black;
                }
            }
            else if (sender == btnCheckOut)
            {
                if (btnCheckOut.ForeColor == Color.Snow || btnCheckOut.ForeColor == colRed)
                {
                    btnCheckOut.ForeColor = colRed;
                }
                else
                {
                    btnCheckOut.ForeColor = Color.Black;
                }
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            FormConfirmCancel frmConfirmCancel = new FormConfirmCancel();
            frmConfirmCancel.ShowDialog();
        }
        #endregion

        //Add standard buttons here for visual response
        #region standardButtons
        //
        // The folowing two event handlers (StandardButtonEnter and StandardButtonLeave) are to 
        // provide visual response for mouseover of the standard buttons
        //
        // The string that is used for the text for individual cases is equal to the Text property
        // of the button it is effecting

        private void StandardButtonEnter(object sender, EventArgs e)
        {
            string senderString = sender.ToString().Replace("System.Windows.Forms.Button, Text: ", "");

            switch (senderString)
            {
                case "Cancel Order":
                    btnCancelOrder.ForeColor = colMedLightBlue;
                    break;
                case "&Za of the Month":
                    btn_RS_zaOfMonth.ForeColor = colMedLightBlue;
                    break;
                case "&Ultimate Cheese":
                    btn_RS_cheese.ForeColor = colMedLightBlue;
                    break;
                case "&Piled High Pepperoni":
                    btn_RS_pepperoni.ForeColor = colMedLightBlue;
                    break;
                case "&Mounds of Meat":
                    btn_RS_meat.ForeColor = colMedLightBlue;
                    break;
                case "&Veggie Patch":
                    btn_RS_veggie.ForeColor = colMedLightBlue;
                    break;
                case "&Super Supreme":
                    btn_RS_supreme.ForeColor = colMedLightBlue;
                    break;
                case "&Backyard BBQ":
                    btn_RS_bbq.ForeColor = colMedLightBlue;
                    break;
                case "&Add this pizza to my order!":
                    btn_RS_addToOrder.ForeColor = colMedLightBlue;
                    break;
                case "A&dd Another Za!":
                    btn_RS_anotherZa.ForeColor = colMedLightBlue;
                    break;
                case "&Check Out":
                    btn_RS_checkOut.ForeColor = colMedLightBlue;
                    break;
                case "Small 8 in $3.99":
                    btn_SL_sizeSmall.ForeColor = colMedLightBlue;
                    break;
                case "Med 12 in $7.99":
                    btn_SL_sizeMed.ForeColor = colMedLightBlue;
                    break;
                case "Lg 14 in $10.97":
                    btn_SL_sizeLarge.ForeColor = colMedLightBlue;
                    break;
                case "XLG 16 in $10.97":
                    btn_SL_sizeXLG.ForeColor = colMedLightBlue;
                    break;
                case "Hand-Tossed":
                    btn_SL_crustHandTossed.ForeColor = colMedLightBlue;
                    break;
                case "Crispy-Thin":
                    btn_SL_crustChrispyThin.ForeColor = colMedLightBlue;
                    break;
                case "Thick":
                    btn_SL_crustThick.ForeColor = colMedLightBlue;
                    break;
                case "Gluten-Free":
                    btn_SL_crustGlutenFree.ForeColor = colMedLightBlue;
                    break;
                case "Complete My Order":
                    btn_JV_CompleteMyOrder.ForeColor = colMedLightBlue;
                    break;
                case "Choose Your Za":
                    btn_SL_ChooseZa.ForeColor = colMedLightBlue;
                    break;
                case "Dine In":
                    btn_TG_DineIn.ForeColor = colMedLightBlue;
                    break;
                case "Carry Out":
                    btn_TG_CarryOut.ForeColor = colMedLightBlue;
                    break;
                case "Returning Customer?":
                    btn_TG_ReturnCust.ForeColor = colMedLightBlue;
                    break;
                case "&Next":
                    btn_TG_NextCarryOut.ForeColor = colMedLightBlue;
                    btn_TG_NextDineIn.ForeColor = colMedLightBlue;
                    btn_TG_NextReturnCust.ForeColor = colMedLightBlue;
                    break;

            }

        }

        private void StandardButtonLeave(object sender, EventArgs e)
        {
            string senderString = sender.ToString().Replace("System.Windows.Forms.Button, Text: ", "");

            switch (senderString)
            {
                case "Cancel Order":
                    btnCancelOrder.ForeColor = colFormBackColor;
                    break;
                case "&Za of the Month":
                    btn_RS_zaOfMonth.ForeColor = colFormBackColor;
                    break;
                case "&Ultimate Cheese":
                    btn_RS_cheese.ForeColor = colFormBackColor;
                    break;
                case "&Piled High Pepperoni":
                    btn_RS_pepperoni.ForeColor = colFormBackColor;
                    break;
                case "&Mounds of Meat":
                    btn_RS_meat.ForeColor = colFormBackColor;
                    break;
                case "&Veggie Patch":
                    btn_RS_veggie.ForeColor = colFormBackColor;
                    break;
                case "&Super Supreme":
                    btn_RS_supreme.ForeColor = colFormBackColor;
                    break;
                case "&Backyard BBQ":
                    btn_RS_bbq.ForeColor = colFormBackColor;
                    break;
                case "&Add this pizza to my order!":
                    btn_RS_addToOrder.ForeColor = colFormBackColor;
                    break;
                case "A&dd Another Za!":
                    btn_RS_anotherZa.ForeColor = colFormBackColor;
                    break;
                case "&Check Out":
                    btn_RS_checkOut.ForeColor = colFormBackColor;
                    break;
                case "Small 8 in $3.99":
                    btn_SL_sizeSmall.ForeColor = colFormBackColor;
                    break;
                case "Med 12 in $7.99":
                    btn_SL_sizeMed.ForeColor = colFormBackColor;
                    break;
                case "Lg 14 in $10.97":
                    btn_SL_sizeLarge.ForeColor = colFormBackColor;
                    break;
                case "XLG 16 in $10.97":
                    btn_SL_sizeXLG.ForeColor = colFormBackColor;
                    break;
                case "Hand-Tossed":
                    btn_SL_crustHandTossed.ForeColor = colFormBackColor;
                    break;
                case "Crispy-Thin":
                    btn_SL_crustChrispyThin.ForeColor = colFormBackColor;
                    break;
                case "Thick":
                    btn_SL_crustThick.ForeColor = colFormBackColor;
                    break;
                case "Gluten-Free":
                    btn_SL_crustGlutenFree.ForeColor = colFormBackColor;
                    break;
                case "Complete My Order":
                    btn_JV_CompleteMyOrder.ForeColor = colFormBackColor;
                    break;
                case "Choose Your Za":
                    btn_SL_ChooseZa.ForeColor = colFormBackColor;
                    break;
                case "Dine In":
                    btn_TG_DineIn.ForeColor = colFormBackColor;
                    break;
                case "Carry Out":
                    btn_TG_CarryOut.ForeColor = colFormBackColor;
                    break;
                case "Returning Customer?":
                    btn_TG_ReturnCust.ForeColor = colFormBackColor;
                    break;
                case "&Next":
                    btn_TG_NextCarryOut.ForeColor = colFormBackColor;
                    btn_TG_NextDineIn.ForeColor = colFormBackColor;
                    btn_TG_NextReturnCust.ForeColor = colFormBackColor;
                    break;
            }
        }
        #endregion

        //
        // tabStart - Täman
        //
        #region tabStart Code (Täman)

        #region Dine In, Carry Out, Return

        private void btn_TG_DineIn_Click(object sender, EventArgs e)
        {
            ClearFields();
            tabControl2.SelectTab(tab_TG_DineIn);
            txt_TG_NameDineIn.BackColor = colFormBackColor;
            txt_TG_NameDineIn.Focus();
            TG_standardButtonSelector(btn_TG_DineIn);
        }

        private void btn_TG_CarryOut_Click(object sender, EventArgs e)
        {
            ClearFields();
            tabControl2.SelectTab(tab_TG_CarryOut);
            txt_TG_NameCarryOut.BackColor = colFormBackColor;
            txt_TG_PhoneNum.BackColor = colFormBackColor;
            txt_TG_NameCarryOut.Focus();
            TG_standardButtonSelector(btn_TG_CarryOut);
        }

        private void btn_TG_ReturnCust_Click(object sender, EventArgs e)
        {
            ClearFields();

            tabControl2.SelectTab(tab_TG_ReturnCust);
            txt_TG_Email.BackColor = colFormBackColor;
            txt_TG_Password.BackColor = colFormBackColor;
            txt_TG_Email.Focus();
            TG_standardButtonSelector(btn_TG_ReturnCust);
        }

        #endregion

        #region Next Buttons

        private void btn_TG_NextDineIn_Click(object sender, EventArgs e)
        {
            if (txt_TG_NameDineIn.Text == String.Empty)
            {
                frmErrorMess.LabelText = "Please enter your Name!";
                frmErrorMess.ShowDialog();

                txt_TG_NameDineIn.BackColor = colFormValidationError;
                txt_TG_NameDineIn.Focus();
            }
            else
            {
                btnStart.ForeColor = Color.Black;
                btnSize.ForeColor = colRed;
                btnSpecialty.ForeColor = Color.Black;
                btnCheckOut.ForeColor = Color.Black;

                tabControlOrderSequence.SelectTab(tabPageSizeCrust);
            }
        }

        private void btn_TG_NextCarryOut_Click(object sender, EventArgs e)
        {
            // Regex phoneNum = new Regex(@"^(\d{3})[ -]?(\d{3})[ -]?(\d{4}) x(\d*)");

            if (txt_TG_NameCarryOut.Text == String.Empty)
            {
                frmErrorMess.LabelText = "Please enter your Name!";
                frmErrorMess.ShowDialog();

                txt_TG_NameCarryOut.BackColor = colFormValidationError;
                txt_TG_NameCarryOut.Focus();
            }
            else if (txt_TG_PhoneNum.Text == String.Empty)
            {
                frmErrorMess.LabelText = "Please enter your phone number!";
                frmErrorMess.ShowDialog();

                txt_TG_PhoneNum.BackColor = colFormValidationError;
                txt_TG_PhoneNum.Focus();
            }
            else
            {
                btnStart.ForeColor = Color.Black;
                btnSize.ForeColor = colRed;
                btnSpecialty.ForeColor = Color.Black;
                btnCheckOut.ForeColor = Color.Black;

                tabControlOrderSequence.SelectTab(tabPageSizeCrust);
            }

        }

        private void btn_TG_NextReturnCust_Click(object sender, EventArgs e)
        {
            Regex emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

            if (!emailRegex.IsMatch(txt_TG_Email.Text) || (txt_TG_Email.Text == String.Empty))
            {
                frmErrorMess.LabelText = "Please enter a valid Email address!";
                frmErrorMess.ShowDialog();

                txt_TG_Email.BackColor = colFormValidationError;
                txt_TG_Email.Focus();
            }
            else if (txt_TG_Password.Text == String.Empty)
            {
                frmErrorMess.LabelText = "Please enter your password!";
                frmErrorMess.ShowDialog();

                txt_TG_Password.BackColor = colFormValidationError;
                txt_TG_Password.Focus();
            }
            else
            {
                btnStart.ForeColor = Color.Black;
                btnSize.ForeColor = colRed;
                btnSpecialty.ForeColor = Color.Black;
                btnCheckOut.ForeColor = Color.Black;

                tabControlOrderSequence.SelectTab(tabPageSizeCrust);
            }
        }

        #endregion

        #region TG standardButtons
        private void TG_standardButtonSelector(Button button)
        {
            //reset all buttons in group to standard color
            btn_TG_DineIn.BackColor = colRed;
            btn_TG_CarryOut.BackColor = colRed;
            btn_TG_ReturnCust.BackColor = colRed;

            //set the selected button back color to show it is selected
            button.BackColor = colDarkBlue;
        }

        #endregion

        #region Methods
        //
        // This method clears all fields on StartTab
        //
        public void ClearFields()
        {
            txt_TG_NameDineIn.Clear();
            txt_TG_NameCarryOut.Clear();
            txt_TG_PhoneNum.Clear();
            txt_TG_Email.Clear();
            txt_TG_Password.Clear();
        }

        #endregion

        #endregion

        //
        // tabPageSize/Crust - Sue
        //
        #region tabPageSize/Crust Code (Sue)
        //The following eight event handlers are for the Size/Crust tab of the form

        private void btn_SL_sizeSmall_Click(object sender, EventArgs e)
        {
            SL2_standardButtonSelector(btn_SL_sizeSmall);
        }

        private void btn_SL_sizeMed_Click(object sender, EventArgs e)
        {
            SL2_standardButtonSelector(btn_SL_sizeMed);
        }

        private void btn_SL_sizeLarge_Click(object sender, EventArgs e)
        {
            SL2_standardButtonSelector(btn_SL_sizeLarge);
        }

        private void btn_SL_sizeXLG_Click(object sender, EventArgs e)
        {
            SL2_standardButtonSelector(btn_SL_sizeXLG);
        }

        private void btn_SL_crustHandTossed_Click(object sender, EventArgs e)
        {
            SL_standardButtonSelector(btn_SL_crustHandTossed);
        }

        private void btn_SL_crustCrispyThin_Click(object sender, EventArgs e)
        {
            SL_standardButtonSelector(btn_SL_crustChrispyThin);
        }

        private void btn_SL_crustThick_Click(object sender, EventArgs e)
        {
            SL_standardButtonSelector(btn_SL_crustThick);
        }

        private void btn_SL_crustGlutenFree_Click(object sender, EventArgs e)
        {
            SL_standardButtonSelector(btn_SL_crustGlutenFree);
        }

        private void SL_standardButtonSelector(Button button)
        {
            //reset all buttons in group to standard color

            btn_SL_crustChrispyThin.BackColor = colRed;
            btn_SL_crustGlutenFree.BackColor = colRed;
            btn_SL_crustHandTossed.BackColor = colRed;
            btn_SL_crustThick.BackColor = colRed;

            //set the selected button back color to show it is selected
            button.BackColor = colDarkBlue;
        }

        private void SL2_standardButtonSelector(Button button)
        {
            //reset all buttons in group to standard color

            btn_SL_sizeXLG.BackColor = colRed;
            btn_SL_sizeLarge.BackColor = colRed;
            btn_SL_sizeMed.BackColor = colRed;
            btn_SL_sizeSmall.BackColor = colRed;

            //set the selected button back color to show it is selected
            button.BackColor = colDarkBlue;
        }

        private void btn_SL_ChooseZa_Click(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.Black;
            btnSize.ForeColor = Color.Black;
            btnSpecialty.ForeColor = colRed;
            btnCheckOut.ForeColor = Color.Black;
            tabControlOrderSequence.SelectedTab = tabPageSpecialtyPizzas;
        }

        #endregion

        //
        // tabPageCheckOut - Velis
        //
        #region tabPageCheckOut Code (Velis)

        //
        // method to populate tabPageCheckOut form
        //
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

            textBox_JV_CCName.Text = "John Velis";
        }

        #region Checkout Form Validation
        //
        // validate the zip code for using proper regular expression
        //
        private void textBox_JV_CCZipValidation_Leave(object sender, EventArgs e)
        {
            string validationZipCodeRegEx = @"\d{5}";

            Match match = Regex.Match(textBox_JV_CCZip.Text, validationZipCodeRegEx);
            if (!match.Success)
            {
                frmErrorMess.LabelText = "Please enter a 5 digit zip code.";
                frmErrorMess.ShowDialog();
                textBox_JV_CCZip.Focus();
            }
        }

        //
        // validate all required credit card fields
        //
        private void btn_JV_CompleteMyOrder_Click(object sender, EventArgs e)
        {
            clearValidationErrorColor();

            if (textBox_JV_CCName.Text == String.Empty)
            {
                frmErrorMess.LabelText = "Please enter the name on the credit card.";
                frmErrorMess.ShowDialog();
                textBox_JV_CCName.BackColor = colFormValidationError;
                textBox_JV_CCName.Focus();
            }
            else if (textBox_JV_CCAddress.Text == String.Empty)
            {
                frmErrorMess.LabelText = "Please enter the billing address for the credit card.";
                frmErrorMess.ShowDialog();
                textBox_JV_CCAddress.BackColor = colFormValidationError;
                textBox_JV_CCAddress.Focus();
            }
            else if (textBox_JV_CCCity.Text == String.Empty)
            {
                frmErrorMess.LabelText = "Please enter the billing city for the credit card.";
                frmErrorMess.ShowDialog();
                textBox_JV_CCCity.BackColor = colFormValidationError;
                textBox_JV_CCCity.Focus();
            }
            else if (textBox_JV_CCState.Text == String.Empty)
            {
                frmErrorMess.LabelText = "Please enter the billing state for the credit card.";
                frmErrorMess.ShowDialog();
                textBox_JV_CCState.BackColor = colFormValidationError;
                textBox_JV_CCState.Focus();
            }
            else if (textBox_JV_CCZip.Text == String.Empty)
            {
                frmErrorMess.LabelText = "Please enter the billing zip code for the credit card.";
                frmErrorMess.ShowDialog();
                textBox_JV_CCZip.BackColor = colFormValidationError;
                textBox_JV_CCZip.Focus();
            }
            else if (textBox_JV_CCNumber.Text == String.Empty)
            {
                MessageBox.Show("Please enter the credit card number.");
                textBox_JV_CCNumber.BackColor = colFormValidationError;
                textBox_JV_CCNumber.Focus();
            }
            else if (textBox_JV_CCCVVCode.Text == String.Empty)
            {
                frmErrorMess.LabelText = "Please enter the credit card number.";
                frmErrorMess.ShowDialog();
                textBox_JV_CCCVVCode.BackColor = colFormValidationError;
                textBox_JV_CCCVVCode.Focus();
            }
            else if (comboBox_JV_CCExpMonth.SelectedItem == null)
            {
                frmErrorMess.LabelText = "Please enter your credit card expiration Month.";
                frmErrorMess.ShowDialog();
                comboBox_JV_CCExpMonth.Focus();
                lbl_JV_CCExpMonth.ForeColor = colFormValidationErrorLabel;
            }
            else if (comboBox_JV_CCExpYear.SelectedItem == null)
            {
                frmErrorMess.LabelText = "Please enter the credit card expiration Year.";
                frmErrorMess.ShowDialog();
                comboBox_JV_CCExpYear.Focus();
                lbl_JV_CCExpYear.ForeColor = colFormValidationErrorLabel;
            }
            else
            {
                FormCompletedOrder frmCompletedOrder = new FormCompletedOrder(this);
                tabControlOrderSequence.SelectedTab = tabPageCompleteOrder;
            }
        }

        //
        // Reset all form background colors to white and labels to black after validation error
        //
        private void clearValidationErrorColor()
        {
            textBox_JV_CCName.BackColor = colFormBackColor;
            textBox_JV_CCAddress.BackColor = colFormBackColor;
            textBox_JV_CCCity.BackColor = colFormBackColor;
            textBox_JV_CCState.BackColor = colFormBackColor;
            textBox_JV_CCZip.BackColor = colFormBackColor;
            textBox_JV_CCNumber.BackColor = colFormBackColor;
            lbl_JV_CCExpMonth.ForeColor = colFormNormalText;
            lbl_JV_CCExpYear.ForeColor = colFormNormalText;
            textBox_JV_CCCVVCode.ForeColor = colFormNormalText;
        }
        #endregion

        #endregion

        //
        // tabPageCompleteOrder - Velis
        //
        #region tabPageCompleteOrder Code (Velis)
        private void tabPageCompleteOrder_Enter(object sender, EventArgs e)
        {
            lbl_JV_BillingNameConfirm.Text = currentCustomer.FirstName + " " + currentCustomer.LastName;
            lbl_JV_BillingAddressConfirm.Text = currentCustomer.Address;
            lbl_JV_BillingCityConfirm.Text = currentCustomer.City;
            lbl_JV_BillingStateProvinceConfirm.Text = currentCustomer.StateProvince;
            lbl_JV_BillingZipConfirm.Text = currentCustomer.Zip;
            lbl_JV_BillingEmailConfirm.Text = currentCustomer.Email;
            lbl_JV_CCNumberShort.Text = "**** " + currentCustomer.CCNumber.Substring(11, 4);
            lbl_JV_CCExpConfirm.Text =
                currentCustomer.CCExpMonth.ToString() +
                "/" +
                currentCustomer.CCExpYear.ToString();

        }
        #endregion

        //
        // tabPageSpecialtyZas - Roxy
        //
        #region tabPageSpecialtyZas Code (Roxy)

        //method to allow only one pizza to be selected and
        //show visual feedback for selected
        private void RS_standardButtonSelector(Button button)
        {
            //reset all buttons in group to standard color
            btn_RS_bbq.BackColor = colRed;
            btn_RS_cheese.BackColor = colRed;
            btn_RS_meat.BackColor = colRed;
            btn_RS_pepperoni.BackColor = colRed;
            btn_RS_supreme.BackColor = colRed;
            btn_RS_veggie.BackColor = colRed;
            btn_RS_zaOfMonth.BackColor = colRed;

            //set the selected button back color to show it is selected
            button.BackColor = colDarkBlue;
        }

        private void btn_RS_zaOfMonth_Click(object sender, EventArgs e)
        {
            RS_standardButtonSelector(btn_RS_zaOfMonth);
            pnl_RS_zaOfMonth.BringToFront();
        }

        private void btn_RS_cheese_Click(object sender, EventArgs e)
        {
            RS_standardButtonSelector(btn_RS_cheese);
            pnl_RS_cheese.BringToFront();
        }

        private void btn_RS_pepperoni_Click(object sender, EventArgs e)
        {
            RS_standardButtonSelector(btn_RS_pepperoni);
            pnl_RS_pepperoni.BringToFront();
        }

        private void btn_RS_meat_Click(object sender, EventArgs e)
        {
            RS_standardButtonSelector(btn_RS_meat);
            pnl_RS_meat.BringToFront();
        }

        private void btn_RS_veggie_Click(object sender, EventArgs e)
        {
            RS_standardButtonSelector(btn_RS_veggie);
            pnl_RS_veggie.BringToFront();
        }

        private void btn_RS_supreme_Click(object sender, EventArgs e)
        {
            RS_standardButtonSelector(btn_RS_supreme);
            pnl_RS_supreme.BringToFront();
        }

        private void btn_RS_bbq_Click(object sender, EventArgs e)
        {
            RS_standardButtonSelector(btn_RS_bbq);
            pnl_RS_bbq.BringToFront();
        }

        //
        //add to order button message simulation of adding to order
        //
        private void btn_RS_addToOrder_Click(object sender, EventArgs e)
        {
            //code to add the pizza to the order
            frmErrorMess.LabelText = "You have added a Za to your order!";
            frmErrorMess.ShowDialog();
        }

        #endregion



    }
}
