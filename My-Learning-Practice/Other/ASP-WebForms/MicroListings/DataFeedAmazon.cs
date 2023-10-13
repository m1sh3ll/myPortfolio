using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInfo
{

  public class DataFeedAmazon
  {

    public List<string> SKUS { get; set; } = new List<string>();
    public List<string> QUANTITIES { get; set; } = new List<string>();
    public List<string> PRICES { get; set; } = new List<string>();


    public DataFeedAmazon() {
    //Default
    }




  }
}