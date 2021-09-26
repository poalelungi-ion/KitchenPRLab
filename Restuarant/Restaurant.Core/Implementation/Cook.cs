using Restaurant.Core.Domain;
using Restaurant.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant.Core.Implementation
{
    public class Cook : ICook
    {
        private readonly ICookRepository _cookRepository;
        private readonly IDistributionRepository _distributionRepository;

        public Cook(ICookRepository cookRepository)
        {
            _cookRepository = cookRepository;
        }

        public Distribution GetFoodForCooking(int orderId, int tableId, int waiterId, long pickTime)
        {
            var distribution = _distributionRepository.GetOrCreateDistribuion(orderId, tableId, waiterId, pickTime);
            var foodToBePrepared = distribution.Order.Items.Where(x => !distribution.CookingDetails.Any(y => y.Food != x));// if the food was not prepared yet then prepare it
            var cookDetails = new List<FoodPreparation>();
            foreach(var food in foodToBePrepared)
            {
                var avilableCheef = _cookRepository.GetAvaialableCheef(food.Id);
                if (avilableCheef != null)
                    cookDetails.Add(new FoodPreparation {
                        Food = food,
                        Cook = avilableCheef
                    });
            }
            distribution.CookingDetails = cookDetails;
            return distribution;
        }
    }
}
