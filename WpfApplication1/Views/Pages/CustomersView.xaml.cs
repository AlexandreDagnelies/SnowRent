using SnowRentLibrary.Entities;
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
using WpfApplication1.ViewModel;
using WpfApplication1.Views.Pages;

namespace WpfApplication1.Views
{
    /// <summary>
    /// Logique d'interaction pour CustomersView.xaml
    /// </summary>
    public partial class CustomersView : Page
    {
        private CustomersViewModel customersViewModel;

        public CustomersViewModel CustomersViewModel
        {
            get { return customersViewModel; }
            set { customersViewModel = value; }
        }
        
        public CustomersView()
        {
            InitializeComponent();
            this.customersViewModel = new CustomersViewModel(this);
            
        }

        private void navigation_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page2());
            
        }

      
       

    }
}
