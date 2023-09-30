using SWC.Models.Interfaces;
using SWC.Models;
using SWC.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SWC.Data
{
    public class ProductFileRepository : IProductRepo

    {
        // Instantiate taxes        
        private static List<Product> _products = new List<Product>();

        private string _filePath;
        private string _filedir = AppDomain.CurrentDomain.BaseDirectory;
        private string _basedir = @"..\..\FILES\";
        public string SetFilePath()
        {
            _filePath = _filedir + _basedir + "products.txt";
            return _filePath;
        }


        public Product DisplayProduct(string type)
        {
            _filePath = SetFilePath();
            var allProducts = DisplayAllProducts();
            Product product = allProducts.FirstOrDefault(x => x.Type == type);
            return product;

        }

        public List<Product> DisplayAllProducts()

        {
            _filePath = SetFilePath();

            List<Product> products = new List<Product>();

            using (StreamReader reader = new StreamReader(_filePath))
            {
                reader.ReadLine();
                string lineread;
                while ((lineread = reader.ReadLine()) != null)
                {
                    Product p = new Product();
                    string[] splits = lineread.Split(',');
                    p.Type = splits[0];
                    p.CostPerSquareFoot = Decimal.Parse(splits[1]);
                    p.LaborCostPerSquareFoot = Decimal.Parse(splits[2]);
                    products.Add(p);
                }
            }
            _products = products;
            return _products;

        }


    }
}
