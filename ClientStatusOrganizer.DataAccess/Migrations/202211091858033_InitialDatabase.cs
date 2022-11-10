namespace ClientStatusOrganizer.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        ClientID = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        ClientSurName = c.String(),
                        ClientBankStatus = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ClientID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Client");
        }
    }
}
