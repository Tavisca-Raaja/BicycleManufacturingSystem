using BicycleManufacteSystem.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.Models
{
    public class Bicycle : IBicycle
    {
        public string Color { get; set; }
        public int Wheel { get; set; }
        public string HandleBar { get; set; }
        public string Bell { get; set; }
        public string Pedal { get; set; }

        public Bicycle()
        {
            Wheel = 2;
            HandleBar = "BullHorn";
            Bell = "Electra-Ringer";
            Pedal = "Clipless";
        }

        public Bicycle(string color)
            :this()
        {
            Color = color;
        }
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
