using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LiskovSubstitution
{
    public class OtherKettle : Kettle
    {
        public OtherKettle()
        {
            base.StartTemperature();
        }
    }
}
