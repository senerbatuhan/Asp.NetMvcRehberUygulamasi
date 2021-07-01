namespace RehberUygulamasi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabloIsimleriGuncellendi : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Kisis", newName: "Kisiler");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Kisiler", newName: "Kisis");
        }
    }
}
