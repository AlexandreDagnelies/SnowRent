using ConsoleApplication2.MyFaker;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ConsoleApplication2.Shop
{
    /// <summary>
    /// Describe a client which is a user that buy product in a shop.
    /// </summary>

    [Table("clients")]
    public class Client : ShopUser
    {
        #region Attributes
        [Column("money")]
        private Decimal money;
        [Column("products")]
        private List<Product> products;
        #endregion
        #region Properties
        /// <summary>
        /// Money client have to buy stuff.
        /// </summary>
        /// 
      
        public Decimal Money
        {
            get
            {
                return this.money;
            }

            set
            {
                this.money = value;
                this.OnPropertyChanged("Money");
            }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value;
                this.OnPropertyChanged("Products");
            }
        }
        #endregion
        #region Constructors
        public Client()
        {
            this.products = new List<Product>();
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return base.ToString() + " " + this.money;
        }


       public new Client LoadSingleItem()
        {
            Client result = new Client();
            result.Id = Faker.NumberFaker.Number();
            result.Name = Faker.NameFaker.Name();
            return result;
        }

        public new List<Client> LoadMultipleItems()
        {
            List<Client> result = new List<Client>();
            for (int i = 0; i < Faker.NumberFaker.Number(3, 20); i++)
            {
                result.Add(LoadSingleItem());
            }
            return result;
        }
        #endregion

    }
}