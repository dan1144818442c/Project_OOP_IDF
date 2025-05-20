using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__Analiza
{
    abstract class Target

    {
        protected  bool destroyed = false;
        protected Target() { }
        void destroy()
        {
            destroyed = true;
        }
        bool Get_status()
        {
            return destroyed;
        }
    }
}
