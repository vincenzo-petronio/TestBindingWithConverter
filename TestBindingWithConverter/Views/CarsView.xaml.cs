﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace TestBindingWithConverter.Views
{
    public partial class CarsView : PhoneApplicationPage
    {
        public CarsView()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Unloaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = null;
        }
    }
}