using BicycleManufacteSystem.DataContracts.Interface;
using BicycleManufacteSystem.Interface;
using BicycleManufacteSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BicycleManufacteSystem.DataContracts.Bicycle_shop_model
{
    public class BicycleSeller : IBicycleSeller
    {
        private readonly IBicycleCompany _cycleManufacturer;
        public BicycleSeller(IBicycleCompany cycleManufacturer)
        {
            _cycleManufacturer = cycleManufacturer;
        }
        public ManufactureResponse PlaceOrder(ManufactureRequest order)
        {
            return _cycleManufacturer.ManufactureOnOrder(order);
        }

       
        public ManufactureResponse SellBicycle(ManufactureRequest order)
        {
            var availability = Stock.CheckAvailability(order.ModelNumber);
            if (availability == null)
                return PlaceOrder(order);

            return availability;
        }
    }

    public static class Stock
    {
        static List<ManufactureResponse> AvailableCycle = new List<ManufactureResponse>
        {
            new ManufactureResponse{ModelNumber="A101",Price=8000,Cycle=new GearCycle("red")}
        };

        public static ManufactureResponse CheckAvailability(string modelNumber)
        {
            var response = AvailableCycle.FirstOrDefault(availability => availability.ModelNumber == modelNumber);

            return response;

        }
    }
}
