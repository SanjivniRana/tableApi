namespace UsersProfile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class threetables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Country1",
                c => new
                    {
                        CountryID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CountryID);
            
            CreateTable(
                "dbo.State1",
                c => new
                    {
                        StateID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        CountryID = c.String(),
                    })
                .PrimaryKey(t => t.StateID);
            
            CreateTable(
                "dbo.UserInfo1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Country = c.String(),
                        State = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserInfo1", t => t.UserInfo_Id)
                .Index(t => t.UserInfo_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserViewModels", "UserInfo_Id", "dbo.UserInfo1");
            DropIndex("dbo.UserViewModels", new[] { "UserInfo_Id" });
            DropTable("dbo.UserViewModels");
            DropTable("dbo.UserInfo1");
            DropTable("dbo.State1");
            DropTable("dbo.Country1");
        }
    }
}
