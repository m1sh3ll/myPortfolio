using SWC.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.BLL
{
    public static class OrderManagerFactory
    {
        public static OrderManager Create()
        {

            string mode = ConfigurationManager.AppSettings["Mode"].ToString();

            switch(mode)
            {
                //case "AddTest":
                //    return new OrderManager(new AddOrderTestRepository());
                //case "BasicTest":
                //    return new OrderManager(new BasicOrderTestRepository());
                //case "PremiumTest":
                //    return new OrderManager(new PremiumOrderTestRepository());
                case "FileTest":
                  //  return new OrderManager(new FileOrderRepository());
                default:
                    throw new Exception("Mode value in app config is not valid");
            }
        }
    }
}
