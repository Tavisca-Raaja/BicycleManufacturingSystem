using BicycleCustomer.Interface;
using BicycleManufacteSystem.Interface;
using BicycleManufacteSystem.Models;
using BicycleShop.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleCustomer
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
            return _shop.PlaceOrder(order);
        }
    }
}
