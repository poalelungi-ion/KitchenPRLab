using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Domain
{
    public class FoodPreparation : Entity
    {
        public Food Food { get; set; }
        public Cheef Cook { get; set; }
    }
}
