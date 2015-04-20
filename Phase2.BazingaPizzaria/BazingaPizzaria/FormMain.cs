/**********************************
Authors: Team Blue - Roxy Scrivener
                     Sue Lovell
                     John Velis
                     Taman Gerring
Group Project: Phase 2
Purpose:  Customer ordering kiosk interface for fast food pizzeria
Date: 3/25/2015
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
using System.Data.SqlClient;
using BazingaPizzaria.Properties;

namespace BazingaPizzaria
{
    public partial class FormMain : Form
    {
        //Roxy's 2nd GitHub test

        //
        // generate an instance of a Order class and populate with data to test forms
        //
        public Order newOrder = GenerateTestData.GenerateTestOrderData();
        FormErrorMessage frmErrorMess = new FormErrorMessage();

        string drink;
        decimal price;
        Beverage.BevSize size;
        int rowIndex = -1;
        bool sizeChecked;
        bool bevChecked;

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

            // this hides the tabs for the Specialty/BuildAZa page
            this.tabControl_RS_Zas.ItemSize = new Size(0, 1);
            this.tabControl_RS_Zas.SizeMode = TabSizeMode.Fixed;
            this.tabControl_RS_Zas.Appearance = TabAppearance.FlatButtons;

            // this hides the tabs for the Beverage page
            this.tabControl_TG_Beverages.ItemSize = new Size(0, 1);
            this.tabControl_TG_Beverages.SizeMode = TabSizeMode.Fixed;
            this.tabControl_TG_Beverages.Appearance = TabAppearance.FlatButtons;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_TG_NameDineIn;
            lbl_RS_navStart.ForeColor = Color.DarkRed;
        }

        //
        //Navigation button visual response and cancel order button
        //
        #region navigationButtons

        private void tabControlOrderSequence_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentTab = tabControlOrderSequence.SelectedIndex;

            switch (currentTab)
            {
                case 0:
                    lbl_RS_navStart.ForeColor = Color.DarkRed;
                    lbl_RS_navSizeCrust.ForeColor = Color.Black;
                    lbl_RS_navChooseZa.ForeColor = Color.Black;
                    lbl_RS_navBeverages.ForeColor = Color.Black;
                    lbl_RS_navCheckOut.ForeColor = Color.Black;
                    break;
                case 1:
                    lbl_RS_navStart.ForeColor = Color.Black;
                    lbl_RS_navSizeCrust.ForeColor = Color.DarkRed;
                    lbl_RS_navChooseZa.ForeColor = Color.Black;
                    lbl_RS_navBeverages.ForeColor = Color.Black;
                    lbl_RS_navCheckOut.ForeColor = Color.Black;

                    //default buttons
                    btn_SL_sizeLarge.BackColor = colDarkBlue;
                    btn_SL_crustHandTossed.BackColor = colDarkBlue;
                    btn_SL_sizeSmall.BackColor = colRed;
                    btn_SL_sizeMed.BackColor = colRed;
                    btn_SL_sizeXLG.BackColor = colRed;
                    btn_SL_crustChrispyThin.BackColor = colRed;
                    btn_SL_crustThick.BackColor = colRed;
                    btn_SL_crustGlutenFree.BackColor = colRed;

                    //default variables
                    newPizzaPrice = 10.97m;
                    pizzaSize = "Large";
                    pizzaCrust = "Hand-Tossed";

                    break;
                case 2:
                    //Navigation animation change
                    lbl_RS_navStart.ForeColor = Color.Black;
                    lbl_RS_navSizeCrust.ForeColor = Color.Black;
                    lbl_RS_navChooseZa.ForeColor = Color.DarkRed;
                    lbl_RS_navBeverages.ForeColor = Color.Black;
                    lbl_RS_navCheckOut.ForeColor = Color.Black;

                    //Hides pannel and bottom navigation buttons and start on inner tab index 0
                    btn_RS_addBeverage.Visible = false;
                    btn_RS_anotherZa.Visible = false;
                    btn_RS_checkOut.Visible = false;
                    pnl_RS_whatNext.Visible = false;
                    tabControl_RS_Zas.SelectedIndex = 0;

                    //set button colors to default
                    btn_RS_addHam.BackColor = colRed;
                    btn_RS_addMushrooms.BackColor = colRed;
                    btn_RS_addOlives.BackColor = colRed;
                    btn_RS_addPepperoni.BackColor = colRed;
                    btn_RS_addPeppers.BackColor = colRed;
                    btn_RS_addSausage.BackColor = colRed;
                    btn_RS_cheese.BackColor = colRed;
                    btn_RS_justCheese.BackColor = colRed;
                    btn_RS_meat.BackColor = colRed;
                    btn_RS_pepperoni.BackColor = colRed;
                    btn_RS_supreme.BackColor = colRed;
                    btn_RS_toBuild.BackColor = colRed;
                    btn_RS_toSpecialties.BackColor = colRed;
                    btn_RS_veggie.BackColor = colRed;

                    //sets local variables to defaults
                    RS_specialtyType = null;
                    RS_isSpecialty = false;
                    RS_toppings.Clear();
                    break;
                case 3:
                    lbl_RS_navStart.ForeColor = Color.Black;
                    lbl_RS_navSizeCrust.ForeColor = Color.Black;
                    lbl_RS_navChooseZa.ForeColor = Color.Black;
                    lbl_RS_navBeverages.ForeColor = Color.DarkRed;
                    lbl_RS_navCheckOut.ForeColor = Color.Black;
                    break;
                case 4:
                    lbl_RS_navStart.ForeColor = Color.Black;
                    lbl_RS_navSizeCrust.ForeColor = Color.Black;
                    lbl_RS_navChooseZa.ForeColor = Color.Black;
                    lbl_RS_navBeverages.ForeColor = Color.Black;
                    lbl_RS_navCheckOut.ForeColor = Color.DarkRed;
                    break;
            }
        }

        private void btn_JV_CancelOrder_Click(object sender, EventArgs e)
        {
            FormConfirmCancel frmConfirmCancel = new FormConfirmCancel();
            frmConfirmCancel.ShowDialog();

        }
        #endregion

        //
        //Standard MouseOver effects that can be added to any button within FormMain
        //
        #region standardButtons

        //The folowing two event handlers (standardButtonEnter and standardButtonLeave) are to 
        //provide visual response for mouseover of the standard buttons
        private void standardButtonEnter(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            ButtonAnimation.ButtonEnterEffect(this, currentButton);
        }

        private void standardButtonLeave(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            ButtonAnimation.ButtonLeaveEffect(this, currentButton);
        }
        #endregion

        //
        // tabStart - Täman
        //
        #region tabStart Code (Täman)

        #region Dine In, Carry Out

        private void btn_TG_DineIn_Click(object sender, EventArgs e)
        {
            ClearFields();
            tabControl2.SelectTab(tab_TG_DineIn);
            txt_TG_NameDineIn.BackColor = colFormBackColor;
            txt_TG_NameDineIn.Focus();
            Button currentButton = sender as Button;
            ButtonAnimation.ButtonSelect(this, currentButton);
        }

        private void btn_TG_CarryOut_Click(object sender, EventArgs e)
        {
            ClearFields();
            tabControl2.SelectTab(tab_TG_CarryOut);
            txt_TG_NameCarryOut.BackColor = colFormBackColor;
            txt_TG_PhoneNum.BackColor = colFormBackColor;
            txt_TG_NameCarryOut.Focus();
            Button currentButton = sender as Button;
            ButtonAnimation.ButtonSelect(this, currentButton);
        }

        //private void btn_TG_ReturnCust_Click(object sender, EventArgs e)
        //{
        //    ClearFields();

        //    tabControl2.SelectTab(tab_TG_ReturnCust);
        //    txt_TG_Email.BackColor = colFormBackColor;
        //    txt_TG_Password.BackColor = colFormBackColor;
        //    txt_TG_Email.Focus();
        //    Button currentButton = sender as Button;
        //    ButtonAnimation.ButtonSelect(this, currentButton);
        //}

        #endregion

        #region Next Buttons

        private void btn_TG_NextDineIn_Click(object sender, EventArgs e)
        {
            bool dineIn = true;

            if (txt_TG_NameDineIn.Text == String.Empty)
            {
                frmErrorMess.LabelText = "Please enter your Name!";
                frmErrorMess.ShowDialog();

                txt_TG_NameDineIn.BackColor = colFormValidationError;
                txt_TG_NameDineIn.Focus();
            }
            else
            {
                Order newOrder = new Order(txt_TG_NameDineIn.Text, dineIn);
                tabControlOrderSequence.SelectTab(tabPageSizeCrust);
            }
        }

        private void btn_TG_NextCarryOut_Click(object sender, EventArgs e)
        {
            // Regex phoneNum = new Regex(@"^(\d{3})[ -]?(\d{3})[ -]?(\d{4}) x(\d*)");
            bool dineIn = false;

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
                Order newOrder = new Order(txt_TG_NameCarryOut.Text, dineIn, txt_TG_PhoneNum.Text);
                tabControlOrderSequence.SelectTab(tabPageSizeCrust);
            }

        }

        //private void btn_TG_NextReturnCust_Click(object sender, EventArgs e)
        //{
        //    Regex emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

        //    if (!emailRegex.IsMatch(txt_TG_Email.Text) || (txt_TG_Email.Text == String.Empty))
        //    {
        //        frmErrorMess.LabelText = "Please enter a valid Email address!";
        //        frmErrorMess.ShowDialog();

        //        txt_TG_Email.BackColor = colFormValidationError;
        //        txt_TG_Email.Focus();
        //    }
        //    else if (txt_TG_Password.Text == String.Empty)
        //    {
        //        frmErrorMess.LabelText = "Please enter your password!";
        //        frmErrorMess.ShowDialog();

        //        txt_TG_Password.BackColor = colFormValidationError;
        //        txt_TG_Password.Focus();
        //    }
        //    else
        //    {
        //        btnStart.ForeColor = Color.Black;
        //        btnSize.ForeColor = colRed;
        //        btnSpecialty.ForeColor = Color.Black;
        //        btnCheckOut.ForeColor = Color.Black;

        //        tabControlOrderSequence.SelectTab(tabPageSizeCrust);
        //    }
        //}

        #endregion

        #region TG standardButtons
        //private void TG_standardButtonSelector(Button button)
        //{
        //    //reset all buttons in group to standard color
        //    btn_TG_DineIn.BackColor = colRed;
        //    btn_TG_CarryOut.BackColor = colRed;
        //    btn_TG_ReturnCust.BackColor = colRed;

        //    //set the selected button back color to show it is selected
        //    button.BackColor = colDarkBlue;
        //}

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
            //txt_TG_Email.Clear();
            //txt_TG_Password.Clear();
        }

        #endregion

        #endregion

        //
        // tabBeverages
        //
        #region tabBeverage Code (Täman)

        private void TG_beverageSelect(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            ButtonAnimation.ButtonSelect(this, currentButton);
            Price bevPrice = new Price();

            // Checks what button is selected and sends size and price to object
            if (currentButton.Text == "Small")
            {
                size = Model.Beverage.BevSize.Small;
                price = bevPrice.BeverageSm;
                sizeChecked = true;
            }
            else if (currentButton.Text == "Medium")
            {
                size = Model.Beverage.BevSize.Medium;
                price = bevPrice.BeverageMd;
                sizeChecked = true;
            }
            else if (currentButton.Text == "Large")
            {
                size = Model.Beverage.BevSize.Large;
                price = bevPrice.BeverageLg;
                sizeChecked = true;
            }
            else if (currentButton.Text == "Bazinga XL")
            {
                size = Model.Beverage.BevSize.XL;
                price = bevPrice.BeverageXL;
                sizeChecked = true;
            }
            else if (currentButton.Text == "Coca-Cola")
            {
                drink = currentButton.Text;
                bevChecked = true;
                tabControl_TG_Beverages.SelectedTab = tab_TG_CocaCola;
            }
            else if (currentButton.Text == "Diet Coke")
            {
                drink = currentButton.Text;
                bevChecked = true;
                tabControl_TG_Beverages.SelectedTab = tab_TG_DietCola;
            }
            else if (currentButton.Text == "Sprite")
            {
                drink = currentButton.Text;
                bevChecked = true;
                tabControl_TG_Beverages.SelectedTab = tab_TG_Sprite;
            }
            else if (currentButton.Text == "Dr. Pepper")
            {
                drink = currentButton.Text;
                bevChecked = true;
                tabControl_TG_Beverages.SelectedTab = tab_TG_DrPepper;
            }
        }

        private void btn_TG_Add_Click(object sender, EventArgs e)
        {
            Beverage newBeverage = new Beverage(drink, size, 1, price);

            if (sizeChecked == true && bevChecked == true)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value.ToString().Contains(newBeverage.SizeName))
                    {
                        rowIndex = row.Index;
                    }
                }

                // Updates Current Quantity and Price
                if (rowIndex > -1)
                {
                    var current = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());

                    current++;
                    newBeverage.BevPrice = current * newBeverage.BasePrice;
                    newBeverage.Quantity = current;
                    dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = current;
                    dataGridView1.Rows[rowIndex].Cells["PriceColumn"].Value = newBeverage.BevPrice;
                }
                // If item doesn't exist this will create and add it.
                else
                {
                    dataGridView1.Rows.Add(newBeverage.Quantity, newBeverage.SizeName, newBeverage.BevPrice);

                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

                    newOrder.BeveragePurchase.Add(newBeverage);
                }
            }

            rowIndex = -1;
        }

        private void btn_TG_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                // Deletes user selected Row
                if (selectedIndex > -1)
                {
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
                // Deletes last entered row if user doesn't select a row
                else
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                }
            }

        }

        private void btn_TG_BevBack_Click(object sender, EventArgs e)
        {
            tabControlOrderSequence.SelectedTab = tabPageSizeCrust;
        }

        private void btn_TG_Bev_CheckOut_Click(object sender, EventArgs e)
        {
            tabControlOrderSequence.SelectedTab = tabPageCheckOut;
        }

        #endregion

        //
        // tabPageSize/Crust - Sue
        //
        #region tabPageSize/Crust Code (Sue)

        //creates pizza variable
        Pizza newPizza;
        decimal newPizzaPrice = 10.97m;
        string pizzaSize = "Large";
        string pizzaCrust = "Hand-Tossed";

        //The following eight event handlers are for the Size/Crust tab of the form

        private void btn_SL_sizeSmall_Click(object sender, EventArgs e)
        {
            ButtonAnimation.ButtonSelect(this, btn_SL_sizeSmall);
            pizzaSize = "Small";
            newPizzaPrice = 3.99m;
        }

        private void btn_SL_sizeMed_Click(object sender, EventArgs e)
        {
            ButtonAnimation.ButtonSelect(this, btn_SL_sizeMed);
            pizzaSize = "Medium";
            newPizzaPrice = 7.99m;
        }

        private void btn_SL_sizeLarge_Click(object sender, EventArgs e)
        {
            ButtonAnimation.ButtonSelect(this, btn_SL_sizeLarge);
            pizzaSize = "Large";
            newPizzaPrice = 10.97m;
        }

        private void btn_SL_sizeXLG_Click(object sender, EventArgs e)
        {
            ButtonAnimation.ButtonSelect(this, btn_SL_sizeXLG);
            pizzaSize = "Extra Large";
            newPizzaPrice = 13.97m;
        }

        private void btn_SL_crustHandTossed_Click(object sender, EventArgs e)
        {
            ButtonAnimation.ButtonSelect(this, btn_SL_crustHandTossed);
            pizzaCrust = "Hand Tossed";
        }

        private void btn_SL_crustChrispyThin_Click(object sender, EventArgs e)
        {
            ButtonAnimation.ButtonSelect(this, btn_SL_crustChrispyThin);
            pizzaCrust = "Crispy-Thin";
        }

        private void btn_SL_crustThick_Click(object sender, EventArgs e)
        {
            ButtonAnimation.ButtonSelect(this, btn_SL_crustThick);
            pizzaCrust = "Thick";
        }

        private void btn_SL_crustGlutenFree_Click(object sender, EventArgs e)
        {
            ButtonAnimation.ButtonSelect(this, btn_SL_crustGlutenFree);
            pizzaCrust = "Gluten-Free";
        }

        private void btn_SL_ChooseZa_Click(object sender, EventArgs e)
        {
            //instantsiates new pizza object
            newPizza = new Pizza();
            newPizza.Size = pizzaSize;
            newPizza.Crust = pizzaCrust;
            
            //moves to next tab
            tabControlOrderSequence.SelectedTab = tabPageSpecialtyPizzas;
        }

        #endregion

        //
        // tabPageCheckOut - Velis
        //
        #region tabPageCheckOut Code (Velis)

        //
        // initialize tabPageCheckOut
        //
        private void tabPageCheckOut_Enter(object sender, EventArgs e)
        {
            //
            // set the visiblity of the GroupBoxes on form
            //
            grpbox_JV_ConfirmPaymentInfo.Visible = false;
            grpbox_JV_PayForOrder.Visible = false;
            grpbox_JV_OrderInformation.Visible = true;
            grpbox_JV_ThankYou.Visible = false;

            //
            // fill in the Pizzas Information GroupBox before order confirmation
            //
            listBox_JV_Pizzas.DataSource = null;
            listBox_JV_Pizzas.DataSource = newOrder.PizzaPurchase;
            textBox_JV_PizzaSubtotal.Text = newOrder.PizzaSubtotal().ToString("C");

            //
            // fill in the Beverage Information GroupBox before order confirmation
            //
            listBox_JV_Beverages.DataSource = null;
            listBox_JV_Beverages.DataSource = newOrder.BeveragePurchase;
            textBox_JV_BeverageSubtotal.Text = newOrder.BeverageSubtotal().ToString("C");

            // update the order total
            txtBox_JV_OrderTotal.Text = newOrder.OrderTotal().ToString("C");

        }

        //
        // button click to continue to Payment Info groupbox
        //
        private void btn_JV_ContinueToPaymentInfo_Click(object sender, EventArgs e)
        {
            //
            // set the visiblity of the GroupBoxes on form
            //
            grpbox_JV_ConfirmPaymentInfo.Visible = false;
            grpbox_JV_PayForOrder.Visible = true;
            grpbox_JV_OrderInformation.Visible = false;
            grpbox_JV_ThankYou.Visible = false;
        }

        //
        // button click to continue to Thank You groupbox
        //
        private void btn_JV_CompleteOrder_Click(object sender, EventArgs e)
        {
            //
            // set the visiblity of the GroupBoxes on form
            //
            grpbox_JV_ConfirmPaymentInfo.Visible = false;
            grpbox_JV_PayForOrder.Visible = false;
            grpbox_JV_OrderInformation.Visible = false;
            grpbox_JV_ThankYou.Visible = true;

            //test
            newOrder.Number = 44;


            lbl_JV_OrderNumberTime.Text =
                "You are order " + newOrder.Number.ToString() + ". " +
                "Your order will be ready at " + DateTime.Now.AddMinutes(30).ToShortTimeString() + ".";

            writeOrderToDatabase();
           
        }

        //
        // button to add another pizza from Check Out
        //
        private void btn_JV_AddPizza_Click(object sender, EventArgs e)
        {
            tabControlOrderSequence.SelectTab(tabPageSizeCrust);
        }

        //
        // button to add another Beverage from Check Out
        //
        private void btn_JV_AddBeverage_Click(object sender, EventArgs e)
        {
            tabControlOrderSequence.SelectTab(tabPageBeverages);
        }

        //
        // button to remove selected pizza from Check Out
        //
        private void btn_JV_DeleteSelectedPizza_Click(object sender, EventArgs e)
        {
            if (listBox_JV_Pizzas.SelectedIndex >= 0)
            {
                newOrder.PizzaPurchase.RemoveAt(listBox_JV_Pizzas.SelectedIndex);
                listBox_JV_Pizzas.DataSource = null;
                listBox_JV_Pizzas.DataSource = newOrder.PizzaPurchase;
                listBox_JV_Pizzas.Refresh();
            }
        }
        
        //
        // button to remove selected beverage from Check Out
        //
        private void btn_JV_DeletedSelectedBeverage_Click(object sender, EventArgs e)
        {
            if (listBox_JV_Pizzas.SelectedIndex >= 0)
            {
                newOrder.BeveragePurchase.RemoveAt(listBox_JV_Beverages.SelectedIndex);
                listBox_JV_Beverages.DataSource = null;
                listBox_JV_Beverages.DataSource = newOrder.BeveragePurchase;
                listBox_JV_Beverages.Refresh();
            }
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
        //TODO: Velis - validate cc number
        //

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
                //FormCompletedOrder frmCompletedOrder = new FormCompletedOrder(this);
                //TODO: Velis - make new group visible
                grpbox_JV_PayForOrder.Visible = false;
                grpbox_JV_ConfirmPaymentInfo.Visible = true;
                updatePaymentInfo();
                updateConfirmPaymentInfoGroupBox();
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

        private void updatePaymentInfo()
        {
            newOrder.CCName = textBox_JV_CCName.Text;
            newOrder.Address = textBox_JV_CCAddress.Text;
            newOrder.City = textBox_JV_CCCity.Text;
            newOrder.StateProvince = textBox_JV_CCState.Text;
            newOrder.Zip = textBox_JV_CCZip.Text;
            newOrder.CCNumber = textBox_JV_CCNumber.Text;
            newOrder.CCExpMonth = int.Parse(comboBox_JV_CCExpMonth.SelectedItem.ToString());
            newOrder.CCExpYear = int.Parse(comboBox_JV_CCExpYear.SelectedItem.ToString());
            newOrder.CCCVVCode = int.Parse(textBox_JV_CCCVVCode.Text);
        }

        private void updateConfirmPaymentInfoGroupBox()
        {
            newOrder.LastName = "Velis";
            lbl_JV_BillingNameConfirm.Text = newOrder.CCName;
            lbl_JV_BillingAddressConfirm.Text = newOrder.Address;
            lbl_JV_BillingCityConfirm.Text = newOrder.City;
            lbl_JV_BillingStateProvinceConfirm.Text = newOrder.StateProvince;
            lbl_JV_BillingZipConfirm.Text = newOrder.Zip;
            lbl_JV_BillingEmailConfirm.Text = newOrder.Email;
            lbl_JV_CCNumberShort.Text = "**** " + newOrder.CCNumber.Substring(8, 4);
            lbl_JV_CCExpConfirm.Text =
                newOrder.CCExpMonth.ToString() +
                "/" +
                newOrder.CCExpYear.ToString();
        }
        #endregion

        //
        // tabPageSpecialtyZas - Roxy
        //
        #region tabPageSpecialtyZas Code (Roxy)

        #region Tab selection buttons

        private void btn_RS_toSpecialties_Click(object sender, EventArgs e)
        {
            tabControl_RS_Zas.SelectedTab = tabPage_RS_specialties;
            RS_isSpecialty = true;
            ButtonAnimation.ButtonSelect(this, btn_RS_toSpecialties);
        }

        private void btn_RS_toBuild_Click(object sender, EventArgs e)
        {
            tabControl_RS_Zas.SelectedTab = tabPage_RS_BuildAZa;
            RS_isSpecialty = false;
            ButtonAnimation.ButtonSelect(this, btn_RS_toBuild);
        }

        private void btn_RS_justCheese_Click(object sender, EventArgs e)
        {
            RS_isSpecialty = false;
            RS_toppings.Clear();
            RS_toppings.Add(Pizza.Topping.JustCheese);
            RS_addZa();
        }
        #endregion
        //button click events for specialty pizza page that change call ButtonSelect
        //method from ButtonAnimation class to highlight selected pizza and also show 
        //the panel that has the corresponding image and description.
        #region Specialty Za selection button clicks

        public int? RS_specialtyType;
        public bool RS_isSpecialty;

        private void btn_RS_cheese_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            ButtonAnimation.ButtonSelectInnerTab(this, currentButton);
            pnl_RS_cheese.BringToFront();

            RS_specialtyType = currentButton.TabIndex;
        }

        private void btn_RS_pepperoni_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            ButtonAnimation.ButtonSelectInnerTab(this, currentButton);
            pnl_RS_pepperoni.BringToFront();

            RS_specialtyType = currentButton.TabIndex;
        }

        private void btn_RS_meat_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            ButtonAnimation.ButtonSelectInnerTab(this, currentButton);
            pnl_RS_meat.BringToFront();

            RS_specialtyType = currentButton.TabIndex;
        }

        private void btn_RS_veggie_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            ButtonAnimation.ButtonSelectInnerTab(this, currentButton);
            pnl_RS_veggie.BringToFront();

            RS_specialtyType = currentButton.TabIndex;
        }

        private void btn_RS_supreme_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            ButtonAnimation.ButtonSelectInnerTab(this, currentButton);
            pnl_RS_supreme.BringToFront();

            RS_specialtyType = currentButton.TabIndex;
        }

        #endregion

        //button click events for toppings to turn them 'on' and 'off', called from
        //the ButtonAnimation class.  Toggles highlight.
        #region Topping selection button clicks

        List<Pizza.Topping> RS_toppings = new List<Pizza.Topping>();

        private void btn_RS_addPepperoni_Click(object sender, EventArgs e)
        {
            if (RS_toppings.Contains(Pizza.Topping.Pepperoni))
            {
                RS_toppings.RemoveAt(RS_toppings.IndexOf(Pizza.Topping.Pepperoni));
            }
            else
            {
                RS_toppings.Add(Pizza.Topping.Pepperoni);
            }

            ButtonAnimation.ButtonOnOff(this, btn_RS_addPepperoni);
        }

        private void btn_RS_addSausage_Click(object sender, EventArgs e)
        {
            if (RS_toppings.Contains(Pizza.Topping.ItalianSausage))
            {
                RS_toppings.RemoveAt(RS_toppings.IndexOf(Pizza.Topping.ItalianSausage));
            }
            else
            {
                RS_toppings.Add(Pizza.Topping.ItalianSausage);
            }

            ButtonAnimation.ButtonOnOff(this, btn_RS_addSausage);
        }

        private void btn_RS_addHam_Click(object sender, EventArgs e)
        {
            if (RS_toppings.Contains(Pizza.Topping.Ham))
            {
                RS_toppings.RemoveAt(RS_toppings.IndexOf(Pizza.Topping.Ham));
            }
            else
            {
                RS_toppings.Add(Pizza.Topping.Ham);
            }

            ButtonAnimation.ButtonOnOff(this, btn_RS_addHam);
        }

        private void btn_RS_addMushrooms_Click(object sender, EventArgs e)
        {
            if (RS_toppings.Contains(Pizza.Topping.Mushrooms))
            {
                RS_toppings.RemoveAt(RS_toppings.IndexOf(Pizza.Topping.Mushrooms));
            }
            else
            {
                RS_toppings.Add(Pizza.Topping.Mushrooms);
            }

            ButtonAnimation.ButtonOnOff(this, btn_RS_addMushrooms);
        }

        private void btn_RS_addOlives_Click(object sender, EventArgs e)
        {
            if (RS_toppings.Contains(Pizza.Topping.Olives))
            {
                RS_toppings.RemoveAt(RS_toppings.IndexOf(Pizza.Topping.Olives));
            }
            else
            {
                RS_toppings.Add(Pizza.Topping.Olives);
            }

            ButtonAnimation.ButtonOnOff(this, btn_RS_addOlives);
        }

        private void btn_RS_addPeppers_Click(object sender, EventArgs e)
        {
            if (RS_toppings.Contains(Pizza.Topping.GreenPeppers))
            {
                RS_toppings.RemoveAt(RS_toppings.IndexOf(Pizza.Topping.GreenPeppers));
            }
            else
            {
                RS_toppings.Add(Pizza.Topping.GreenPeppers);
            }

            ButtonAnimation.ButtonOnOff(this, btn_RS_addPeppers);
        }

        #endregion

        //addToOrder button clicks
        //validation and add za to order
        #region Add za to order

        private void btn_RS_addToOrder_Click(object sender, EventArgs e)
        {
            if (RS_specialtyType == null)
            {
                frmErrorMess.LabelText = "Please select a Specialty Za to add to your order. \n" +
                    "Or choose Build-a-Za or Just Cheese Please!";
                frmErrorMess.ShowDialog();
            }
            else
            {
                RS_addZa();
            }
        }

        private void btn_RS_addToOrder2_Click(object sender, EventArgs e)
        {
            if (RS_toppings.Count == 0)
            {
                frmErrorMess.LabelText = "Please select at lease one topping. \n" +
                    "Or choose Specialty Zas or Just Cheese Please!";
                frmErrorMess.ShowDialog();
            }
            else
            {
                RS_addZa();
            }
        }

        //
        //add to order button message simulation of adding to order
        //
        private void RS_addZa()
        {
            //TODO code to add the pizza to the order

            newPizza.IsSpecialty = RS_isSpecialty;

            if (RS_isSpecialty == true)
            {
                switch (RS_specialtyType)
                {
                    case 1:
                        newPizza.PizzaSpecialtyName = Pizza.SpecialtyName.UltimateCheese;
                        break;
                    case 2:
                        newPizza.PizzaSpecialtyName = Pizza.SpecialtyName.PiledHighPepperoni;
                        break;
                    case 3:
                        newPizza.PizzaSpecialtyName = Pizza.SpecialtyName.MoundsofMeat;
                        break;
                    case 4:
                        newPizza.PizzaSpecialtyName = Pizza.SpecialtyName.VeggiePatch;
                        break;
                    case 5:
                        newPizza.PizzaSpecialtyName = Pizza.SpecialtyName.SuperSupreme;
                        break;
                }

                //TODO - add 3.00m to Sue's original price variable and then set newPizza price
                newPizzaPrice += 3m;
                newPizza.PizzaPrice = newPizzaPrice;
                newPizza.Quantity = (byte)nud_RS_specialtyQuantity.Value;
            }
            else
            {
                if (RS_toppings.Contains(Pizza.Topping.JustCheese))
                {
                    //TODO - set newPizza price to whatever Sue's original price variable
                    newPizza.PizzaPrice = newPizzaPrice;
                    newPizza.Quantity = (byte)nud_RS_justCheeseQuantity.Value;
                }
                else
                {
                    //TODO - add (decimal)RS_toppings.Length to Sue's original price
                    newPizzaPrice += (decimal)RS_toppings.Count;
                    newPizza.PizzaPrice = newPizzaPrice;
                    newPizza.Quantity = (byte)nud_RS_buildZaQuantity.Value;
                }
                //Add toppings from local list to object list
                newPizza.PizzaToppings.AddRange(RS_toppings);
            }

            //TODO - add newPizza to newOrder PizzaPurchase list
            newOrder.PizzaPurchase.Add(newPizza);

            //Display confirmation to user and display navigation buttons
            frmErrorMess.LabelText = "You have added a Za to your order!";
            frmErrorMess.ShowDialog();
            btn_RS_addBeverage.Visible = true;
            btn_RS_anotherZa.Visible = true;
            btn_RS_checkOut.Visible = true;
            pnl_RS_whatNext.Visible = true;
        }
        #endregion

        //direct user to make a navigation choice
        #region Visible after pizza add

        private void btn_RS_anotherZa_Click(object sender, EventArgs e)
        {
            tabControlOrderSequence.SelectedIndex = 1;
        }
        private void btn_RS_addBeverage_Click(object sender, EventArgs e)
        {
            tabControlOrderSequence.SelectedIndex = 3;
        }
        private void btn_RS_checkOut_Click(object sender, EventArgs e)
        {
            tabControlOrderSequence.SelectedIndex = 4;
        }

        #endregion

        #endregion


        //
        //Write to Database Code (Sue)
        //
        #region WriteToDatabase Code (Sue)

        private void writeOrderToDatabase()
        {
            //add the data required to write
            
            newOrder.Date = DateTime.Now;

            //create a connection object
            //Did I add the correct string out of config.app?
            SqlConnection cn = new SqlConnection(Settings.Default.CSOrders);

            //create the SQL insert statement with parameters
            string sqlInsert = "INSERT INTO Orders" +
                "(OrderNumber,TimePlaced)" +
                "VALUES(@OrderNumber, @TimePlaced)";

            //Create the SQL command
            SqlCommand insertOrder = new SqlCommand(sqlInsert, cn);

            //add values for parameters from Order object
            insertOrder.Parameters.AddWithValue("@OrderNumber", newOrder.Number);
            insertOrder.Parameters.AddWithValue("@TimePlaced", newOrder.Date);

            using (cn)
            {
                try
                {
                    //open connection to the database
                    cn.Open();

                    //execute SQL command
                    insertOrder.ExecuteNonQuery();

                    //create the SQL select command to access the OrderID of the current record
                    string sqlSelect = "SELECT IDENT_CURRENT('Orders') FROM Orders";

                    //create the SQL command
                    SqlCommand selectOrderID = new SqlCommand(sqlSelect, cn);

                    //execute the SQL command and store the OrderID
                    int orderID = Convert.ToInt32(selectOrderID.ExecuteScalar());

                    //test pizza
                    //create the SQL insert statement with parameters
                    string sqlInsertPizza = "INSERT INTO Pizzas" +
                        "(OrderID, ZaSize, Crust, Specialty)" +
                        "VALUES(@OrderID, @ZaSize, @Crust, @Specialty)";

                   //Create the SQL command
                     SqlCommand insertPizza = new SqlCommand(sqlInsertPizza, cn);


                    //add values for parameters from Order object

                    insertPizza.Parameters.AddWithValue("@OrderID", orderID);
                    insertPizza.Parameters.AddWithValue("@ZaSize", newOrder.PizzaPurchase[0].Size);
                    insertPizza.Parameters.AddWithValue("@Crust", newOrder.PizzaPurchase[0].Crust);
                    insertPizza.Parameters.AddWithValue("@Specialty", newOrder.PizzaPurchase[0].IsSpecialty);
                   
                    //execute SQL command
                    insertPizza.ExecuteNonQuery();

                    //test beverage
                    //create the SQL insert statement with parameters
                    string sqlInsertBeverage = "INSERT INTO Beverage" +
                        "(OrderID, BevSize, BevType)" +
                        "VALUES(@OrderID, @BevSize, @BevType)";

                    //Create the SQL command
                    SqlCommand insertBeverage = new SqlCommand(sqlInsertBeverage, cn);


                    //add values for parameters from Order object

                    insertBeverage.Parameters.AddWithValue("@OrderID", orderID);
                    insertBeverage.Parameters.AddWithValue("@BevSize", newOrder.BeveragePurchase[0].Name);
                    insertBeverage.Parameters.AddWithValue("@BevType", newOrder.BeveragePurchase[0].BeverageSize);

                    //execute SQL command
                    insertBeverage.ExecuteNonQuery();

                    //display the new OrderID
                    //MessageBox.Show(orderID.ToString());

                }
                catch (SqlException ex)
                {
                    //use a messagebox for all SQL Exception
                    MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK);
                }
                finally
                {
                    //close connection
                    cn.Close();
                }
            }
        }
        #endregion

        //hidden close button in top left corner of app
        private void btn_hiddenClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       

    }
}

        #endregion