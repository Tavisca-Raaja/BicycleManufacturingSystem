using BicycleManufacteSystem.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.Models
{
    public class NonGearCycle : IBicycle
    {
        public string Color { get; set; }
        public string Material { get; set; }
        public string Wheel { get; set; }
        public string HandleBar { get; set; }
        public string Bell { get; set; }
        public string Pedal { get; set; }
        public void ApplyBrake()
        {
            Console.WriteLine("Brake Applied Successfully");
        }

        public void ApplyHorn()
        {
            Console.WriteLine("Horn Applied Successfully");
        }

        public void MoveBackWard()
        {
            Console.WriteLine("Moving in reverse Direction");
        }

        public void MoveForward()
        {
            Console.WriteLine("Moving in Forward Direction");
        }

        public void Turn()
        {
            Console.WriteLine("Turn Applied");
        }
    }
}
