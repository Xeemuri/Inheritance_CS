using System;

namespace Academy
{
    class Teacher : AcademyMember
    {
        public int Experience { get; set; }

        //			Constructors:
        public Teacher
        (
            string lastName, string firstName, int age,
            string speciality, int experience
        ) : base(lastName, firstName, age, speciality)
        {
            this.Experience = experience;
#if DEBUG
			Console.WriteLine($"TConstructor:\t{GetHashCode()}"); 
#endif
        }
        ~Teacher()
        {
#if DEBUG
			Console.WriteLine($"TDestructor:\t{GetHashCode()}"); 
#endif
        }

        public override string ToString()
        {
            return base.ToString() + $"{Experience.ToString().PadLeft(3).PadRight(4)}";
        }
        public override string ToFileString()
        {
            return base.ToFileString() + $",{Experience}";
        }
        public override Human Init(string[] values)
        {
            base.Init(values);
            this.Experience = Convert.ToInt32(values[5]);
            return this;
        }
    }
}