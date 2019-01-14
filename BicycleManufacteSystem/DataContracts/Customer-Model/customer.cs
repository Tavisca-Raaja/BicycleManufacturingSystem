using BicycleManufacteSystem.DataContracts.Interface;
using BicycleManufacteSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.DataContracts.Customer_Model
{
    public class Customer : IPlaceOrder
    {
        private readonly IBicycleSeller _shop;

        public string CustomerName { get; set; }

        public Customer(IBicycleSeller shop)
        {
            _shop = shop;
        }

        public ManufactureResponse PlaceOrder(ManufactureRequest order)
        {
            return _shop.SellBicycle(order);
        }
    }
}
