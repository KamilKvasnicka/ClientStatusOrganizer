using ClientStatusOrganizer.Model;

namespace ClientStatusOrganizer.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClientStatusOrganizer.DataAccess.ClientStatusOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ClientStatusOrganizer.DataAccess.ClientStatusOrganizerDbContext context)
        {
            context.Clients.AddOrUpdate(
            f => f.ClientName,
            new Client { ClientID = 9001, ClientName = "Juraj", ClientSurName = "Drobny", ClientBankStatus = 1254.32 },
            new Client { ClientID = 9002, ClientName = "Peter", ClientSurName = "Velky", ClientBankStatus = 2254.32 },
            new Client { ClientID = 9003, ClientName = "Martin", ClientSurName = "Pekny", ClientBankStatus = 252.12 },
            new Client { ClientID = 9004, ClientName = "Jozef", ClientSurName = "Stastny", ClientBankStatus = 3254.32 }
                );
        }
    }
}
