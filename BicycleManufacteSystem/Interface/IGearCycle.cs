using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.Interface
{
    public interface IGearCycle :IBicycle
    {
        void IncreaseGear();
        void DecreaseGear();

    }
}
