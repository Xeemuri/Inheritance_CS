namespace Academy
{
    class AcademyMember : Human
    {
        public string Speciality { get; set; }
        public AcademyMember
        (
            string lastName, string firstName, int age,
            string speciality
        ) : base(lastName, firstName, age)
        {
            this.Speciality = speciality;
        }
        public AcademyMember(AcademyMember other) : base(other)
        {
            this.Speciality = other.Speciality;
        }
        public AcademyMember(Human human, string speciality) : base(human)
        {
            this.Speciality = speciality;
        }
        ~AcademyMember()
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"{Speciality.PadRight(22)}";
        }
        public override string ToFileString()
        {
            return base.ToFileString() + $",{Speciality}";
        }
        public override Human Init(string[] values)
        {
            base.Init(values);
            this.Speciality = values[4];
            return this;
        }
    }
}