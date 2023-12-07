using SWC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.UI
{
    public class ConsoleIO
    {
        public static void DisplayOrderDetails(Order order)
        {
            Console.WriteLine($"Order Number: {order.OrderNumber}");
            Console.WriteLine($"Total: {order.Total}");
            ///more stuff display here
        }
    }
}
