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
            response.ApplyBrake();
            response.MoveForward();
            response.
        }
    }
}
