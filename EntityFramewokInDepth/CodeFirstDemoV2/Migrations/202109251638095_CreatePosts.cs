namespace CodeFirstDemoV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePosts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        DatePublished = c.DateTime(nullable: false),
                        Title = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.PostID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}
