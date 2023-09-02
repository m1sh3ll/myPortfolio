using SWC.UI.Workflows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SWC.UI
{
    public static class Menu
    {

        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("SWC Flooring Orders Application");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Lookup Order");
                Console.WriteLine("2. Add New Order");
                Console.WriteLine("3. Update Order");
                Console.WriteLine("4. Delete Order");
                Console.WriteLine("5. Display All Orders");
                Console.WriteLine("\nQ to quit");
                Console.Write("\nEnter selection: ");

                string userinput = Console.ReadLine();


                switch (userinput)
                {
                    case "1":
                        OrderLookupWorkflow lWorkflow = new OrderLookupWorkflow();
                        lWorkflow.Execute();
                        break;
                    case "2":
                        OrderAddWorkflow aWorkflow = new OrderAddWorkflow();
                        aWorkflow.Execute();
                        break;
                    case "3":
                        OrderUpdateWorkflow uWorkflow = new OrderUpdateWorkflow();
                        uWorkflow.Execute();
                        break;
                    case "4":
                        OrderDeleteWorkflow dWorkflow = new OrderDeleteWorkflow();
                        dWorkflow.Execute();
                        break;
                    case "5":
                        AllOrderLookupWorkflow laWorkflow = new AllOrderLookupWorkflow();
                        laWorkflow.Execute();
                        break;
                    case "Q":
                        return;
                    case "q":
                        return;
                    default:
                        bool isValid = (Regex.IsMatch(userinput, "^[1-5qQ]+$"));
                        if (isValid == false)
                        {
                            Console.WriteLine("Invalid entry. Press any key to continue...");                            
                            Console.ReadKey();
                            Start();

                        }
                        break;

                }

            }

        }

    }
}
