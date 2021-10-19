using Newtonsoft.Json;
using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            var query =
                from c in context.Courses
                where c.Name.Contains("c#")
                orderby c.Name
                select c;

            foreach(var course in query)
            {
                Console.WriteLine(course.Name);
            }
            
            Console.WriteLine("==================================================");
            Console.WriteLine("==================================================");

            var courses = context.Courses
                .Where(c => c.Name.Contains("c#"))
                .OrderBy(c => c.Name)
                //.Select(c => new { CourseName = c.Name, AutherName = c.Author.Name });
                .Select(c => new ParsedData() { CourseName = c.Name, AutherName = c.Author.Name });
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
    
    class ParsedData
    {
        public static int s_flag = 1;

        public string CourseName { get; set; }
        public string AutherName { get; set; }
        public int Flag { get; set; } = s_flag++;
        public int Flag1 { get; set; } = s_flag++;
        public int Flag2 { get; set; } = s_flag++;
        public int Flag3 { get; set; } = s_flag++;

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
