using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacteSystem.Interface
{
    public interface IBicycle
    {
        void ApplyBrake();
        void Turn();
        void ApplyHorn();
        void MoveForward();
        void MoveBackWard();
    }
}
