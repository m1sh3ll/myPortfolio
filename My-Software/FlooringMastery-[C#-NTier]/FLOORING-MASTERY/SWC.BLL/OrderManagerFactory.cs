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

            switch (mode)
            {
                case "Prod":
                    return new OrderManager(new OrderFileRepository(), new TaxFileRepository(), new ProductFileRepository());

                case "Test":
                    return new OrderManager(new OrderTestRepository(), new TaxTestRepository(), new ProductTestRepository());
                default:
                    throw new Exception("Mode value in app config is not valid");
            }
        }
    }
}
