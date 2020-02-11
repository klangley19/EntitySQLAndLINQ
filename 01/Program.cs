using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AdventureWorksEntityModel;

namespace _01
{
    class Program
    {

        static void Main(string[] args)
        {
            //Program.QueryContacts();
            Program.QueryContacts("Amy");
        }

        #region private static void QueryContacts()
        //private static void QueryContacts()
        //{
        //    List<Person> people = AdventureWorksEntities.GetAllPeople().ToList();
        //    foreach (var person in people)
        //    {
        //        Console.WriteLine("{0} {1}", person.FirstName.Trim(), person.LastName.Trim());
        //    }

        //    Console.Write("Press Enter...");
        //    Console.ReadLine();
        //}
        #endregion
        #region private static void QueryContacts(string firstName)
        private static void QueryContacts(string firstName)
        {
            List<Person> people = AdventureWorksEntities.GetPeopleByName(firstName).ToList();
            foreach (var person in people)
            {
                Console.WriteLine("{0} {1}", person.FirstName.Trim(), person.LastName.Trim());
            }

            Console.Write("Press Enter...");
            Console.ReadLine();
        }
        #endregion
        #region private static void QueryContacts(string firstName)
        //private static void QueryContacts(string firstName)
        //{
        //    List<string> names = AdventureWorksEntities.EntityClientQueryContacts(firstName);

        //    foreach (string name in names)
        //    {
        //        Console.WriteLine(name.Trim());
        //    }

        //    Console.Write("Press Enter...");
        //    Console.ReadLine();
        //}
        #endregion

    }
}
