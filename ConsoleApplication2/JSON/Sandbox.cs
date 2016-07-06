using ConsoleApplication2.Shop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.JSON
{
    public class Sandbox
    {
        public void TestIt()
        {
            Client client = new Client().LoadSingleItem();
            //String convertClient = JsonConvert.SerializeObject(client);

            List<Client> client2 = new Client().LoadMultipleItems();
            String convertClient2 = JsonConvert.SerializeObject(client2);

            //Client clent1Revert = JsonConvert.DeserializeObject<Client>(convertClient);
            List<Client> client2Revert = JsonConvert.DeserializeObject<List<Client>>(convertClient2);

            //Client client3 = JsonConvert.DeserializeObject<Client>(convertClient);
            String text = "text";
        }
    }
}
