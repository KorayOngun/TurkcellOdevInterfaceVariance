using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contravariance
{
    public class Person
    {
        public int age;
        public Person()
        {
            age = new Random().Next(18,55);
        }
        public string Name { get; set; }
        
    }
}
