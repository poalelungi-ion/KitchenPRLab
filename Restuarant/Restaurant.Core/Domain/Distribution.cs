using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Domain
{
    public class Distribution
    {
        public Order Order { get; set; }
        public Waiter Waiter { get; set; }
        public Table Table { get; set; }
        public IEnumerable<FoodPreparation> CookingDetails { get; set; }
        public int PickTime { get; set; }
        public int CookingTime { get; set; }
    }
}
