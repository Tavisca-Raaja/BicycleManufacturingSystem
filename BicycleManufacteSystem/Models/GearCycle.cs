using BicycleManufacteSystem.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.Models
{
    public class GearCycle :Bicycle,IGearCycle
    {
        public int MaximumGear { get; set; }
        public int DefaultGear { get; set; }
        public int CurrentGear { get; set; }
      
        public GearCycle(string color):base(color)
        {
            MaximumGear = 5;
            DefaultGear = 1;
            CurrentGear = 1;

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

        
    }
}
