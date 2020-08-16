using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConIOC
{
    public static class IOCBase
    {
        private static IWindsorContainer _container;

        public static IWindsorContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = Resolver();
                }
                return _container;
            }
        }

        private static IWindsorContainer Resolver()
        {
            return new WindsorContainer().Register(Component.For<IPrinter>().ImplementedBy<EpsonPrinter>());
        }
        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }



    }
}
