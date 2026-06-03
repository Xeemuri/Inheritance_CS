using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Henriksson", "Martin", 35);
            //human.Info();
            Console.WriteLine(human);

            Student student = new Student("Pinkman", "Jesse", 22, "Chemistry", "CS-01", 90, 95);
            Console.WriteLine(student);
            Teacher teacher = new Teacher
                (
                    "White", "Walter", 50,
                    "Chemistry", 25
                );
            Console.WriteLine(teacher);
        }
    }
}
