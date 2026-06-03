using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class AcademyMember: Human
    {
        public string Speciality { get; set; }
        public AcademyMember
            (
            string lastName, string firstName, int age,
            string speciality
            ) : base(lastName, firstName, age)
        {
            Speciality = speciality;
        }
        ~AcademyMember()
        {
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality}";
        }
    }
}
