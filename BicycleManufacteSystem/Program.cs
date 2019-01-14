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
                .AddSingleton<BicycleFactory, ConcreteBicycleFactory>();
                
            var serviceProvider = services.BuildServiceProvider();
            var appServiceProvider = serviceProvider.GetService<IBicycleCompany>();
            var response = appServiceProvider.Manufacture();
            var responseByOrder 
                = appServiceProvider.ManufactureOnOrder(new ManufactureRequest
                                                                             {
                                                                                 ModelNumber = "A",
                                                                                  Quantity = 1,
                                                                                  color ="Red"
                                                                              }
                                                        );
            var res = response as GearCycle;
            res.ApplyBrake();
       

            Console.ReadKey();
            
        }
    }
}
