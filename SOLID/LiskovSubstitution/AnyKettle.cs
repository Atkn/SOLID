using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LiskovSubstitution
{
    public class AnyKettle : Kettle, IKettle
    {
        public string StopKettle()
        {
            return "Şartel Attı";
        }
    }
}
