using BicycleCustomer.Interface;
using BicycleManufacteSystem.Interface;
using BicycleManufacteSystem.Models;
using BicycleShop.Interface;
using BicycleShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BicycleShop
{
    public class BicycleSeller : IBicycleSeller, IPlaceOrder
    {
        public IBicycle PlaceOrder(ManufactureRequest order)
        {
            throw new NotImplementedException();
        }

        public IBicycle SellBicycle(ManufactureRequest order)
        {
            var checkAvailability = Stock.CheckAvailability(order.ModelNumber);
            return null;
        }
    }

    public static class Stock
    {
        static List<IBicycle> AvailableCycle = new List<IBicycle>
        {
            new Bicycle{},
        };

        public static BicycleType? CheckAvailability(string modelNumber)
        {
            var response = AvailableCycle.FirstOrDefault(availability => availability.ModelNumber == modelNumber);

            return null;

        }
    }
}
