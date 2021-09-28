namespace PlutoCodeFirstExestingDb.Migrations
{
    using System;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PlutoCodeFirstExestingDb.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlutoCodeFirstExestingDb.PlutoContext context)
        {
            context.Authors.AddOrUpdate(a => a.Name,
                new Author()
                {
                    Name = "Peter",
                    Courses = new Collection<Course>()
                    {
                        new Course()
                        {
                            Name="special course",
                            Description="very very special course"
                        }
                    },
                },
                new Author()
                {
                    Name = "egfefe",
                    Courses = new Collection<Course>()
                    {
                        new Course()
                        {
                            Name="special course",
                            Description="very very special course"
                        }
                    },
                },
                new Author()
                {
                    Name = "Pefefeeter",
                    Courses = new Collection<Course>()
                    {
                        new Course()
                        {
                            Name="special course",
                            Description="very very special course"
                        }
                    },
                });
        }
    }
}
