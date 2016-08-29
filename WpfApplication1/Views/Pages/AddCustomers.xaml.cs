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

namespace WpfApplication1.Views.Pages
{
    /// <summary>
    /// Logique d'interaction pour AddCustomers.xaml
    /// </summary>
    public partial class AddCustomers : Page
    {
    
        public AddCustomers()
        {
            InitializeComponent();
        }
        
        private void BtnNavigate1_Click(object sender,  System.Windows.RoutedEventArgs e)
        {
             this.NavigationService.Navigate(new CustomersView());
            
        }
    }
}
