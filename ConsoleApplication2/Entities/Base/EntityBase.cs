using SnowRentLibrary.MyFaker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowRentLibrary.Entities
{
    public class EntityBase : INotifyPropertyChanged, IFakerLoader<EntityBase>
    {
        private int id;

        [Key]
        [Column("id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public EntityBase LoadSingleItem()
        {
            EntityBase result = new EntityBase();
            result.Id = Faker.NumberFaker.Number();
            return this;
        }

        public List<EntityBase> LoadMultipleItems()
        {
            List<EntityBase> result = new List<EntityBase>();
            for (int i = 0; i < Faker.NumberFaker.Number(3, 20); i++)
            {
                result.Add(LoadSingleItem());
            }
            return result;
        }
    }
}
