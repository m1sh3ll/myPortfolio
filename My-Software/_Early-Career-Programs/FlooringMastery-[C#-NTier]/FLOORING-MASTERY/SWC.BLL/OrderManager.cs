//using SWC.BLL.AddEditDeleteRules;
using SWC.Models;
using SWC.Models.Interfaces;
using SWC.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization; 

namespace SWC.BLL
{
    public class OrderManager
    {
        private static IOrderRepository _orderRepository;
        private static ITaxRepo _taxRepo;
        private static IProductRepo _productRepo;
        private static int _lastOrderID;


        public OrderManager(IOrderRepository orderRepository, ITaxRepo taxRepo,
            IProductRepo productRepo)
        {
            _orderRepository = orderRepository;
            _productRepo = productRepo;
            _taxRepo = taxRepo;
        }
        public OrderLookupResponse LookupOrder(int orderNumber, string date)
        {
            OrderLookupResponse response = new OrderLookupResponse();

            response.Order = _orderRepository.DisplayOrder(orderNumber, date);

            if (response.Order == null)
            {
                response.Success = false;
                response.Message = $"Order# {orderNumber} on date {date} is not valid.";
            }
            else
            {
                response.Success = true;
            }
            return response;
        }
        public AllOrderLookupResponse LookupAllOrders(string date)
        {
            AllOrderLookupResponse response = new AllOrderLookupResponse();
            response.Orders = _orderRepository.DisplayAllOrders(date);

            if (response.Orders == null)
            {
                response.Success = false;
                response.Message = $"Orders on date {date} is not valid.";
            }
            else
            {
                response.Success = true;
            }
            return response;
        }

        public bool IfNotNull(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            return true;
        }

        public Order CalculateTaxRate(Order order)
        {
            TaxRate taxrate = _taxRepo.DisplayTax(order.State);
            if (IfNotNull(taxrate))
            {
                order.TaxRate = taxrate.TaxRatePercent;
            }
            else
            {
                order.TaxRate = 0;
            }
            return order;
        }
        public Order CalculateProduct(Order order)
        {
            Product product = _productRepo.DisplayProduct(order.ProductType);
            if (IfNotNull(product))
            {
                order.ProductType = product.Type;
                order.CostPerSquareFoot = product.CostPerSquareFoot;
                order.LaborCostPerSquareFoot = product.LaborCostPerSquareFoot;
            }
            else
            {
                order.ProductType = "";
                order.CostPerSquareFoot = 0;
                order.LaborCostPerSquareFoot = 0;
            }
            return order;
        }
        public Order CalculateOrder(Order order, string orderOperation)
        {
            order = CalculateTaxRate(order);
            order = CalculateProduct(order);                
            
            if (orderOperation != "Update" && orderOperation != "Delete")
            {
                SetLastOrderID(order);
                order.OrderNumber = GetLastOrderID();
            }
            order.MaterialCost = CalculateMaterialCost(order);
            order.LaborCost = CalculateLaborCost(order);
            order.Tax = CalculateTax(order);
            order.Total = CalculateOrderTotal(order);
            return order;
        }

        public void SetLastOrderID(Order order)
        {
            _lastOrderID = 0;
            List<Order> allOrdersOnDate = _orderRepository.DisplayAllOrders(order.OrderDate);
            try
            {
                _lastOrderID = allOrdersOnDate[allOrdersOnDate.Count() - 1].OrderNumber;
            }
            catch
            {
                _lastOrderID = 0;
            }
        }
        public int GetLastOrderID()
        {
            return _lastOrderID + 1;
        }

        public OrderAddResponse AddOrder(Order order)
        {
            OrderAddResponse response = new OrderAddResponse();

            if (IfNotNull(order))
            {
                order = CalculateOrder(order,"Add");

                response = _orderRepository.AddOrder(order);

                if (response.Success == true)
                {                    
                    response.Order = order;
                }

            }
            return response;
        }


        public static decimal CalculateOrderTotal(Order order)
        {
            return order.MaterialCost + order.LaborCost + order.Tax;
        }
        public static decimal CalculateTax(Order order)
        {
            return (order.MaterialCost + order.LaborCost) * (order.TaxRate / 100M);
        }

        public static decimal CalculateMaterialCost(Order order)
        {

            return order.Area * order.CostPerSquareFoot;
        }
        public static decimal CalculateLaborCost(Order order)
        {
            return order.Area * order.LaborCostPerSquareFoot;

        }


        public OrderDeleteResponse DeleteOrder(Order order)
        {
            OrderDeleteResponse response = new OrderDeleteResponse();

            if (IfNotNull(order))
            {
                response.LastOrderID = order.OrderNumber;
                response = _orderRepository.DeleteOrder(order);              

            }
            return response;
        }



        public OrderUpdateResponse UpdateOrder(Order order)
        {
            OrderUpdateResponse response = new OrderUpdateResponse();
            if (IfNotNull(order))
            {
                response = _orderRepository.UpdateOrder(order);
            }

            //response.Success = true;
            //response.Order = order;
            return response;
        }

        public ProductLookupResponse LookupAllProducts()
        {
            ProductLookupResponse response = new ProductLookupResponse();
            response.Products = _productRepo.DisplayAllProducts();

            if (response.Products == null)
            {
                response.Success = false;
                //response.Message = $"Orders on date {date} is not valid.";
            }
            else
            {
                response.Success = true;
            }
            return response;
        }



        public static Response ValidateCustomerName(string name)
        {
            Response response = new Response();
            //check if the name is alphanumeric + spaces + periods (and no commas)
            bool isvalid = false;
            try
            {
                isvalid = (Regex.IsMatch(name, "^[a-zA-Z0-9. ]+$"));

            }
            catch
            {
                isvalid = false;
            }

            if (isvalid == false)
            {
                response.Success = false;
                response.Message = "Customer Name" + " can only be letters, numbers, and periods";
                return response;
            }

            response.Success = isvalid;
            return response;
        }
        public static Response ValidateArea(string area)
        {
            Response response = new Response();
            //check if the name is alphanumeric + spaces + periods (and no commas)
            bool isvalid = false;
            try
            {
                isvalid = Regex.IsMatch(area.ToString(), "^[0-9]+$");

                if (Int32.Parse(area) < 100)
                {
                    isvalid = false;
                }

            }
            catch
            {
                isvalid = false;
            }

            if (isvalid == false)
            {
                response.Success = false;
                response.Message = "Area" + " can only be a number and be greater than 100.";
                return response;
            }

            response.Success = isvalid;
            return response;
        }

        public static Response ValidateState(string state)
        {
            Response response = new Response();
            bool isvalid = false;
            try
            {
                isvalid = (Regex.IsMatch(state, "^[a-zA-Z]+$"));

                if (isvalid)
                {
                    state = state.ToUpper();
                    if (state.Length != 2)
                    {
                        isvalid = false;
                    }
                }
            }
            catch
            {
                isvalid = false;
            }

            if (isvalid == false)
            {
                response.Success = false;
                response.Message = "State" + " can only be 2 letters";
                return response;
            }

            TaxRate taxrate = _taxRepo.DisplayTax(state);

            if (taxrate == null)
            {
                response.Success = false;
                response.Message = "Please enter a valid Customer State.";
                return response;
            }

            response.Success = true;
            //order.TaxRate = taxrate.TaxRatePercent;


            return response;

        }
        public static Response ValidateProduct(string producttype)
        {
            Response response = new Response();
            TextInfo Case = new CultureInfo("en-US", false).TextInfo;
            bool isvalid = false;
            try
            {
                isvalid = (Regex.IsMatch(producttype, "^[a-zA-Z]+$"));

                if (isvalid)
                {
                    producttype = Case.ToTitleCase(producttype);
                }
            }
            catch
            {
                isvalid = false;
            }

            if (isvalid == false)
            {
                response.Success = false;
                response.Message = "Product" + " can only be letters.";
                return response;
            }

            Product product = _productRepo.DisplayProduct(producttype);

            if (product == null)
            {
                response.Success = false;
                response.Message = "Product does not exist. Please enter a valid Product.";
                return response;
            }
            else
            {
                response.Success = true;
                //order.producttype
                // order.CostPerSquareFoot = product.CostPerSquareFoot;                //cost per sq ft
                // order.LaborCostPerSquareFoot = product.LaborCostPerSquareFoot;      //labor cost per sq ft
            }

            response.Success = true;
            return response;
        }

        public static Response ValidateDate(string entry, string orderOperation)

        {
            string type = "Date";
            Response response = new Response();
            if (entry == "" || entry == null)
            {
                response.Success = false;
                response.Message = type + " cannot be blank";
                return response;
            }
            try
            {
                DateTime orderdate = Convert.ToDateTime(entry);
            }
            catch
            {
                response.Success = false;
                response.Message = type + " is invalid. Format is MM/DD/YYYY";
                return response;
            }

            if (((entry == null) || (entry.Contains("/")) == false) || ((entry == "")) || (Regex.IsMatch(entry, "^[0-9/]+$") == false))
            {
                response.Success = false;
                response.Message = type + " is invalid. Format is MM/DD/YYYY";
                return response;
            }

            if (entry.Length != 10)
            {
                response.Success = false;
                response.Message = type + " is invalid. Must be 10 characters (Format: MM/DD/YYYY)";
                return response;
            }
            if (orderOperation != "Update")
            {
                if (Convert.ToDateTime(entry) < DateTime.Today)
                {
                    response.Success = false;
                    response.Message = type + " is invalid. Must be in the future.";
                    return response;
                }
            }
            response.Success = true;
            return response;
        }




        public Response ValidateDataRules(string type, Order order)
        {
            Response response = new Response();
            if ((order.CustomerName != "" && order.CustomerName != null) &&
                (order.OrderDate != "" && order.OrderDate != null) &&
                    (order.State != "" && order.State != null)
                    )
            {
                switch (type)
                {
                    case "Date":
                        try
                        {
                            DateTime orderdate = Convert.ToDateTime(order.OrderDate);
                        }
                        catch
                        {
                            response.Success = false;
                            response.Message = type + " is invalid. Format is MM/DD/YYYY";
                            return response;
                        }

                        if (((order.OrderDate == null) || (order.OrderDate.Contains("/")) == false) || ((order.OrderDate == "")) || (Regex.IsMatch(order.OrderDate, "^[0-9/]+$") == false))
                        {
                            response.Success = false;
                            response.Message = type + " is invalid. Format is MM/DD/YYYY";
                            return response;
                        }

                        if (order.OrderDate.Length != 10)
                        {
                            response.Success = false;
                            response.Message = type + " is invalid. Must be 10 characters (Format: MM/DD/YYYY)";
                            return response;
                        }
                        if (Convert.ToDateTime(order.OrderDate) < DateTime.Today)
                        {
                            response.Success = false;
                            response.Message = type + " is invalid. Must be in the future.";
                            return response;
                        }
                        break;

                    case "Customer Name":
                        //check if the name is alphanumeric + spaces + periods (and no commas)
                        bool isvalid;
                        try
                        {
                            isvalid = (Regex.IsMatch(order.CustomerName, "^[a-zA-Z0-9. ]+$"));

                        }
                        catch
                        {
                            isvalid = false;
                        }

                        if (isvalid == false)
                        {
                            response.Success = false;
                            response.Message = type + " can only be letters, numbers, and periods";
                            return response;
                        }

                        break;
                    case "Area":
                        var area = order.Area.ToString();
                        if ((area == "") || (area == null))
                        {
                            response.Success = false;
                            response.Message = type + " cannot be blank.";
                            return response;
                        }
                        if (numbersDecimalsOnlyRule(area) == false)
                        {
                            response.Success = false;
                            response.Message = type + " can only contain numbers (required) and one decimal point (optional)";
                            return response;
                        }
                        if (order.Area < 100)
                        {
                            response.Success = false;
                            response.Message = type + " must be greater than 100.";
                            return response;
                        }
                        break;
                    case "State":
                        string state = order.State;

                        if (lettersOnlyRule(state) == false)
                        {
                            response.Success = false;
                            response.Message = type + "entry can only contain 2 letters.";
                            return response;
                        }

                        break;
                }

            }
            else
            {
                response.Success = false;
                response.Message = "Invalid entry. One or more fields were blank or 0.";
                return response;
            }
            response.Success = true;
            return response;
        }
        public bool numbersDecimalsOnlyRule(string sString)
        {
            bool moreThanTwoDecimalPoints = (sString.Count(f => f == '.') > 1);

            if ((Regex.IsMatch(sString, "^[0-9.]+$") == false) || (moreThanTwoDecimalPoints == true) || sString.Contains("$"))
            {
                return false;
            }
            return true;

        }
        public bool lettersOnlyRule(string sString)
        {

            if ((Regex.IsMatch(sString, "^[a-zA-Z]+$") == false))
            {
                return false;
            }
            if (sString.Length != 2)
            {
                return false;
            }
            return true;

        }


        public Response ValidateAddDataEntry(Order order)
        {
            Response response = new Response();
            response.Success = true;

            Response vresponse = new Response();

            vresponse = ValidateDataRules("Date", order);

            if (vresponse.Success == false)
            {

                return vresponse;
            }

            vresponse = ValidateDataRules("Customer Name", order);

            if (vresponse.Success == false)
            {

                return vresponse;
            }
            vresponse = ValidateDataRules("Area", order);

            if (vresponse.Success == false)
            {

                return vresponse;
            }

            vresponse = ValidateDataRules("State", order);

            if (vresponse.Success == false)
            {

                return vresponse;
            }

            return response;
        }

        public static Response ValidateOrderNumber(string orderNum)
        {
            Response response = new Response();

            //check if the data is numeric
            bool isvalid = false;
            try
            {
                isvalid = Regex.IsMatch(orderNum, "^[0-9]+$");

                if (Convert.ToInt32(orderNum) <= 0)
                {
                    isvalid = false;
                }

            }
            catch
            {
                isvalid = false;
            }

            if (isvalid == false)
            {
                response.Success = false;
                response.Message = "Order Number" + " can only be a number and be greater than 0.";
                return response;
            }

            response.Success = isvalid;
            return response;
        }
    }
}





