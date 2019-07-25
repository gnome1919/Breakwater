using Breakwater.DataModels;
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

namespace Breakwater.Test
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private FirstPage _firstPage;

        public Page1()
        {
            InitializeComponent();
            _firstPage = BLL.StateManager.GetState();
            this.DataContext = _firstPage;

            initComponentStates();
        }

        private void initComponentStates()
        {
            textbox1.Text = _firstPage.TextboxValue;
            btnClickMe.Content = _firstPage.ButtonTitle;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = _firstPage.TextboxValue;
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            _firstPage.TextboxValue = textbox1.Text;
            BLL.StateManager.SetState(_firstPage);
        }
    }
}
