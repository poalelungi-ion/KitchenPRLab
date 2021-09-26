using Restaurant.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Interfaces
{
    public interface ICookRepository
    {
        Cheef GetAvaialableCheef(int foodId);
    }
}
