using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public  class Testing
    {
        //public Testing(IDispatcher dispatcher, int name, string val)
        //{
        //    dispatcher.BeginInvoke(null);
        //    dispatcher.Invoke(null);
        //    Console.WriteLine($"{name} {val}");
        //}

        public Testing(IDispatcher dispatcher=null)
        {
            dispatcher.BeginInvoke(null);
            dispatcher.Invoke(null);
        }

        //public void Show(IDispatcher dispatcher)
        //{       
        //    Console.WriteLine($"Shown");
        //    dispatcher.Invoke(null);
        //}
    }
}
