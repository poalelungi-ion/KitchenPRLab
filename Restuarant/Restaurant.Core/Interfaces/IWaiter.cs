using Restaurant.Core.PayloadModals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Interfaces
{
    public interface IWaiter
    {
        void GetOrder(KitchenPayload payload);
        void SendOrders(IEnumerable<KitchenPayload> payloads);
        void ServOrder(DistributionPayload payload);

    }
}
