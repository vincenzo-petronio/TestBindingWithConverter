using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBindingWithConverter.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel()
        {
            if (IsInDesignMode)
            {
            }
            else
            {
                NavToPageCommand = new RelayCommand(NavToPageCommandExecute);
            }
        }

        private void NavToPageCommandExecute()
        {
            Messenger.Default.Send<string>("CarsView");
        }

        public RelayCommand NavToPageCommand
        {
            get;
            private set;
        }
    }
}
