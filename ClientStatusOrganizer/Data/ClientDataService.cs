using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientStatusOrganizer.Model;

namespace ClientStatusOrganizer.Data
{
    public class ClientDataService:IClientDataService
    {
        public IEnumerable<Client> GetAll()
        {
            //TODO:Load data from Database

            yield return new Client { ClientID = 9001,ClientName = "Juraj", ClientSurName = "Drobny",ClientBankStatus = 1254.32};
            yield return new Client { ClientID = 9002, ClientName = "Peter", ClientSurName = "Velky", ClientBankStatus = 2254.32 };
            yield return new Client { ClientID = 9003, ClientName = "Martin", ClientSurName = "Pekny", ClientBankStatus = 252.12 };
            yield return new Client { ClientID = 9004, ClientName = "Jozef", ClientSurName = "Stastny", ClientBankStatus = 3254.32 };

        }
    }
}
