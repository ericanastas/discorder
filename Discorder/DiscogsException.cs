using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder
{
    class DiscogsException:Exception
    {
        public DiscogsException(string message):base(message)
        {
            
        }
    }
}
