using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.Collections
{
    public abstract class ICollection
    {
        public abstract Iterator CreateIterator();
    }
}
