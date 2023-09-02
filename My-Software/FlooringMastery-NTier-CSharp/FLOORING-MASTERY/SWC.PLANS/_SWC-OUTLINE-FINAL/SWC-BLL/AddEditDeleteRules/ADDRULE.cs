
using SWC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWC.Models;
using SWC.Models.Responses;

namespace SWC.BLL.DeleteRules
{
    public class DeleteRule : IDelete
    {
        public DeleteResponse Delete(Order order)
        {
            DeleteResponse response = new DeleteResponse();

            if (order.Type != OrderOperationType.Delete)
            {
                response.Success = false;
                response.Message = "Error: this is the Delete Rule. ";
                return response;
            }        

         

//if everything is all valid ,  //Delete it)
           // order.Delete

            response.Order = order;                 
            response.Success = true;
            return response;
        }
    }
}
