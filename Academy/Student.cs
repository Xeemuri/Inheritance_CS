using System;

namespace Academy
{
    class Student : AcademyMember
    {
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }
        public Student
        (
            string lastName, string firstName, int age,
            string speciality, string group, double rating, double attendance
        ) : base(lastName, firstName, age, speciality)
        {
            Group = group;
            Rating = rating;
            Attendance = attendance;
#if DEBUG
			Console.WriteLine($"SConstructor:\t{GetHashCode()}"); 
#endif
        }
        public Student(Student other) : base(other)
        {
            this.Group = other.Group;
            this.Rating = other.Rating;
            this.Attendance = other.Attendance;
        }
        public Student
        (
            Human human,
            string speciality,
            string group, double rating, double attendance
        ) : base(human, speciality)
        {
            this.Group = group;
            this.Rating = rating;
            this.Attendance = attendance;
        }
        ~Student()
        {
#if DEUBG
			Console.WriteLine($"SDestructor:\t{GetHashCode()}"); 
#endif
        }

        public override string ToString()
        {
            return
                base.ToString() +
                $"{Group.PadRight(8)}{Rating.ToString().PadLeft(8)}{Attendance.ToString().PadLeft(8)}";
        }
        public override string ToFileString()
        {
            return base.ToFileString() + $",{Group},{Rating},{Attendance}";
        }
        public override Human Init(string[] values)
        {
            base.Init(values);
            this.Group = values[5];
            this.Rating = Convert.ToDouble(values[6]);
            this.Attendance = Convert.ToDouble(values[7]);
            return this;
        }
    }
}