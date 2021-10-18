using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    /// <summary>
    /// methodları barındıran bir sınıf
    /// </summary>
    public class SingleMethods
    {
        public SingleObject SetValue()
        {
            return new SingleObject
            {
                Id = 1,
                ObjectName = "Single Object"
            };
        }
    }
}
