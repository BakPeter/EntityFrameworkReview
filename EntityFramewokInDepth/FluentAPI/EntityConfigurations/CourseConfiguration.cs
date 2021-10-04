using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.EntityConfigurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            //table names
            ToTable("tbl_Course");

            //keys
            HasKey(c => c.Id);

            //properties
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.Description)
               .IsRequired()
               .HasMaxLength(2000);

            //relations
            HasRequired(course => course.Author)
                .WithMany(auther => auther.Courses)
                .HasForeignKey(course => course.AuthorId)
                .WillCascadeOnDelete(false);

            HasMany(course => course.Tags)
                .WithMany(tag => tag.Courses)
                      .Map(m =>
                      {
                          m.ToTable("CourseTags");
                          m.MapLeftKey("TagId");
                          m.MapRightKey("CourseId");
                      });

            HasRequired(course => course.Cover)
                .WithRequiredPrincipal(course => course.Course);
        }
    }
}
