using SWC.BLL;
using SWC.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.UI.Workflows
{
    public class AllOrderLookupWorkflow
    {
        private string _date;

        public void Execute()
        {

            if (ExecuteMenuDate())
            {
                LookupOrders();
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        public void LookupOrders()
        {
            OrderManager manager = OrderManagerFactory.Create();

            AllOrderLookupResponse aoresponse = manager.LookupAllOrders(_date);


            if (aoresponse.Success)
            {
                foreach (var order in aoresponse.Orders)
                {
                    ConsoleIO.DisplayOrderDetails(order);
                }
            }
            else
            {
                Console.WriteLine("Orders do not exist on this date.  ");
                Console.WriteLine(aoresponse.Message);
            }
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
