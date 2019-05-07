using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    public class Person
    {
        public Person (string name , int age)
        {
            Name = name;
            Age = age;
        }


        public string Name { set; get; }
        public int Age { set; get; }

        public void GetNameAndAge()
        {
            Console.WriteLine("The Person has name : {0} and age : {1}", Name, Age);
        }
    }
}
