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
                .AddTransient<IBicycleCompany,BicycleManufacturingCompany> ();
            var serviceProvider = services.BuildServiceProvider();
            var appServiceProvider = serviceProvider.GetService<IBicycleCompany>();
            var response = appServiceProvider.Manufacture();
            var responseByOrder 
                = appServiceProvider.ManufactureOnOrder(new ManufactureRequest
                                                                             {
                                                                                 ModelNumber = "A101",
                                                                                  Quantity = 1
                                                                              }
                                                        );
            var res = response as GearCycle;
            if(res!=null)
            {
                res.DefaultGear = 0;
                res.MaximumGear = 3;
                res.IncreaseGear();
                res.DecreaseGear();
                res.ApplyBrake();
            }
            Console.ReadKey();
            
        }
    }
}
