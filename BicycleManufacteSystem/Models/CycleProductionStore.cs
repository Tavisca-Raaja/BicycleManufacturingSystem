using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.Models
{
    public class CycleProductionStore
    {
        public string ModelNumber { get; set; }
        public BicycleType Type { get; set; }
    }

    public enum BicycleType
    {
        Gear,
        NonGear
    }
}
