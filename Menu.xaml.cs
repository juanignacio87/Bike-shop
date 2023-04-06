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

namespace Bike_shop
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void mailS_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Contact.xaml", UriKind.Relative));
        }

        private void liveSupport_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Discussion.xaml", UriKind.Relative));
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ProductsManagmentsMVVM.xaml", UriKind.Relative));
        }
    }
}
