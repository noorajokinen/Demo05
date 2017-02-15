using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    /// <summary>
    /// This class holds person objects in a collection.
    /// </summary>
    class Persons
    {
        /// <summary>
        /// Collection to store person objects
        /// </summary>
        private List<Person> persons;

        /// <summary>
        /// Default constructor initilizes a collection
        /// </summary>
        public Persons()
        {
            persons = new List<Person>();
        }

        /// <summary>
        /// Add person to collection
        /// </summary>
        /// <param name="person">Person to add</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        /// <summary>
        /// Returns person to caller application
        /// </summary>
        /// <param name="index">index in collection</param>
        /// <returns>person objects or null</returns>

        public Person GetPerson(int index)
        {
            if (index < persons.Count)
                return persons.ElementAt(index);
            else return null;
        }

        public Person FindPerson(string socialSecurityNumber)
        {
            foreach(Person person in persons)
            {
                if (socialSecurityNumber.Equals(person.SocialSecurityNumber))
                {
                    return person;
                }
            }
            // no person with that socialsecuritynumber...
            return null;
        }

        public void PrintCollection()
        {
            foreach(Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
