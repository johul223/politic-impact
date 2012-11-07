namespace PoliticImpact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CaseItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CaseItems", "Deadline", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CaseItems", "Deadline");
        }
    }
}
