using SWC.UI.Workflows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.UI
{
    public static class Menu
    {

        public static void Start()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("SWC Flooring Orders Application");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Search/Display Order");
                Console.WriteLine("2. Add");
                Console.WriteLine("3. Edit");
				        Console.WriteLine("4. Delete");
                Console.WriteLine("\nQ to quit");
                Console.Write("\nEnter selection: ");

                string userinput = Console.ReadLine();

                switch(userinput)
                {
                    case "1":
                        OrderLookupWorkflow lWorkflow = new OrderLookupWorkflow();
                        lWorkflow.Execute();
                        break;
                    case "2":
                        CreateWorkflow aWorkflow = new CreateWorkflow();
                        cWorkflow.Execute();
                        break;
                    case "3":
                        UpdateWorkflow uWorkflow = new UpdateWorkflow();
                        uWorkflow.Execute();
                        break;
					 case "4":
                        RemoveWorkflow rWorkflow = new RemoveWorkflow();
                        rWorkflow.Execute();
                        break;
                    case "Q":
                        return;
                }

            }

        }
        
    }
}
