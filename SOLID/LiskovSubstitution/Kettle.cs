using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LiskovSubstitution
{
    public abstract class Kettle
    {
        public string StartTemperature()
        {
            return "Su ısıtılıyor...";
        }
    }
}
