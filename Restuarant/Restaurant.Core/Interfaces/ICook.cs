using Restaurant.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Interfaces
{
    public interface ICook
    {
        Distribution GetFoodForCooking(int orderId, int tableId, int waiterId, long pickTime);
    }
}
