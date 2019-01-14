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
        public IBicycle Manufacture()
        {
            return _factoryInitiater.GetBicycle(DefaultProductionType,DefaultProductionColor);
        }

        public IBicycle ManufactureOnOrder(ManufactureRequest order)
        {
            var response = CycleList.GetModelType(order.ModelNumber);
            BicycleType orderType;

            if (string.IsNullOrWhiteSpace(response))
                return null;    
            
            Enum.TryParse(response,out orderType);
            return _factoryInitiater.GetBicycle(orderType,order.color);
        }
    }

    public static class CycleList
    {
        public static List<CycleProductionStore> cycle = new List<CycleProductionStore>
        {
            new CycleProductionStore{ ModelNumber="A101" , Type =BicycleType.Gear},
            new CycleProductionStore{ModelNumber="A102",Type=BicycleType.NonGear}
        };

        public static string GetModelType(string modelNumber)
        {
            var requestItem = cycle.FirstOrDefault(x => x.ModelNumber == modelNumber);
            return requestItem?.Type.ToString();
        }
    }
}
