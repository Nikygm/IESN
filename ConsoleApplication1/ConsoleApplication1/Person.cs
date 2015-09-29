using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person
    {
        private String name;
        private int age;

        public Person(String name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return Name + " âgée de " + Age + "ans\n";
        }
    }
}
