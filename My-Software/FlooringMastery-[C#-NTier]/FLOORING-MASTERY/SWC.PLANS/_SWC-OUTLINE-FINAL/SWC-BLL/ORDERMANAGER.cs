using SWC.BLL.AddRules;
using SWC.BLL.EditRules;
using SWC.Models.Interfaces;
using SWC.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.BLL
{
    public class OrderManager
    {
        private IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public OrderSearchResponse SearchOrder(string orderNumber)
        {
            OrderSearchResponse response = new OrderSearchResponse();

            response.Order = _orderRepository.GetOrder(orderNumber);

            if(response.Order == null)
            {
                response.Success = false;
                response.Message = $"{orderNumber} is not a valid order.";
            }
            else
            {
                response.Success = true;
            }

            return response;
        }

        public OrderAddResponse Add(string orderNumber, decimal amount)
        {
            OrderAddResponse response = new OrderAddResponse();
            response.Order = _orderRepository.GetOrder(orderNumber);
            if (response.Order == null)
            {
                response.Success = false;
                response.Message = $"{orderNumber} is not a valid order.";
                return response;
            }
            else  {
                response.Success = true;
            }

            IAdd AddRule = AddRulesFactory.Create(response.Order.Type);
            response = AddRule.Add(response.Order, amount);
            if(response.Success) {
                _orderRepository.SaveOrder(response.Order);
            }

            return response;
        }


        public OrderEditResponse Edit(string orderNumber, decimal amount)
        {
            OrderEditResponse response = new OrderEditResponse();
            response.Order = _orderRepository.GetOrder(orderNumber);
            if (response.Order == null)
            {
                response.Success = false;
                response.Message = $"{orderNumber} is not a valid order.";
                return response;
            }
            else
            {
                response.Success = true;
            }
            IEdit EditRule = EditRulesFactory.Create(response.Order.Type);
            response = EditRule.Edit(response.Order, amount);
            if (response.Success)
            {
                _orderRepository.SaveOrder(response.Order);
            }
            return response;
        }
    }
}
