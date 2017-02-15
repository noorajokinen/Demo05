using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a few person objects


            Person person1 = new Person { Firstname = "Kirsi", Lastname = "Kekkonen", SocialSecurityNumber = "947363-344" };

            Person person2 = new Person { Firstname = "Pekka", Lastname = "Kallio", SocialSecurityNumber = "403099-393" };

            Person person3 = new Person { Firstname = "Milla", Lastname = "Meilaaja", SocialSecurityNumber = "5555-55-5-5" };

            // create a Persons object

            Persons myfriens = new Persons();

            //add person objects to persons collection
            myfriens.AddPerson(person1);
            myfriens.AddPerson(person2);
            myfriens.AddPerson(person3);

            //get one person from Persons collection
            Person person4 = myfriens.GetPerson(100);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            } else
            {
                Console.WriteLine("Person not found in that index!");
            }

            //print collection
            myfriens.PrintCollection();

            //find person
            string sotu = "403099-33";
            Console.WriteLine("Find sotu: " + sotu);
            Person person5 = myfriens.FindPerson(sotu);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            } else
            {
                Console.WriteLine("Cant find person with that socialsecuritynumber");
            }

        }
    }
}
