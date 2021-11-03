using System;
using System.Collections.Generic;
using System.Text;

namespace Sellproduct
{
    class Milk : Product
    {
        public Milk(double volume, double fatrate,string name) : base(name)
        {
            this.Volume = volume;
            this.FatRate = fatrate;
        }

        public double Volume;
        public double FatRate;

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()} Volume:{Volume} FatRate:{FatRate}";

        }
        

    }
}
