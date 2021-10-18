using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation
{
    public interface ITool
    {
        void PlaceTheNail();

        void Clicktrigger();
    }

    public class Hammer : ITool
    {
        public void Clicktrigger()
        {
            //hammer won't trigger
            throw new NotImplementedException();
        }

        public void PlaceTheNail()
        {
            throw new NotImplementedException();
        }
    }
}
