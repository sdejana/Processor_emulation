using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektni1_AR
{
    public abstract class Register
    {
        protected ulong value;
        public ulong Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public void Reset ()
        {
            value = 0;
        }

    }
}
