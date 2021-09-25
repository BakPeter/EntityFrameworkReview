namespace CodeFirstDemoV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostsUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "UserEmail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "UserEmail");
        }
    }
}
