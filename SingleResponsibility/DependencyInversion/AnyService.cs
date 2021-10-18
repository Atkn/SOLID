using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion
{
    
    public class AnyService 
    {
        private readonly ICollection<IWrite> writes;
        public AnyService(ICollection<IWrite> writes)
        {
            this.writes = writes;
        }

        public void SetMessage(string[] message)
        {
            foreach (var item in writes)
            {
                item.ToWrite(message);
            }
        }
    }
}
