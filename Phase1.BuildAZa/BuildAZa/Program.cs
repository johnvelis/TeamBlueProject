using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BuildAZa
{


    class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]



        static void Main()
        {
            Order CustomerOrder = new Order();
            CustomerOrder.firstName = "John";
            CustomerOrder.lastName = "Velis";
            CustomerOrder.orderDate = DateTime.Today;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain_JV(CustomerOrder));
        }
    }
}
