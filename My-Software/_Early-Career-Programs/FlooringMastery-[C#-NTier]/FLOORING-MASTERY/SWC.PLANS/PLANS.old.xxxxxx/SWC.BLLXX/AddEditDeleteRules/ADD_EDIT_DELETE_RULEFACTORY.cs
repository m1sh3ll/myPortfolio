using SWC.Models;
using SWC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.BLL.AddEditDeleteRules
{
    public class Add_Edit_Delete_RuleFactory
    {
        public static IAdd_Edit_Delete_RuleFactory Create(OrderOperationType type)
        {
            switch (type)
            {
                case OrderOperationType.Add:
                    return new AddRule();
                case OrderOperationType.Edit:
                    return new EditRule();
                case OrderOperationType.Delete:
                    return new DeleteRule();
            }

            throw new Exception("Order operation type invalid!");
        }
    }
}
