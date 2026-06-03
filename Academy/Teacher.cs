using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher : AcademyMember
    {
        public int Experience { get; set; }

        // Constructors:
        public Teacher
            (
                string lastName, string firstName, int age,
                string speciality, int experience
            ) : base(lastName, firstName, age, speciality)
        {
            Experience = experience;
            Console.WriteLine($"TConstructor:\t{GetHashCode()}");
        }
        ~Teacher()
        {
            Console.WriteLine($"TDestructor:\t{GetHashCode()}");
        }
        public override string ToString()
        {
            return base.ToString() + $"  {Experience}";
        }
    }
}
