using SnowRentLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApplication1.MyUserControl
{
    /// <summary>
    /// Logique d'interaction pour ClientListUserControl.xaml
    /// </summary>
    public partial class ClientListUserControl : BaseUserControl
    {
        private ObservableCollection<Client> clients;

        public ObservableCollection<Client> Clients
        {
            get { return this.clients; }
            set { this.clients = value;
                this.OnPropertyChanged("Clients");
            }
        }

        public ClientListUserControl()
        {
            InitializeComponent();
            this.Clients = new ObservableCollection<Client>();
            this.clientsListView.ItemsSource = this.Clients;
        }

        public void LoadItems(List<Client> items)
        {
            this.Clients.Clear();
            foreach (var item in items)
            {
                Clients.Add(item);
            }
        }
    }
}
