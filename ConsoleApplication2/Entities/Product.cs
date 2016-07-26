using SnowRentLibrary.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SnowRentLibrary.Entities
{
    /// <summary>
    /// Describe an item that can be sold in a shop.
    /// </summary>

    [Table("products")]
    public class Product : EntityBase
    {
        #region Attributes

        private Int32 id;
        private Decimal price;
        private String name;
        #endregion
        #region Properties
        /// <summary>
        /// Id for of object in database.
        /// </summary>
        [Key]
        [Column("id")]
        public Int32 Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
                this.OnPropertyChanged("Id");
            }
        }

        /// <summary>
        /// Object name.
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
        /// Object cost all cost in it.
        /// </summary>
         [Column("price")]
        public Decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
                this.OnPropertyChanged("Price");
            }
        }
        #endregion
        #region Constructors

        #endregion
        #region Methods
        public override string ToString()
        {
            return this.name + " " + this.price;
        }
        #endregion
    }
}