namespace ContactsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhonePrimary = c.String(),
                        PhoneSecondary = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        StreetAdd = c.String(),
                        StreetAdd2 = c.String(),
                        City = c.String(),
                        state = c.String(),
                        zip = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
