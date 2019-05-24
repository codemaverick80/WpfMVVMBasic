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
using WpfMVVMBasic.ViewModels;

namespace WpfMVVMBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CustomerViewModel();
        }
    }
}

//https://www.youtube.com/watch?v=lool8Ut58Xw&list=PLw8ap9mWnEiLOsVQhbEMQPiHC_xZqLcdQ&index=2
// DCOM Engineering, LLC


////To Read -  
//// ReactiveProperty // https://github.com/runceel/ReactiveProperty
////https://okazuki.jp/ReactiveProperty/getting-started/wpf.html
/// Reactive MVVM https://medium.com/@worldbeater/reactive-mvvm-for-net-platform-175dc69cfc82


