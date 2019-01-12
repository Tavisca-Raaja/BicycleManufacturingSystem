using BicycleManufacteSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.Interface
{
    public interface IBicycleCompany
    {
        IBicycle Manufacture();
        IBicycle ManufactureOnOrder(ManufactureRequest order);
    }
}
