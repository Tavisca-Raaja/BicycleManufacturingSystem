using System;
using System.Collections.Generic;
using System.Text;
using BicycleManufacteSystem.Interface;

namespace BicycleManufacteSystem.Models
{
    public class ConcreteBicycleFactory : BicycleFactory
    {
        public override IBicycle GetBicycle(BicycleType orderType,string color)
        {
            switch(orderType)
            {
                case BicycleType.Gear:
                                      return new GearCycle(color);
                case BicycleType.NonGear:
                                       return new Bicycle(color);
                default:
                    throw new ApplicationException();

                
            }
        }
    }
}
