using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBindingWithConverter.ViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {

        public ViewModelLocator()
        {
            // IoC CONTAINER
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
            }
            else
            {
                // VIEW-MODELS
                SimpleIoc.Default.Register<CarsViewModel>();
                SimpleIoc.Default.Register<HomeViewModel>();
            }
        }

        public CarsViewModel CarsVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CarsViewModel>();
            }
        }

        public HomeViewModel HomeVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<HomeViewModel>();
            }
        }
    }
}
