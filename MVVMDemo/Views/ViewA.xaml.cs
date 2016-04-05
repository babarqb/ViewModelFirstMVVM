using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MVVMDemo.ViewModels;

namespace MVVMDemo.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class ViewA : UserControl,IViewA
    {
        public ViewA()
        {
            InitializeComponent();

            ViewModel = new ViewAViewModel(this);
            DataContext = ViewModel;
        }

        public IViewModel ViewModel { get { return (IViewAViewModel)DataContext; } set { DataContext = value; } }
    }
}
