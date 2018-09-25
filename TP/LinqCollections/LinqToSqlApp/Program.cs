using LinqToSqlLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqlApp
{
    class Program
    {
        static PersonService service = new PersonService();

        static void Main(string[] args)
        {
            Person[] all = service.GetAllPersons();
            Display("Everyone", all);

            Console.WriteLine();

            const string lastName = "Kowalski";
            const int minAge = 25;
            const int change = 20;

            Display("With last name '" + lastName + "'", service.FilterPersonsByLastName(lastName));

            Console.WriteLine();

            Display("After finishing studies", service.FilterPersonsMinAge(minAge));
            Display("Forward " + change + " years", service.ChangeAge_FilterPersonsMinAge(change, minAge));
            Display("And back " + change + " years", service.ChangeAge_FilterPersonsMinAge(-change, minAge));

            Console.ReadLine();
        }

        static void Display(string title, IEnumerable<Person> data)
        {
            Console.WriteLine("*** {0} ***", title);
            foreach (Person p in data)
            {
                Console.WriteLine("Person: {0} {1}, age {2}", p.FirstName, p.LastName, p.Age);
            }
        }
    }
}
