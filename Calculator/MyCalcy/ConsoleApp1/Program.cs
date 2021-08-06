using ClassLibrary3;
using Ninject;
using Ninject.Parameters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleApp1
{
    class Program
    {

        public Program()
        {           
        }
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterInstance<IDispatcher>(new DispatcherWrapper());

            Testing testing = new Testing(container.Resolve<IDispatcher>());
            

            //test.Show(IoCContainer._Kernel.Get<IDispatcher>());
            //var name = new ConstructorArgument("name", 2);
            //var val = new ConstructorArgument("val", "navdeep");
            //IoCContainer._Kernel.Get<Testing>(name, val);
    
            Console.ReadLine();
        }
    }
}
