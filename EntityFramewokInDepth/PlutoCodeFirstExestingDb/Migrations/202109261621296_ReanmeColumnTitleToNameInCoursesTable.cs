namespace PlutoCodeFirstExestingDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class ReanmeColumnTitleToNameInCoursesTable : DbMigration
    {
        public override void Up()
        {
            //1
            AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            Sql("Update Courses SET Name=Title");
            DropColumn("dbo.Courses", "Title");

            //2
            //RenameColumn("dbo.Courses", "Title", "Name");
        }

        public override void Down()
        {
            //1
            AddColumn("dbo.Courses", "Title", c => c.String(nullable: false));
            Sql("Update Courses SET Title=Name");
            DropColumn("dbo.Courses", "Name");

            //2
            //RenameColumn("dbo.Courses", "Name", "Title");
        }
    }
}
