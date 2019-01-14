using BicycleManufacteSystem.Interface;
using BicycleManufacteSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleShop.Interface
{
    public interface IBicycleSeller
    {
        IBicycle SellBicycle(ManufactureRequest order);
    }
}
