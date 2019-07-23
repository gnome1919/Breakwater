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

namespace Breakwater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Uri uri1 = null;
        private void ArmStaticTrv_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (uri1 == null)
            {
                uri1 = new Uri("Test/Page1.xaml", UriKind.Relative);
                frame1.Navigate(uri1);
            }
            else
            {
                frame1.Navigate(uri1);
            }            

        }

        private void ArmBermTrv_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new Uri("Test/Page2.xaml", UriKind.Relative));
        }
    }
}
