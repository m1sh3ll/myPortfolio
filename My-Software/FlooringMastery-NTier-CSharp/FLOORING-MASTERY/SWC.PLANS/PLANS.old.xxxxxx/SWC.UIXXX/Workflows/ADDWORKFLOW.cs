﻿using SWC.BLL;
using SWC.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.UI.Workflows
{
    public class AddWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            OrderManager orderManager = OrderManagerFactory.Create();

            //console prompts
           // Console.Write("Enter xxx: ");
            //string xxx = Console.ReadLine();
           // Console.Write("Enter xxxx");
          //  decimal xx = xxxx(Console.ReadLine());

            AddResponse response = orderManager.Add(orderNumber, xxxx);

            if (response.Success)
            {
                Console.WriteLine("Add completed!");
                Console.WriteLine($"Order Number: {response.Order.OrderNumber}");              
                Console.WriteLine($"Order Total: {response.OrderTotal}");
                //other stuff here
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
