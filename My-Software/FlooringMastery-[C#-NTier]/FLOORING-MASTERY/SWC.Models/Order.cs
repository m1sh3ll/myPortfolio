using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.Models

{
    public class Order
    {        
        public int OrderNumber { get; set; }            //generate    
        public string OrderDate { get; set; }           //prompt   
        public string CustomerName { get; set; }        //prompt
        public string State { get; set; }               //prompt
        public decimal TaxRate { get; set; }            //GET via state/taxrates repo
        public string ProductType { get; set; }         //prompt 
        public decimal Area { get; set; }               //prompt
        public decimal CostPerSquareFoot { get; set; }  //GET via producttype / repo
        public decimal LaborCostPerSquareFoot { get; set; } //GET via producttype / repo
        public decimal MaterialCost { get; set; }       //calculated
        public decimal LaborCost { get; set; }          //calculated
        public decimal Tax { get; set; }                //calculated
        public decimal Total { get; set; }              //calculated  
    }
}
