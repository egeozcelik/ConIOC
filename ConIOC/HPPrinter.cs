using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConIOC
{
    public class HPPrinter : IPrinter
    {
        public string Print()
        {
            return "Hp Yazdırdı";
        }
    }
}
