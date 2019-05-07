using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mika",20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Thomas",35,"190324","Math");        
            teacher.GetNameAndAge();

            Student student = new Student("Sara",19,"128425","sara12345@amikom.ac.id");
            student.GetNameAndAge();
            
            Console.ReadKey();


        }
    }
}
