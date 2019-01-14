using BicycleManufacteSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.Interface
{
    public interface IBicycleCompany
    {
        ManufactureResponse Manufacture();
       ManufactureResponse ManufactureOnOrder(ManufactureRequest order);

    }
}
