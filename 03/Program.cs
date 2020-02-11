using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AdventureWorksEntityModel;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.QueryContacts("Amy");
        }

        private static void QueryContacts(string firstName)
        {
            //List<string> names = AdventureWorksEntities.GetPeopleByName(firstName).ToList();
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name.Trim());
            //}

            Console.Write("Press Enter...");
            Console.ReadLine();
        }

    }
}
