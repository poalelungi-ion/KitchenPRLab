using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Domain
{
    public class Order : Entity
    {
        public IEnumerable<Food> Items { get; set; }
        public int MaxWait { get; set; }
        public int Priority { get; set; }
    }
}
