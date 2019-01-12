using BicycleManufacteSystem.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.Models
{
    public class GearCycle : IGearCycle
    {
        public string Color { get; set; }
        public string Material { get; set; }
        public string Wheel { get; set; }
        public string HandleBar { get; set; }
        public string Bell { get; set; }
        public string Pedal { get; set; }
        public int MaximumGear { get; set; }
        public int DefaultGear { get; set; }
        public int CurrentGear { get; set; }
        public void ApplyBrake()
        {
            Console.WriteLine("Brake Applied Successfully");
        }

        public void ApplyHorn()
        {
            Console.WriteLine("Horn Applied Successfully");
        }

        public void DecreaseGear()
        {
            if (this.CurrentGear > this.DefaultGear)
            {
                CurrentGear--;
                Console.WriteLine($"Gear Decreased, current gear is {CurrentGear}");
            }
            else
            {
                Console.WriteLine("Already at Lowest Gear");
            }
        }

        public void IncreaseGear()
        {
            if (this.CurrentGear < this.MaximumGear)
            {
                CurrentGear++;
                Console.WriteLine($"Gear Increased , Current gear is {CurrentGear}");
            }
            else
            {
                Console.WriteLine("Already at threshold gear");
            }
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
