
using SWC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWC.Models;
using SWC.Models.Responses;

namespace SWC.BLL.EditRules
{
    public class EditRule : IEdit
    {
        public EditResponse Edit(Order order, decimal xxx)
        {
            EditResponse response = new EditResponse();

            if (order.Type != OrderOperationType.Edit)
            {
                response.Success = false;
                response.Message = "Error: this is the Edit Rule. ";
                return response;
            }
            if (xxx <= 0)
            {
                response.Success = false;
                response.Message = "must be positive.";
                return response;
            }
            
            if (Order.Total < 0)
            {
                response.Success = false;
                response.Message = "Orders cannot be negative";
                return response;
            }

            //if everything is all valid , then set the variables (properties of the order //and then send response success)
           //  order.OrderNumber = xxx;
           //  order.xxx
           //order.xxx

            response.Order = order;
            //response.anyotherorder variables = passed thru variables (Ie decimal xxx)      
            response.Success = true;

            return response;
        }
    }
}
