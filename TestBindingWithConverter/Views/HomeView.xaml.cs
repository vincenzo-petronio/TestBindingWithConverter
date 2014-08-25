using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using GalaSoft.MvvmLight.Messaging;

namespace TestBindingWithConverter.Views
{
    public partial class HomeView : PhoneApplicationPage
    {
        public HomeView()
        {
            InitializeComponent();

            // MESSENGER
            Messenger.Default.Register<String>(this, HandleNavigation);
        }

        private void HandleNavigation(String s) 
        {
            string page = String.Format("/Views/{0}.xaml", s);
            NavigationService.Navigate(new System.Uri(page, UriKind.Relative));
        }
    }
}