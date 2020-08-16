using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConIOC
{
    public class OfficeDocument
    {
        IPrinter _printer;
        public OfficeDocument(IPrinter printer)
        {
            _printer = printer;
        }
        public string Yazdir()
        {
            return _printer.Print();
        }

    }
}
