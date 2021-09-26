﻿using Restaurant.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Interfaces
{
    public interface IDistributionRepository
    {
        public Distribution GetOrCreateDistribuion(int orderId, int tableId, int waiterId, long pickTime);
        void Served(int distributionId);
    }
}
