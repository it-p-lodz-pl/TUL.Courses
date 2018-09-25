using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCollectionsLib
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Age { get; set; }

        public Person()
        {
        }

        public Person(string firstName, string lastName, uint age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
