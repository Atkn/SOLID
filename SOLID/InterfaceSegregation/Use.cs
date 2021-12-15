using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation
{
    public interface IScrewdriver
    {
        void PlaceTheNail();
    }

    public interface IDrill
    {
        void Clicktrigger();
    }

    public class Screwdriver : IScrewdriver
    {
        public void PlaceTheNail()
        {
            Console.WriteLine("waiting");
        }
    }

    public class Drill : IDrill
    {
        public void Clicktrigger()
        {
            Console.WriteLine("waiting");
        }
    }
}
