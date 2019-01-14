using BicycleManufacteSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.DataContracts.Bicycle_shop_model
{
    
       public class BicycleStock
    {
        public string ModelNumber { get; set; }

        public int AvailableQuantity { get; set; }
        public BicycleType Type { get; set; }
    }
}
