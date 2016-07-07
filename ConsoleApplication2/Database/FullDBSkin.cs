using SnowRentLibrary.Entities;
using SnowRentLibrary.Enums;
using SnowRentLibrary.Shop;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowRentLibrary.Database
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    class FullDBSkin : DbContext
    {
       
        public DbSet<Client> DbSetClient { get; set; }

        public FullDBSkin(DataConnectionResource dataConnectionResource)
            : base(EnumString.GetStringValue(dataConnectionResource))
        {
            this.Database.CreateIfNotExists();
        }
    }
}