using BicycleCustomer.Interface;
using BicycleManufacteSystem.Interface;
using BicycleManufacteSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleCustomer
{
    public class Customer : IPlaceOrder
    {
        public string CustomerName { get; set; }

        public IBicycle PlaceOrder(ManufactureRequest order)
        {
            throw new NotImplementedException();
        }
    }
}
