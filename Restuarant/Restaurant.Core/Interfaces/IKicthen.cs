using Restaurant.Core.Domain;
using Restaurant.Core.PayloadModals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Interfaces
{
    public interface IKicthen
    {
        int RecieveOrder(KitchenPayload order);
    }
}
