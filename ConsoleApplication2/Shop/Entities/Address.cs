using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Shop
{
    /// <summary>
    /// An address.
    /// </summary>
    public class Address : EntityBase
    {
        #region Attributes
        //private Int32 id;
        private String city;
        private String path;
        private String way;
        private String number;

        #endregion
        #region Properties
        /// <summary>
        /// Database id.
        /// </summary>
        //public Int32 Id
        //{
        //    get
        //    {
        //        return this.id;
        //    }

        //    set
        //    {
        //        this.id = value;
        //        this.OnPropertyChanged("Id");
        //    }
        //}

        /// <summary>
        /// City name.
        /// </summary>
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
