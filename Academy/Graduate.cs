namespace Academy
{
    class Graduate : Student
    {
        public string Subject { get; set; }
        public Graduate
        (
            string lastName, string firstName, int age,
            string speciality, string group, double rating, double attendance,
            string subject
        ) : base(lastName, firstName, age, speciality, group, rating, attendance)
        {
            this.Subject = subject;
#if DEBUG
			Console.WriteLine($"GConstructor:\t{GetHashCode()}"); 
#endif
        }
        public Graduate(Student student, string subject) : base(student)
        {
            this.Subject = subject;
        }
        public Graduate(Graduate other) : base(other)
        {
            this.Subject = other.Subject;
        }
        ~Graduate()
        {
#if DEBUG
			Console.WriteLine($"GDestructor:\t{GetHashCode()}"); 
#endif
        }
        public override string ToString()
        {
            return base.ToString() + $" \"{Subject}\"";
        }
        public override string ToFileString()
        {
            return base.ToFileString() + $",{Subject}";
        }
        public override Human Init(string[] values)
        {
            base.Init(values);
            this.Subject = values[8];
            return this;
        }
    }
}