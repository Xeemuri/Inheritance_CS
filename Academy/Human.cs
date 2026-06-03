//#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Human(string lastName, string firstName, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
#if DEBUG
            Console.WriteLine($"HConstructor:\t{GetHashCode()}"); 
#endif
        }
        ~Human()
        {
#if DEBUG
            Console.WriteLine($"HDestructor:\t{GetHashCode()}"); 
#endif
        }

        //              Methods:
        public void Info()
        {
            Console.WriteLine($"{LastName} {FirstName} {Age}");
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{LastName} {FirstName} {Age}";
        }
    }
}
