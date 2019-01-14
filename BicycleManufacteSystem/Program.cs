using BicycleManufacteSystem.DataContracts.Bicycle_shop_model;
using BicycleManufacteSystem.DataContracts.Customer_Model;
using BicycleManufacteSystem.DataContracts.Interface;
using BicycleManufacteSystem.Interface;
using BicycleManufacteSystem.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BicycleManufacteSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection()
                .AddTransient<IBicycleCompany, BicycleManufacturingCompany>()
                .AddSingleton<BicycleFactory, ConcreteBicycleFactory>()
                .AddSingleton<IPlaceOrder,Customer>()
                .AddSingleton<IBicycleSeller, BicycleSeller>();
                
            var serviceProvider = services.BuildServiceProvider();
            var appServiceProvider = serviceProvider.GetService<IPlaceOrder>();
            var response = appServiceProvider.PlaceOrder(new ManufactureRequest{
                                                                                 ModelNumber="A102",
                                                                                 color="Blue",
                                                                                 Quantity=1
                                                                               });
          
            
        
            Console.ReadKey();
            
        }
    }
}
