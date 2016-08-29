
using ClassLibrary2.WebService;
using SnowRentLibrary.AsyncTask;
using SnowRentLibrary.Database;
using SnowRentLibrary.Entities;
using SnowRentLibrary.Enums;
using SnowRentLibrary.JSON;
using SnowRentLibrary.Logger;
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
            apiResult = await webService1.Get(c1.Id);

         
        }
        private async void SetupClientList()
        {

            Client client = new Client();
            List<Client> clientList = client.LoadMultipleItems();

            //Via Local
            //MySQLManager<Client> manager1 = new MySQLManager<Client>(DataConnectionResource.LOCALMYSQL);
            //manager1.Insert(clientList);

            //Via Api
            WebServiceManager<Client> webService1 =
            new WebServiceManager<Client>(DataConnectionResource.LOCALAPI);
            List<Client> apiResult;
            clientList = await webService1.Post(clientList);
            
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
