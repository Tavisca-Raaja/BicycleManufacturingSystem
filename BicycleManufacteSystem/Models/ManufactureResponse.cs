using BicycleManufacteSystem.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.Models
{
    public class ManufactureResponse
    {
       public string ModelNumber { get; set; }
       public dynamic Cycle { get; set; }
       public Decimal Price { get; set; }
    }
}
