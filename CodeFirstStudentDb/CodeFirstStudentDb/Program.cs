using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStudentDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var school = new SchoolContext())
            {
                var student = new Student()
                {
                    FirstName = "Adam",
                    LastName = "Clark",
                    DateOfBirth = new DateTime(2015, 6, 1, 7, 47, 0)
                };
                school.Students.Add(student);
                school.SaveChanges();
            }
        }
    }
}
