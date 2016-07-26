using ClassLibrary2.WebService;
using SnowRentLibrary.AsyncTask;
using SnowRentLibrary.Database;
using SnowRentLibrary.Entities;
using SnowRentLibrary.Enums;
using SnowRentLibrary.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
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
            //this.customersView.clientsListUserControl.LoadItems(GetClientList());
            //this.SetupClientList();
            this.Populate();
            Task.Factory.StartNew(() =>
            {
                this.customersView.clientsListUserControl.LoadItems(this.GetClientList());
            });
            
           
        }
        private async void Populate()
        {
            WebServiceManager<Client> webService1 =
             new WebServiceManager<Client>(DataConnectionResource.LOCALAPI);
            Client c1 = new Client().LoadSingleItem();
            
            Client apiResult;
            c1 = await webService1.Post(c1);
            Console.WriteLine("l'id estlà ->>>" + c1.Id);
            apiResult = await webService1.Get(c1.Id);
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
        private async void SetupClientList()
        {

            Client clientList = new Client();
            List<Client> client = clientList.LoadMultipleItems();
            //List<Client> result = clientList.LoadMultipleItems();

           // Client client = new Client();
            //List<Client> result = client.LoadMultipleItems();

            //Via Local
            //MySQLManager<Client> manager1 = new MySQLManager<Client>(DataConnectionResource.LOCALMYSQL);
            //manager1.Insert(result);

            //Via Api
            WebServiceManager<Client> webService1 =
            new WebServiceManager<Client>(DataConnectionResource.LOCALAPI);
            List<Client> apiResult;
            client = await webService1.Post(client);
            //Console.WriteLine("l'id estlà ->>>" + client.Id);
            apiResult = await webService1.Get();
        }



        private List<Client> GetClientList()
        {
            WebServiceManager<Client> webService1 =
            new WebServiceManager<Client>(DataConnectionResource.LOCALAPI);

            List<Client> apiResult = webService1.Get().Result as List<Client>;

            return apiResult;
        }
    }
}
