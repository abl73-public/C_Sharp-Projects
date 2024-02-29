using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStudentDb
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Photo { get; set; }
        public double Height { get; set; }
        public float Weight { get; set; }
        public Grade Grade { get; set; }
    }
}
