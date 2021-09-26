using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoDbFirst
{
    public enum MyLevelEnum : byte
    {
        FIRST = 1,
        SECOND = 2,
        THIRD = 3
    }

    class Program
    {    
        static void Main(string[] args)
        {
            var contextPluto = new PlutoDbContext();
            using(var courses= contextPluto.GetCourses())
            {
                foreach(var course in courses)
                {
                    Console.WriteLine(course.Title);
                }
            }
            Console.ReadLine();
        }
    }
}
