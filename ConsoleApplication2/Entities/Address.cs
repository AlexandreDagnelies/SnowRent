using SnowRentLibrary.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowRentLibrary.Entities
{
    /// <summary>
    /// An address.
    /// </summary>
     [Table("address")]
    public class Address : EntityBase
    {
        #region Attributes
        private Int32 id;
        private String city;
        private String path;
        private String way;
        private String number;

        #endregion
        #region Properties
        /// <summary>
        /// Database id.
        /// </summary>
        /// 
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
        /// City name.
        /// </summary>

        [Column("city")]
        public String City
        {
            get { return city; }
            set {
                city = value;
                this.OnPropertyChanged("City");
            }
        }

        /// <summary>
        /// Path type ("rue", "avenue", "chemin").
        /// </summary>

         [Column("path")]
        public String Path
        {
            get { return path; }
            set { path = value;
                this.OnPropertyChanged("Path");
            }
        }

        /// <summary>
        /// Name of the way.
        /// </summary>

         [Column("way")]
        public String Way
        {
            get { return way; }
            set { way = value;
                this.OnPropertyChanged("Way");
            }
        }

        /// <summary>
        /// Number of the address (can have letters => "Bis").
        /// </summary>

        [Column("number")]
        public String Number
        {
            get { return number; }
            set { number = value;
                this.OnPropertyChanged("Number");
            }
        }

        #endregion
        #region Constructors

        #endregion
        #region Methods
        public override string ToString()
        {
            return this.city + " " + this.path + " " + this.way + " " + this.number;
        }
        #endregion
    }
}
