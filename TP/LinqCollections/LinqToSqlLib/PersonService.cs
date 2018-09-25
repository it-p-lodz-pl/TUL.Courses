using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqlLib
{
    public class PersonService : IDisposable
    {
        private PersonsDataContext context;

        public PersonService()
        {
            context = new PersonsDataContext();
        }

        public Person[] GetAllPersons()
        {
            return context.Persons.ToArray();
        }

        public Person[] FilterPersonsByLastName(string lastName)
        {
            IQueryable<Person> linq =
                from Person p in context.Persons
                where p.LastName.Equals(lastName)
                select p;
            return linq.ToArray();
        }

        public IEnumerable<Person> FilterPersonsMinAge(int minAge)
        {
            IQueryable<Person> linq =
                from Person p in context.Persons
                where p.Age >= minAge
                select p;
            return linq.ToList();
        }

        public IEnumerable<Person> ChangeAge_FilterPersonsMinAge(int change, int minAge)
        {
            IQueryable<Person> linq =
                from Person p in context.Persons
                where p.Age >= minAge
                select p;

            foreach (Person p in context.Persons)
            {
                p.Age = p.Age + change;
                context.SubmitChanges();
            }

            return linq.ToList();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects).
                    context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~PersonService() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
