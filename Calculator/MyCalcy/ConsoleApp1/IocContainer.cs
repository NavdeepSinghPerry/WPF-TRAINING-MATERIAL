using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IDispatcher
    {
        void Invoke(Action action);
        void BeginInvoke(Action action);
    }

    public class DispatcherWrapper : IDispatcher
    {
        string dispatcher;
        public DispatcherWrapper()
        {
            dispatcher = "bavdeeo";
        }

        public void Invoke(Action action)
        {
          //  dispatcher.Invoke(action);
        }

        public void BeginInvoke(Action action)
        {
          //  dispatcher.BeginInvoke(action);
        }
    }

    public class IoCContainer
    {
        public static StandardKernel _Kernel { get; private set; } = new StandardKernel();


        public static void Setup()
        {
            BindViewModels();
        }

        private static void BindViewModels()
        {
            // Bind a VM of which only one instance will be created
            _Kernel.Bind<IDispatcher>().To<DispatcherWrapper>().InSingletonScope();
        }

        //public static object Get<T>()
        //{
        //    return _Kernel.Get<T>();
        //}
    }

    //public class BaseDispatcherUI
    //{
    //    public IDispatcher UI;
    //    public BaseDispatcherUI(IDispatcher dispatcher)
    //    {
    //        UI = dispatcher;
    //    }
    //}

    public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        public IDispatcher dispatcher;

        public ViewModelBase(IDispatcher dispatcher)
        {
            if (dispatcher == null)
               throw new ArgumentNullException("dispatcher");
            this.dispatcher = dispatcher;
        }
    
        public event PropertyChangedEventHandler PropertyChanged;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}