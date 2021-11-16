﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class SportPackage : BikeAccessories
    {
        public SportPackage(IBike bike) : base(bike)
        {
        }
        public override string GetDetails()
        {
            return base.GetDetails() + " + Sport Package";
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 10;
        }
    }

}
