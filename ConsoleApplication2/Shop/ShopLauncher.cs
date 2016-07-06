using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Shop
{
    /// <summary>
    /// Use this to run Shop scenaries.
    /// </summary>
    public class ShopLauncher
    {
        static void Main(string[] args)
        {
            #region Object creation
            Shop shop = new Shop();
            shop.Id = 1;
            shop.Name = "My Grocerie";
            shop.Finance = new Decimal(1200);
            shop.Credit = new Decimal(1500);

            Client client1 = new Client();
            client1.Id = 1;
            client1.Money = new Decimal(100.20);
            client1.Name = "Eude";
            client1.Surname = "Jean";
            Address address1 = new Address();
            address1.Id = 1;
            address1.City = "Rennes";
            address1.Path = "Voie";
            address1.Way = "La guenardiere";
            address1.Number = "6";
            client1.Address = address1;
            shop.Clients.Add(client1);

            Client client2 = new Client();
            client2.Id = 2;
            client2.Money = new Decimal(50);
            client2.Name = "Marc";
            client2.Surname = "Jack";
            Address address2 = new Address();
            address2.Id = 2;
            address2.City = "Rennes";
            address2.Path = "Voie";
            address2.Way = "La guenardiere";
            address2.Number = "6";
            client2.Address = address2;
            shop.Clients.Add(client2);

            Client client3 = new Client();
            client3.Id = 3;
            client3.Money = new Decimal(30.80);
            client3.Name = "Ulé";
            client3.Surname = "Ivon";
            Address address3 = new Address();
            address3.Id = 3;
            address3.City = "Rennes";
            address3.Path = "Voie";
            address3.Way = "La guenardiere";
            address3.Number = "6";
            client3.Address = address3;
            shop.Clients.Add(client3);

            Owner owner = new Owner();
            owner.Id = 4;
            owner.Name = "Montant";
            owner.Surname = "Ive";
            Address address4 = new Address();
            address4.Id = 4;
            address4.City = "Rennes";
            address4.Path = "Voie";
            address4.Way = "La guenardiere";
            address4.Number = "6";
            owner.Address = address4;
            shop.Owners.Add(owner);

            #region Products creation
            Product product1 = new Cold();
            product1.Id = 1;
            product1.Name = "product 1";
            product1.Price = new Decimal(10);
            shop.Products.Add(product1);

            Product product2 = new Consistant();
            product2.Id = 2;
            product2.Name = "product 2";
            product2.Price = new Decimal(20);
            shop.Products.Add(product2);

            Product product3 = new Fluid();
            product3.Id = 3;
            product3.Name = "product 3";
            product3.Price = new Decimal(30);
            shop.Products.Add(product3);

            Product product4 = new Hot();
            product4.Id = 4;
            product4.Name = "product 4";
            product4.Price = new Decimal(40);
            shop.Products.Add(product4);

            Product product5 = new Usefull();
            product5.Id = 5;
            product5.Name = "product 5";
            product5.Price = new Decimal(50);
            shop.Products.Add(product5);

            Product product6 = new Useless();
            product6.Id = 6;
            product6.Name = "product 6";
            product6.Price = new Decimal(60);
            shop.Products.Add(product6);

            Product product7 = new Usable();
            product7.Id = 7;
            product7.Name = "product 7";
            product7.Price = new Decimal(70);
            shop.Products.Add(product7);

            Product product8 = new Cold();
            product8.Id = 8;
            product8.Name = "product 8";
            product8.Price = new Decimal(80);
            shop.Products.Add(product8);

            Product product9 = new Cold();
            product9.Id = 9;
            product9.Name = "product 9";
            product9.Price = new Decimal(90);
            shop.Products.Add(product9);

            Product product10 = new Cold();
            product10.Id = 10;
            product10.Name = "product 10";
            product10.Price = new Decimal(100);
            shop.Products.Add(product10);
            #endregion
            #endregion

            #region Print object in console
            //Console.WriteLine(shop);
            shop.PrintItemCategories();
            /*Console.WriteLine(owner);
            Console.WriteLine(product1);
            Console.WriteLine(product2);
            Console.WriteLine(product3);
            Console.WriteLine(product4);
            Console.WriteLine(product5);
            Console.WriteLine(product6);
            Console.WriteLine(product7);
            Console.WriteLine(product8);
            Console.WriteLine(product9);
            Console.WriteLine(product10);
            Console.WriteLine(client1);
            Console.WriteLine(client2);
            Console.WriteLine(client3);*/

            //shop.PrintItemCategories1();

            Console.ReadKey();
            #endregion
        }
    }
}
