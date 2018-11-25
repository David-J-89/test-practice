namespace Mvc5Project.Migrations.BlogDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Blog : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Category", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Post", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Post", "ShortDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Post", "Meta", c => c.String(nullable: false));
            AlterColumn("dbo.Comment", "Body", c => c.String(nullable: false));
            AlterColumn("dbo.Reply", "Body", c => c.String(nullable: false));
            AlterColumn("dbo.Tag", "UrlSeo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tag", "UrlSeo", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Reply", "Body", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Comment", "Body", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Post", "Meta", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Post", "ShortDescription", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Post", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Category", "Description", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
