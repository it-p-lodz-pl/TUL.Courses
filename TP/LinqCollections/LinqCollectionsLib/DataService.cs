using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCollectionsLib
{
    public class DataService
    {
        private List<Person> persons;

        public DataService()
        {
            persons = new List<Person>();
        }

        public void AddPerson(Person p)
        {
            persons.Add(p);
        }

        public Person[] GetAllPersons()
        {
            return persons.ToArray();
        }

        public Person[] FilterPersonsByLastName_ForEach(string lastName)
        {
            List<Person> result = new List<Person>();
            foreach (Person p in persons)
            {
                if (p.LastName.Equals(lastName))
                    result.Add(p);
            }
            return result.ToArray();
        }

        public Person[] FilterPersonsByLastName_ExtensionMethod(string lastName)
        {
            IEnumerable<Person> expr = persons.Where(
                /*Predicate*/
                (Person p) => { return p.LastName.Equals(lastName); }
            );
            return expr.ToArray();
        }

        public Person[] FilterPersonsByLastName(string lastName)
        {
            //System.Linq.Enumerable.WhereListIterator
            IEnumerable<Person> linq =
                from Person p in persons
                where p.LastName.Equals(lastName)
                select p;
            return linq.ToArray();
        }

        public IEnumerable<Person> FilterPersonsMinAge(int minAge)
        {
            IEnumerable<Person> linq =
                from Person p in persons
                where p.Age >= minAge
                select p;
            return linq.ToArray();
        }
    }
}
