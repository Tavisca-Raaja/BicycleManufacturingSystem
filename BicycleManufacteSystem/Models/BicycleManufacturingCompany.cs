using BicycleManufacteSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BicycleManufacteSystem.Models
{
    public class BicycleManufacturingCompany : IBicycleCompany
    {
        public int ManufactureThreshold{ get; set; }
        public BicycleType DefaultProductionType { get; set; }
        public BicycleManufacturingCompany()
        {
            ManufactureThreshold = 10;
            DefaultProductionType = BicycleType.Gear;
        } 
        public IBicycle Manufacture()
        {
            var res = new GearCycle();

            return new NonGearCycle();
        }

        public IBicycle ManufactureOnOrder(ManufactureRequest order)
        {
            throw new NotImplementedException();
        }
    }

    public class CycleList
    {
        List<CycleProductionStore> cycle = new List<CycleProductionStore>
        {
            new CycleProductionStore{ ModelNumber="A101" , Type =BicycleType.Gear},
            new CycleProductionStore{ModelNumber="A102",Type=BicycleType.NonGear}
        };

        public BicycleType GetModelType(string modelNumber)
        {
            var requestItem = cycle.SingleOrDefault(x => x.ModelNumber == modelNumber);

            return requestItem.Type;
        }
    }
}
