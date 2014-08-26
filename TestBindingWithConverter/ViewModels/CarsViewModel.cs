using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBindingWithConverter.DataModels;

namespace TestBindingWithConverter.ViewModels
{
    public class CarsViewModel : ViewModelBase
    {
        private ObservableCollection<Car> cars;
        private Car selectedCar;

        public CarsViewModel()
        {
            if (IsInDesignMode)
            {
            }
            else
            {
                // INIT
                this.cars = new ObservableCollection<Car>();
                this.selectedCar = null;

                // FAKE DATA
                for (int i = 1; i <= 10; i++)
                {
                    Car newCar = new Car { Id = i, Company = "Company_" + i, Name = "Name_" + i, Year = "200" + i };
                    Cars.Add(newCar);
                }
            }
        }

        public ObservableCollection<Car> Cars
        {
            get 
            {
                System.Diagnostics.Debug.WriteLine("[CARSVIEWMMODEL] \t" + "GET Cars");
                return cars; 
            }

            set 
            {
                if (cars != value)
                {
                    cars = value;
                    System.Diagnostics.Debug.WriteLine("[CARSVIEWMMODEL] \t" + "SET Cars");
                    RaisePropertyChanged(() => Cars);
                }
            }
        }

        public Car SelectedCar
        {
            get
            {
                System.Diagnostics.Debug.WriteLine("[CARSVIEWMMODEL] \t" + "GET SelectedCar");
                return selectedCar;
            }

            set
            {
                if (value != selectedCar && null != value)
                {
                    selectedCar = value;
                    System.Diagnostics.Debug.WriteLine("[CARSVIEWMMODEL] \t" + "SET SelectedCar");
                    RaisePropertyChanged(() => SelectedCar);
                }
            }
        }
    }
}
