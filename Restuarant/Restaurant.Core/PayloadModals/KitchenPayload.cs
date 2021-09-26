using Restaurant.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.PayloadModals
{
    public class KitchenPayload
    {
        public int OrderId { get; set; }
        public int TableId { get; set; }
        public int WaiterId { get; set; }
        public IEnumerable<int> Items { get; set; }
        public int MaxWait { get; set; }
        public int Priority { get; set; }
        public long PickUpTime { get; set; }

    }
}
