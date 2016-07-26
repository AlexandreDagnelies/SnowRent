using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Views.Pages;

namespace WpfApplication1.ViewModel
{
    public class AddressViewModel
    {
        private AddressView addressView;

        public AddressView AddressView
        {
            get { return addressView; }
            set { addressView = value; }
        }

         //constructeur
        public AddressViewModel(AddressView addressView)
        {
            this.addressView = addressView;
            /*
          
            this.customersView.clientsListUserControl.LoadItems(SetupClientList());
            this.SetupClientList();
            this.Populate();
            */
        }
        /*
        private async void Populate()
        {
           
        }*/
      

       
    }
}
