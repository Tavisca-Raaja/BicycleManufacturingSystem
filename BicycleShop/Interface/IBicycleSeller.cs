using BicycleManufacteSystem.Interface;
using BicycleManufacteSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleShop.Interface
{
    public interface IBicycleSeller
    {
        ManufactureResponse SellBicycle(ManufactureRequest order);
        ManufactureResponse PlaceOrder(ManufactureRequest order);
    }
}
