using Restaurant.Core.Domain;
using Restaurant.Core.Interfaces;
using Restaurant.Core.PayloadModals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Implementation
{
    public class Kitchen : IKicthen
    {
        private readonly IFoodRepository _foodRepository;
        
        public Kitchen(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public int RecieveOrder(KitchenPayload orderPayload)
        {
            var order = new Order
            {
                Items = _foodRepository.GetFoodByIds(orderPayload.Items),
                MaxWait = orderPayload.MaxWait,
                Priority = orderPayload.Priority
            };
            return order.Id;
        }
    }
}
