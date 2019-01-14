using BicycleManufacteSystem.Interface;
using BicycleManufacteSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleCustomer.Interface
{
    public interface IPlaceOrder
    {
        IBicycle PlaceOrder(ManufactureRequest order);
    }
}
