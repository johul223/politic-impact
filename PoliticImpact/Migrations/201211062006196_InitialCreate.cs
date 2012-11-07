namespace PoliticImpact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CaseItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Owner = c.Long(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        Text = c.String(nullable: false),
                        Published = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Deadline = c.DateTime(nullable: false),
                        LastEdited = c.DateTime(nullable: false),
                        imageId = c.Int(nullable: false),
                        imageBytes = c.Binary(),
                        imageName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CaseItems");
        }
    }
}
