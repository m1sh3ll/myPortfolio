using SWC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWC.Models;
using SWC.Models.Responses;

namespace SWC.Data
{
    public class ProductTestRepository : IProductRepo

    {
        #region "TEST DATA ONLY" - Instantiation products Tile 1/2M Laminate 2/4M, Wood 3/6M Carpet 4/8M 
        //List of products hardcoded for test repo - loaded at startup
        private static List<Product> _products = new List<Product>
        {
            new Product()
                {
                Type = "Tile",
                CostPerSquareFoot = 1M,
                LaborCostPerSquareFoot = 2M
            },
             new Product()
                {
                Type = "Laminate",
                CostPerSquareFoot = 2M,
                LaborCostPerSquareFoot = 4M
            },
             new Product()
                {
                Type = "Wood",
                CostPerSquareFoot = 3M,
                LaborCostPerSquareFoot = 6M
            },
             new Product()
                {
                Type = "Carpet",
                CostPerSquareFoot = 4M,
                LaborCostPerSquareFoot = 8M
            }

        };
        #endregion


        public Product DisplayProduct(string type)
        {

            Product p = _products.FirstOrDefault(x => x.Type == type);
            return p;
        }


        public List<Product> DisplayAllProducts()
        {

            return _products;
        }







    }
}
