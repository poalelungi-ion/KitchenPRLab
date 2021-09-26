using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Domain
{
    public class Food : Entity
    {
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public int Complexity { get; set; }
        public CookingAparature CookingApparatus { get; set; }
    }
}
