using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemoV2
{
    public partial class Post
    {
        public int PostID { get; set; }
        public System.DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string UserEmail { get; set; }
    }

    public class BlogDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
