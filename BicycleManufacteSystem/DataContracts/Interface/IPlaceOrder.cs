using BicycleManufacteSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.DataContracts.Interface
{
    public interface IPlaceOrder
    {
        ManufactureResponse PlaceOrder(ManufactureRequest order);
    }
}
