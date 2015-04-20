using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BazingaPizzaria.Model;
using BazingaPizzaria.Properties;

namespace BazingaPizzaria
{
    public partial class BackOfHouse : Form
    {
        public BackOfHouse()
        {
            InitializeComponent();
            readOrderFromDatabase();
        }

        private void readOrderFromDatabase()
        {
            // instantiate an Order and add the data required to read from the database           
            Order currentOrder = new Order();
            currentOrder.Number = 17;

            // create a connection object
            SqlConnection cn = new SqlConnection(Settings.Default.CSOrders);

            // create the SQL SELECT statement with parameters
            string sqlSelectString = "SELECT OrderNumber, TimePlaced, Completed " +
                "FROM Orders";

            // create the SQL command 
            SqlCommand selectOrder = new SqlCommand(sqlSelectString, cn);

            // add values for parameters from Order object
            selectOrder.Parameters.AddWithValue("@OrderNumber", currentOrder.Number);

            using (cn)
            {
                try
                {
                    // open connection to database
                    cn.Open();

                    // create SQL DataReader
                    SqlDataReader orderReader = selectOrder.ExecuteReader();


                    // if a record is read
                    //if (orderReader.Read())
                    //{
                        // update the Order object
                        //currentOrder.Number = (int)orderReader["OrderNumber"];
                        //currentOrder.Date = (DateTime)orderReader["TimePlaced"];
                        //string myOrder = Convert.ToString(currentOrder.Number) + " " + Convert.ToString(currentOrder.Date);

                        //// display the data added to the Order object
                        //MessageBox.Show(currentOrder.Number.ToString() + " " + currentOrder.Date.ToLongTimeString());

                        while (orderReader.Read())
                        {
                            currentOrder.Number = (int)orderReader["OrderNumber"];
                            currentOrder.Date = (DateTime)orderReader["TimePlaced"];
                            string myOrder = Convert.ToString(currentOrder.Number) + " " + Convert.ToString(currentOrder.Date);

                            // display the data added to the Order object
                            MessageBox.Show(currentOrder.Number.ToString() + " " + currentOrder.Date.ToLongTimeString());

                            listBox1.Items.Add(myOrder);

                        }

                    //}
                }
                catch (SqlException ex)
                {
                    // use a messagebox for all SQL Exceptions
                    MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK);
                }
                finally
                {
                    // close connection
                    cn.Close();
                }
            }
        }

        #region Buttons
        private void btnCancelOrder_TG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to cancel this order?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (DialogResult == DialogResult.OK)
            {
                // Removes order from file/database/whatever its called
            }
            else
            {
                // Don't believe I need this 
            }
        }

        private void btnNext_TG_Click(object sender, EventArgs e)
        {
            // need to select next order in queque
        }

        private void btnPrevious_TG_Click(object sender, EventArgs e)
        {
            // needs to select previous order in list
        }

        private void btnDone_TG_Click(object sender, EventArgs e)
        {
            // this button will remove the order after notifying the customer
        }
        #endregion

        private void BackOfHouse_Load(object sender, EventArgs e)
        {

        }
    }
}
