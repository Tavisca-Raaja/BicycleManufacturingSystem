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
        public string DefaultProductionColor { get; set; }

        private readonly BicycleFactory _factoryInitiater;
        public BicycleManufacturingCompany(BicycleFactory factoryInitiater)
        {
            _factoryInitiater = factoryInitiater;
            ManufactureThreshold = 10;
            DefaultProductionType = BicycleType.Gear;
        } 
        public ManufactureResponse Manufacture()
        {
            return new ManufactureResponse{ 
                                             ModelNumber="A200",
                                             Price=6000,
                                             Cycle =_factoryInitiater.GetBicycle(DefaultProductionType, DefaultProductionColor)
                                          };
        }

        public ManufactureResponse ManufactureOnOrder(ManufactureRequest order)
        {
            var response = CycleList.GetModelType(order.ModelNumber);     
            if (response == null)
                return null;

           
            return new ManufactureResponse
            {
                ModelNumber = response.ModelNumber,
                Price = response.price,
                Cycle = _factoryInitiater.GetBicycle(response.Type, order.color)
        };
            
        }
    }

    public static class CycleList
    {
        public static List<CycleProductionStore> cycle = new List<CycleProductionStore>
        {
            new CycleProductionStore{ ModelNumber="A101" , Type =BicycleType.Gear,price=8000},
            new CycleProductionStore{ModelNumber="A102",Type=BicycleType.NonGear,price=6000}
        };

        public static CycleProductionStore GetModelType(string modelNumber)
        {
            var requestItem = cycle.FirstOrDefault(x => x.ModelNumber == modelNumber);
            return requestItem;
        }
    }
}
