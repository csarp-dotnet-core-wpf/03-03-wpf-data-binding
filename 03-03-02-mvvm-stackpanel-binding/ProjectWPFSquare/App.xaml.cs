﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using ProjectWPFSquare.ViewModel;

namespace ProjectWPFSquare
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // MVVM.08 Felülírjuk az OnStartup metódust
        protected override void OnStartup(StartupEventArgs e)
        {
            // MVVM.09 Példányosítunk egy ViewModelt
            SquareViewModel squareViewModel = new SquareViewModel();

            base.OnStartup(e);
        }
    }
}
