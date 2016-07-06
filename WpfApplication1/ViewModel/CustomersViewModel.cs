
using ClassLibrary2.WebService;
using ConsoleApplication2.AsyncTask;
using ConsoleApplication2.Database;
using ConsoleApplication2.Enums;
using ConsoleApplication2.JSON;
using ConsoleApplication2.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using WpfApplication1.Views;

namespace WpfApplication1.ViewModel
{
    public class CustomersViewModel
    {
        private CustomersView customersView;

        public CustomersView CustomersView
        {
            get { return customersView; }
            set { customersView = value; }
        }

         //constructeur
        public CustomersViewModel(CustomersView customersView)
        {
            this.customersView = customersView;
            this.customersView.clientsListUserControl.LoadItems(SetupClientList());
            this.SetupClientList();
            this.Populate();

        }
        private async void Populate()
        {
            WebServiceManager<Client> webService1 =
             new WebServiceManager<Client>(DataConnectionResource.LOCALAPI);
            Client c1 = new Client().LoadSingleItem();
            Client apiResult;
            c1 = await webService1.Post(c1);
            apiResult = await webService1.Get(c1.Id);
            String text = "";

            // Sandbox sb = new Sandbox();
            // sb.TestIt();
            // AsyncFactory facto = new AsyncFactory();
            //facto.TestIt();
            /*
            Task.Factory.StartNew(() =>
            {

                //permet d'acceder au thread ui
                Application.Current.Dispatcher.Invoke(DispatcherPriority.Background,
                    new ThreadStart(delegate
                    {
                        //change la couleur de fond
                        this.CustomersView.clientsListUserControl.Background = new SolidColorBrush(Color.FromRgb(100, 0, 0));
                    }));

            });

            int a = 0;
            a++;*/
        }
        private List<Client> SetupClientList()
        {
            Client client = new Client();
            List<Client> result = client.LoadMultipleItems();

            MySQLManager<Client> manager1 = new MySQLManager<Client>(DataConnectionResource.LOCALMYSQL);
            manager1.Insert(result);

            return result;
        }

       
    }
}
