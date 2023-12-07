using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
  class Program
  {
    private static List<Product> _productsList = DataLoader.LoadProducts();
    private static List<Customer> _customersList = DataLoader.LoadCustomers();

    static void Main()
    {

      List<Action> lst = new List<Action>();
      lst.AddRange(new Action[] { Exercise1, Exercise2, Exercise3, Exercise4, Exercise5, Exercise6, Exercise7, Exercise8, Exercise9, Exercise10, Exercise11, Exercise12,
            Exercise13,Exercise14,Exercise15,Exercise16,Exercise17,Exercise18,Exercise19,Exercise20,Exercise21,Exercise22,Exercise23,Exercise24,Exercise25,Exercise26,Exercise27,Exercise28,Exercise29,
            Exercise30,Exercise31});

      int i = 0;
      while (i != 100)
      {
        Console.WriteLine("Enter exercise # or 100 to quit");
        try
        {
          i = Convert.ToInt32(Console.ReadLine());
          lst[i]();
        }
        catch
        {
          i = 100;
          Console.WriteLine("Invalid entry...exiting...");
        }
      }
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();

    }

    #region "Sample Code"
    /// <summary>
    /// Sample, load and print all the product objects
    /// </summary>
    static void PrintAllProducts()
    {

      PrintProductInformation(_productsList);
    }

    /// <summary>
    /// This will print a nicely formatted list of products
    /// </summary>
    /// <param name="products">The collection of products to print</param>
    static void PrintProductInformation(IEnumerable<Product> products)
    {
      string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
      Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
      Console.WriteLine("==============================================================================");

      foreach (var product in products)
      {
        Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
            product.UnitPrice, product.UnitsInStock);
      }

    }

    /// <summary>
    /// Sample, load and print all the customer objects and their orders
    /// </summary>
    /// 
    static void PrintAllCustomers()
    {
      var customers = DataLoader.LoadCustomers();
      PrintCustomerInformation(customers);
    }

    /// <summary>
    /// This will print a nicely formated list of customers
    /// </summary>
    /// <param name="customers">The collection of customer objects to print</param>
    /// 

    static void PrintCustomerInformation(IEnumerable<Customer> customers)
    {
      foreach (var customer in customers)
      {
        Console.WriteLine("==============================================================================");
        Console.WriteLine(customer.CompanyName);
        Console.WriteLine(customer.Address);
        Console.WriteLine("{0}, {1} {2} {3}", customer.City, customer.Region, customer.PostalCode, customer.Country);
        Console.WriteLine("p:{0} f:{1}", customer.Phone, customer.Fax);
        Console.WriteLine();
        Console.WriteLine("\tOrders");
        foreach (var order in customer.Orders)
        {
          Console.WriteLine("\t{0} {1:MM-dd-yyyy} {2,10:c}", order.OrderID, order.OrderDate, order.Total);
        }
        Console.WriteLine("==============================================================================");
        Console.WriteLine();
      }
    }
    #endregion

    /// <summary>
    /// Print all products that are out of stock.
    /// </summary>
    static void Exercise1()
    {

      var onlyInStock = from product in _productsList
                        where product.UnitsInStock == 0
                        select product;

      //lambda example var result2 = _productsList.Where(x => x.UnitsInStock == 0).FirstOrDefault();

      PrintProductInformation(onlyInStock);
    }

    /// <summary>
    /// Print all products that are in stock and cost more than 3.00 per unit.
    /// </summary>
    static void Exercise2()
    {
      var onlyInStock3 = from product in _productsList
                         where product.UnitsInStock > 0 && product.UnitPrice > 3
                         select product;

      PrintProductInformation(onlyInStock3);
    }

    /// <summary>
    /// Print all customer [and their order information??] for the Washington (WA) region.
    /// </summary>
    static void Exercise3()
    {
      var onlyCustomersInWA = from customer in _customersList
                              where customer.Region == "WA"
                              select customer;
      PrintCustomerInformation(onlyCustomersInWA);
    }

    /// <summary>
    /// Create and print an anonymous type with just the ProductName
    /// </summary>
    static void Exercise4()
    {
      var myAnonType = from prod in _productsList
                       select new { ProdName = prod.ProductName };
      foreach (var p in myAnonType)
      {
        Console.WriteLine(p.ProdName);
      }

    }

    /// <summary>
    /// Create and print an anonymous type of all product information but increase the unit price by 25%
    /// </summary>
    static void Exercise5()
    {

      var myAnonType = from p in _productsList
                       select new { PID = p.ProductID, PName = p.ProductName, Cat = p.Category, Price = (double)p.UnitPrice * 1.25, Inv = p.UnitsInStock };

      foreach (var prod in myAnonType)
      {
        Console.WriteLine($"PID: {prod.PID} {prod.PName} ${String.Format("{0:0.00}", prod.Price)} In Stock: {prod.Inv}  Category: {prod.Cat} ");
      }
    }

    /// <summary>
    /// Create and print an anonymous type of only ProductName and Category with all the letters in upper case
    /// </summary>
    static void Exercise6()
    {
      var myAnonType = from p in _productsList
                       select new { PName = p.ProductName.ToUpper(), Cat = p.Category.ToUpper() };

      foreach (var prod in myAnonType)
      {
        Console.WriteLine($"{prod.PName} \t\t\t {prod.Cat}");
      }

    }

    /// <summary>
    /// Create and print an anonymous type of all Product information with an extra bool property ReOrder which should 
    /// be set to true if the Units in Stock is less than 3
    /// 
    /// Hint: use a ternary expression
    /// </summary>
    static void Exercise7()
    {
      var myAnonType = from p in _productsList
                       select new { PID = p.ProductID, PName = p.ProductName, Cat = p.Category, Price = p.UnitPrice, Inv = p.UnitsInStock, ReOrder = p.UnitsInStock < 3 ? true : false };

      foreach (var i in myAnonType)
      {
        string status = i.ReOrder == true ? "* Yes *" : "No";

        Console.WriteLine($"PID: {i.PID} {i.PName} ${String.Format("{0:0.00}", i.Price)} In Stock: {i.Inv}  Category: {i.Cat} ----Reorder? {status}  ");
      }
    }

    /// <summary>
    /// Create and print an anonymous type of all Product information with an extra decimal called 
    /// StockValue which should be the product of --- unit price * units in stock
    /// </summary>
    static void Exercise8()
    {
      var myAnonType = from p in _productsList
                       select new { PID = p.ProductID, PName = p.ProductName, Cat = p.Category, Price = p.UnitPrice, Inv = p.UnitsInStock, StockValue = p.UnitsInStock * p.UnitPrice };

      foreach (var prod in myAnonType)
      {

        Console.WriteLine($"PID: {prod.PID} {prod.PName} ${prod.Price} In Stock: {prod.Inv}  Category: {prod.Cat} ----Value: ${String.Format("{0:0.00}", prod.StockValue)}  ");
      }
    }

    /// <summary>
    /// Print only the even numbers in NumbersA
    /// </summary>

    static void Exercise9()
    {
      var evens = from num in DataLoader.NumbersA
                  where num % 2 == 0
                  select num;

      foreach (int n in evens)
      {
        {
          Console.WriteLine(n);
        }
      }

    }

    /// <summary>
    /// Print only customers that have an order who's total is less than $500
    /// </summary>
    static void Exercise10()
    {
      var myAnonType = from c in _customersList
                       where c.Orders.Any(i => i.Total < 500)
                       select c;

      foreach (var i in myAnonType)
      {
        Console.WriteLine($"ID: {i.CustomerID} Company: {i.CompanyName} ");

        foreach (var j in i.Orders)
        {
          var str = j.Total < 500 ? $"Total: {j.Total}" : "over500";
          if (str != "over500")
          {
            Console.WriteLine($"Order#: {j.OrderID}\tDate: {j.OrderDate.ToShortDateString()}\tTotal: {j.Total}");
          }

        }

      }

    }

    /// <summary>
    /// Print only the first 3 odd numbers from NumbersC
    /// </summary>
    static void Exercise11()
    {
      var odds = from num in DataLoader.NumbersC
                 where num % 2 != 0
                 select num;
      odds = odds.Take(3);

      foreach (int n in odds)
      {
        {
          Console.WriteLine(n);
        }
      }
    }

    /// <summary>
    /// Print the numbers from NumbersB except the first 3
    /// </summary>
    static void Exercise12()
    {
      var nums = from num in DataLoader.NumbersB
                 select num;

      nums = nums.Skip(3);

      foreach (int n in nums)
      {
        {
          Console.WriteLine(n);
        }
      }
    }

    /// <summary>
    /// Print the Company Name and most recent order for each customer in Washington
    /// </summary>
    static void Exercise13()
    {
      var custWA = from customer in _customersList
                   where customer.Region == "WA"
                   select customer;

      foreach (var customer in custWA)
      {

        Console.WriteLine("\tOrders");
        var ordersort = customer.Orders.OrderByDescending(x => x.OrderDate);
        foreach (var o in ordersort)
        {
          Console.WriteLine("\t{0} {1:MM-dd-yyyy} {2,10:c}", o.OrderID, o.OrderDate, o.Total);
        }

      }




    }

    /// <summary>
    /// Print all the numbers in NumbersC until a number is >= 6
    /// </summary>
    static void Exercise14()
    {
      var nums = from num in DataLoader.NumbersC
                 select num;

      nums = nums.TakeWhile(n => n <= 6);

      foreach (int i in nums)
      {
        {
          Console.WriteLine(i);
        }
      }
    }

    /// <summary>
    /// 15---Print all the numbers in NumbersC that come after the first number divisible by 3
    /// </summary>
    static void Exercise15()
    {
      var nums = from num in DataLoader.NumbersC
                 select num;

      nums = nums.SkipWhile(n => (n % 3 != 0));

      foreach (int i in nums)
      {
        {
          Console.WriteLine(i);
        }
      }

    }

    /// <summary>
    /// Print the products alphabetically by name
    /// </summary>
    static void Exercise16()
    {
      var prod =
          from p in _productsList
          orderby p.ProductName
          select p;

      PrintProductInformation(prod);
    }

    /// <summary>
    /// 17--Print the products in descending order by units in stock
    /// </summary>
    static void Exercise17()
    {

      var prod =
          from p in _productsList
          orderby p.UnitsInStock descending
          select p;

      PrintProductInformation(prod);

    }

    /// <summary>
    /// 18-Print the list of products ordered first by category, then by unit price, from highest to lowest.
    /// </summary>
    static void Exercise18()
    {
      var prod =
          from p in _productsList
          orderby p.Category ascending, p.UnitPrice descending
          select p;

      PrintProductInformation(prod);
    }

    /// <summary>
    /// 19-Print NumbersB in reverse order
    /// </summary>
    static void Exercise19()
    {
      var nums = from num in DataLoader.NumbersB
                 orderby num descending
                 select num;

      foreach (int n in nums)
      {
        {
          Console.WriteLine(n);
        }
      }
    }

    /// <summary>
    /// Group products by category, then print each category name and its products
    /// ex:
    /// 
    /// Beverages
    /// Tea
    /// Coffee
    /// 
    /// Sandwiches
    /// Turkey
    /// Ham
    /// </summary>
    static void Exercise20()
    {
      var prod = from products in _productsList
                 orderby products.Category ascending
                 select products;

      foreach (var i in prod)
      {
        Console.WriteLine($"{i.Category} - {i.ProductName}");
      }


    }

    /// <summary> ****This is not done yet*****
    /// Print all Customers with their orders by Year then Month
    /// ex:
    /// 
    /// Joe's Diner
    /// 2015
    ///     1 -  $500.00
    ///     3 -  $750.00
    /// 2016
    ///     2 - $1000.00
    /// </summary>
    static void Exercise21()
    {

      List<Customer> customers = DataLoader.LoadCustomers();
      var query = from c in customers
                  select new
                  {
                    Name = c.CompanyName,
                    YearOrders = from o in c.Orders
                                 group o by o.OrderDate.Year into gyo
                                 select new
                                 {
                                   Year = gyo.Key,
                                   MonthOrders = from yo in gyo
                                                 group yo by yo.OrderDate.Month into gmo
                                                 select new
                                                 {
                                                   Month = gmo.Key,
                                                   Orders = gmo
                                                 }
                                 }
                  };
      foreach (var c in query)
      {
        Console.WriteLine("======================================");
        Console.WriteLine($"{c.Name}");
        Console.WriteLine("======================================");
        foreach (var Year in c.YearOrders)
        {
          Console.WriteLine($"{Year.Year}");
          foreach (var Month in Year.MonthOrders)
          {
            Console.WriteLine($"    {Month.Month} - ");
            foreach (var order in Month.Orders)
            {
              Console.WriteLine($"            {order.Total}");
            }
          }
        }
      }


    }

    /// <summary>
    /// Print the unique list of product categories
    /// </summary>
    static void Exercise22()
    {
      //Group By + Distinct
      var prod =
          from p in _productsList
          select p.Category;
      prod = prod.Distinct();

      foreach (var i in prod)
      {
        Console.WriteLine($"{i}");
      }


    }

    /// <summary>
    /// Write code to check to see if Product 789 exists
    /// </summary>
    static void Exercise23()
    {
      var prod = from p in _productsList
                 where p.ProductID == 789
                 select p;

      var num = prod.Count();

      if (num > 0)
      {
        foreach (var i in prod)
        {
          Console.WriteLine($"\tProduct ID: 789 - {i.ProductName}");
        }
      }




    }

    /// <summary>
    /// Print a list of categories that have at least one product out of stock
    /// </summary>
    static void Exercise24()
    {
      var prod = from p in _productsList
                 where p.UnitsInStock == 0
                 select p.Category;

      prod = prod.Distinct();

      foreach (var i in prod)
      {
        Console.WriteLine($"\tProduct ID: 789 - {i}");

      }
    }

    /// <summary>???
    /// Print a list of categories that have no products out of stock
    /// </summary>
    static void Exercise25()
    {
      var prod = from p in _productsList
                 where p.UnitsInStock > 0
                 select p.Category;

      prod = prod.Distinct();

      foreach (var i in prod)
      {
        Console.WriteLine($"\tProduct ID: 789 - {i}");

      }
    }

    /// <summary>
    /// Count the number of odd numbers in NumbersA
    /// </summary>
    static void Exercise26()
    {
      var nums =
          from n in DataLoader.NumbersA
          where n % 2 != 0
          select n;

      int totalNums = nums.Count();


      Console.WriteLine($"{totalNums}");

    }

    /// <summary>
    /// Create and print an anonymous type containing CustomerId and the count of their orders
    /// </summary>
    static void Exercise27()
    {
      var myAnonType = from c in _customersList
                       select new { cID = c.CustomerID, numOrders = c.Orders.Length };

      foreach (var p in myAnonType)
      {
        Console.WriteLine($"{p.cID} - #Orders: {p.numOrders}");
      }
    }




    /// <summary>
    /// Print a distinct list of product categories and the count of the products they contain
    /// </summary>
    static void Exercise28()
    {
      var prod = from i in _productsList
                 group i by i.Category into g
                 select new
                 {
                   Name = g.Key,
                   Count = g.Count()
                 };

      foreach (var i in prod)
      {
        Console.WriteLine("{0} {1}", i.Name, i.Count);
      }

    }

  }
}
