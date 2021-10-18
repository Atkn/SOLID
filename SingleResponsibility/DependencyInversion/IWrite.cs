using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion
{
    public interface IWrite
    {
        void ToWrite(string[] message);
    }
}
