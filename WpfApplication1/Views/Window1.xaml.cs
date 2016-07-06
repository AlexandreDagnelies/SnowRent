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
using System.Windows.Shapes;
using WpfApplication1.Views.Pages;

namespace WpfApplication1.Views
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            this.webBrowser1.Navigate(new Uri("https://www.youtube.com/watch?v=zBNm_Lf9Dps"));
            this.webBrowser2.Navigate(new Uri("http://carduel.ru/full/HGYFT"));
        }

         private void BtnNavigate1_Click(object sender, RoutedEventArgs e)
        {
           this.Content = new Page2();

        }

         private void BtnNavigate2_Click(object sender, RoutedEventArgs e)
         {
            //NavigationWindows1

         }

    }
}
