using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PersonComparer : IEqualityComparer<Person>
    {
        public Boolean Equals(Person p,Person q);
        public int GetHashCode(Person p);

    }
}
