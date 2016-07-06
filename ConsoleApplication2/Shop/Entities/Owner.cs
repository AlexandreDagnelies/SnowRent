using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2.Shop
{
    /// <summary>
    /// Describe owner of a shot.
    /// </summary>
    public class Owner : ShopUser
    {
        #region Attributes

        #endregion
        #region Properties

        #endregion
        #region Constructors

        #endregion
        #region Methods
        public override string ToString()
        {
            return base.ToString();
        }
        public new Owner LoadSingleItem()
        {
            Owner result = new Owner();
            result.Id = Faker.NumberFaker.Number();
            result.Name = Faker.NameFaker.Name();
            return this;
        }

        public new List<Owner> LoadMultipleItems()
        {
            List<Owner> result = new List<Owner>();
            for (int i = 0; i < Faker.NumberFaker.Number(3, 20); i++)
            {
                result.Add(LoadSingleItem());
            }
            return result;
        }
        #endregion
    }
}