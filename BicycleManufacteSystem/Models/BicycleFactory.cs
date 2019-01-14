using BicycleManufacteSystem.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.Models
{
    public abstract class BicycleFactory
    {
        public abstract IBicycle GetBicycle(BicycleType orderType,string color);
    }
}
