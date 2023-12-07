using SWC.BLL;
using SWC.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.UI.Workflows
{
    public class OrderLookupWorkflow
    {
        private string _orderID;
        private string _date;

        public void Execute()
        {

            if (ExecuteMenuDate() && ExecuteMenuOrderNum())
            {
                LookupOrder();
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        public void LookupOrder()

        {
            OrderManager manager = OrderManagerFactory.Create();
            OrderLookupResponse oresponse = manager.LookupOrder(Convert.ToInt32(_orderID), _date);

            if (oresponse.Success)
            {
                ConsoleIO.DisplayOrderDetails(oresponse.Order);
            }
            else
            {
                Console.WriteLine("Order does not exist.  ");
                Console.WriteLine(oresponse.Message);
            }
        }


        public bool ExecuteMenuOrderNum()
        {
            bool isValid = false;
            string entry = "";
            while (isValid == false)
            {
                Console.Write("Enter Order Number: (ie. 101): ");
                entry = Console.ReadLine();
                Response response = OrderManager.ValidateOrderNumber(entry);
                isValid = response.Success;
                if (response.Success == false)
                {
                    Console.WriteLine(response.Message + " Please re-enter");
                }
            }
            _orderID = entry;
            return true;
        }

        public bool ExecuteMenuDate()
        {
            bool isValid = false;
            Console.Clear();
            Console.WriteLine("Lookup Order");
            Console.WriteLine("--------------------------");
            string entry = "";

            while (isValid == false)
            {
                Console.Write("Enter Order Date: (ie. MM/DD/YYYY): ");
                entry = Console.ReadLine();
                Response response = OrderManager.ValidateDate(entry,"Lookup");
                isValid = response.Success;
                if (response.Success == false)
                {
                    Console.WriteLine(response.Message + " Please re-enter");

                }


            }
            _date = entry;
            return true;

        }




    }
}
