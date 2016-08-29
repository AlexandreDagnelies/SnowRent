
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
    public class ProductsViewModel
    {
        private ProductsView productsView;

        public ProductsView ProductsView
        {
            get { return productsView; }
            set { productsView = value; }
        }

         //constructeur
        public ProductsViewModel(ProductsView productsView)
        {
            this.productsView = productsView;
            //this.customersView.clientsListUserControl.LoadItems(GetClientList());
            //this.SetupClientList();
            this.Populate();
            
            Task.Factory.StartNew(() =>
            {
                this.productsView.productListUserControl.LoadItems(this.GetProductsList());
            
            });
            
           
        }
        private async void Populate()
        {

            
            //Via Local
            //MySQLManager<Client> manager1 = new MySQLManager<Client>(DataConnectionResource.LOCALMYSQL);
            //manager1.Insert(productList);

            //Via Api
            WebServiceManager<Product> webService2 =
            new WebServiceManager<Product>(DataConnectionResource.LOCALAPI);
            Product product = new Product().LoadSingleItem();

            Product apiResult;
            product = await webService2.Post(product);

            apiResult = await webService2.Get(product.Id);
         
        }
      


        private List<Product> GetProductsList()
        {
            WebServiceManager<Product> webService1 =
            new WebServiceManager<Product>(DataConnectionResource.LOCALAPI);

            List<Product> apiResult = webService1.Get().Result as List<Product>;

            return apiResult;
        }


    }
}
