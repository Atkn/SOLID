using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion
{
    public class Write : IWrite
    {
        public void ToWrite(string[] message)
        {
            foreach (var item in message)
            {
                Console.WriteLine(item);
            }
        }
    }
}
