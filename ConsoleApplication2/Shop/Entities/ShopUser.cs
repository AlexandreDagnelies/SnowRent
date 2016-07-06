using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ConsoleApplication2.Shop
{
    /// <summary>
    /// Define globaly a shop user it will be a Client or an Owner.
    /// </summary>
    [Table("clients")]
    public abstract class ShopUser : EntityBase
    {
        #region Attributes
        //private Int32 id;
        private String name;
        private String surname;
        private Address address;
        #endregion
        #region Properties
        /// <summary>
        /// Database id.
        /// </summary>
       //[Column("id")]
       //public Int32 Id
       // {
       //     get
       //     {
       //         return this.id;
       //     }

       //     set
       //     {
       //         this.id = value;
       //         this.OnPropertyChanged("Id");
       //     }
       // }

        /// <summary>
        /// Name of a shop user (Client or Owner).
        /// </summary>
        [Column("name")]
        public String Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
                this.OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Surname of a shop user (Client or Owner).
        /// </summary>
        [Column("surname")]
        public String Surname
        {
            get
            {
                return this.surname;
            }

            set
            {
                this.surname = value;
                this.OnPropertyChanged("Surname");
            }
        }

        /// <summary>
        /// Define the address of a shop user.
        /// </summary>
        [Column("address")]
        public Address Address
        {
            get { return address; }
            set { address = value;
                this.OnPropertyChanged("Address");
            }
        }
        #endregion
        #region Constructors

        #endregion
        #region Methods
        public override string ToString()
        {
            return this.name + " " + this.surname + " " + this.address;
        }
        #endregion
    }
}