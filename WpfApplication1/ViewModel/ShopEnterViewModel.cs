using ConsoleApplication2.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Views;

namespace WpfApplication1.ViewModel
{
    /*
    public class ShopEnterViewModel
    {
        private ShopEnterView shopEnterView;

        public ShopEnterView ShopEnterView
        {
            get { return shopEnterView; }
            set { shopEnterView = value; }
        }
        //constructeur
        public ShopEnterViewModel(ShopEnterView shopEnterView)
        {
            this.shopEnterView = shopEnterView;
            this.ShopEnterView.clientUserControl.Client = SetupClient();
            this.ShopEnterView.productUserControl.Product = SetupProduct();
            this.ShopEnterView.productListUserControl.LoadItems(SetupProductList());
            this.ShopEnterView.myBtn.Click += MyBtn_Click;
        }

        private void MyBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.ShopEnterView.clientUserControl.Client = SetupClient1();
        }

        private List<Product> SetupProductList()
        {
            List<Product> result = new List<Product>();

            #region Products creation
            Product product1 = new Cold();
            product1.Id = 1;
            product1.Name = "product 1";
            product1.Price = new Decimal(10);
            result.Add(product1);

            Product product2 = new Consistant();
            product2.Id = 2;
            product2.Name = "product 2";
            product2.Price = new Decimal(20);
            result.Add(product2);

            Product product3 = new Fluid();
            product3.Id = 3;
            product3.Name = "product 3";
            product3.Price = new Decimal(30);
            result.Add(product3);

            Product product4 = new Hot();
            product4.Id = 4;
            product4.Name = "product 4";
            product4.Price = new Decimal(40);
            result.Add(product4);

            Product product5 = new Usefull();
            product5.Id = 5;
            product5.Name = "product 5";
            product5.Price = new Decimal(50);
            result.Add(product5);

            Product product6 = new Useless();
            product6.Id = 6;
            product6.Name = "product 6";
            product6.Price = new Decimal(60);
            result.Add(product6);

            Product product7 = new Usable();
            product7.Id = 7;
            product7.Name = "product 7";
            product7.Price = new Decimal(70);
            result.Add(product7);

            Product product8 = new Cold();
            product8.Id = 8;
            product8.Name = "product 8";
            product8.Price = new Decimal(80);
            result.Add(product8);

            Product product9 = new Cold();
            product9.Id = 9;
            product9.Name = "product 9";
            product9.Price = new Decimal(90);
            result.Add(product9);

            Product product10 = new Cold();
            product10.Id = 10;
            product10.Name = "product 10";
            product10.Price = new Decimal(100);
            result.Add(product10);
            #endregion

            return result;
        }

        private Product SetupProduct()
        {
            ConsoleApplication2.Shop.Product product = new Cold();
            product.Id = 1;
            product.Name = "Glace";
            product.Price = new Decimal(10);
            return product;
        }

        private ConsoleApplication2.Shop.Client SetupClient()
        {
            ConsoleApplication2.Shop.Client client = new ConsoleApplication2.Shop.Client();
            client.Id = 1;
            client.Name = "Jhon";
            client.Surname = "Roger";
            client.Money = new Decimal(120.68);
            return client;
        }

        private ConsoleApplication2.Shop.Client SetupClient1()
        {
            ConsoleApplication2.Shop.Client client = new ConsoleApplication2.Shop.Client();
            client.Id = 3;
            client.Name = "JhonJhonJhon";
            client.Surname = "Alladin";
            client.Money = new Decimal(12000000.68);
            return client;
        }
     
    }*/
}
