using SWC.BLL;
using SWC.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.UI.Workflows
{
    public class EditWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            OrderManager orderManager = OrderManagerFactory.Create();


            //just a template this is not real code
            //Console.Write("Enter an order number: ");
            ///string orderNumber = Console.ReadLine();          

            EditResponse response = orderManager.Edit(orderNumber, amount);

            if (response.Success)
            {
                Console.WriteLine("Edit completed!");
                Console.WriteLine($"Order Number: {response.Order.OrderNumber}");
                //more output here
            }
            else
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(response.Message);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
