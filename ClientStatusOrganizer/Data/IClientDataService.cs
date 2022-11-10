using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientStatusOrganizer.Model;

namespace ClientStatusOrganizer.Data
{
    public interface IClientDataService
    {
        IEnumerable<Client> GetAll();
    }
}
 