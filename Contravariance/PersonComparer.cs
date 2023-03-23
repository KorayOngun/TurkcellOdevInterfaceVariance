using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contravariance
{
    public class PersonComparer : IPersonComparer<Person>
    {
        public bool Compare(Person x, Person y)
        {
            return x.age > y.age;
        }
    }
}
