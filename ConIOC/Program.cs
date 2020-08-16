using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConIOC
{
    class Program
    {
        static void Main(string[] args)
        {
            OfficeDocument od = new OfficeDocument(IOCBase.Resolve<IPrinter>());
            Console.WriteLine(od.Yazdir());


            OfficeDocument od1 = new OfficeDocument(IOCBase.Resolve<IPrinter>());
            Console.WriteLine(od1.Yazdir());

            OfficeDocument od2 = new OfficeDocument(IOCBase.Resolve<IPrinter>());
            Console.WriteLine(od2.Yazdir());


            OfficeDocument od3 = new OfficeDocument(IOCBase.Resolve<IPrinter>());
            Console.WriteLine(od3.Yazdir());


            Console.ReadKey();
        }
    }
}
