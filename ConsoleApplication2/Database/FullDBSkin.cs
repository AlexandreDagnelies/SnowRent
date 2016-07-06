using ConsoleApplication2.Enums;
using ConsoleApplication2.Shop;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Database
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
