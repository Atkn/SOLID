using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClosed
{
    public class AnyAtm : Bank
    {
        public override double DrawMoney(double money)
        {
            return money;
        }

        
    }
}
