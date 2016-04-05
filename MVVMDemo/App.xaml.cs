using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Unity;
using MVVMDemo.ViewModels;
using MVVMDemo.Views;

namespace MVVMDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IUnityContainer _container;

        public App()
        {

            _container = new UnityContainer();

        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _container.RegisterType<IViewAViewModel, ViewAViewModel>();
            _container.RegisterType<IViewA, ViewA>();
            
            var mainWindow = new MainWindow();
            App.Current.MainWindow = mainWindow;
            App.Current.MainWindow.Show();
        }

    }
}
