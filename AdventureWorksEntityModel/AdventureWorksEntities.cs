using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksEntityModel
{
    public partial class AdventureWorksEntities
    {
        #region Console Application 01 callable methods
        #region public static IEnumerable<Person> GetAllPeople()
        //public static IEnumerable<Person> GetAllPeople()
        //{
        //    using (var context = new AdventureWorksEntities())
        //    {
        //        return context.People.ToList();
        //    }
        //}
        #endregion
        #region public static IEnumerable<Person> GetPeopleByName(string firstName)
        //public static IEnumerable<Person> GetPeopleByName(string firstName)
        //{
        //    using (var context = new AdventureWorksEntities())
        //    {
        //        List<Person> people = 
        //            (
        //                from c in context.People
        //                where c.FirstName == firstName
        //                select c
        //            ).ToList();

        //        return people;
        //    }
        //}
        #endregion
        #region public static IEnumerable<Person> GetPeopleByName(string firstName)
        //public static IEnumerable<Person> GetPeopleByName(string firstName)
        //{
        //    using (var context = new AdventureWorksEntities())
        //    {

        //        string query = "SELECT VALUE p " +
        //                       "FROM AdventureWorksEntities.People AS p " +
        //                       "WHERE p.FirstName = '" + firstName + "'";

        //        var result = ((IObjectContextAdapter)context).ObjectContext.CreateQuery<Person>(query);

        //        return result.ToList();
        //    }
        //}
        #endregion
        #region public static IEnumerable<Person> GetPeopleByName(string firstName)
        //public static IEnumerable<Person> GetPeopleByName(string firstName)
        //{
        //    using (var context = new AdventureWorksEntities())
        //    {

        //        string query = "SELECT VALUE p " +
        //                       "FROM AdventureWorksEntities.People AS p " +
        //                       "WHERE p.FirstName = @firstName";

        //        ObjectQuery<Person> people = new ObjectQuery<Person>(query, ((IObjectContextAdapter)context).ObjectContext);
        //        people.Parameters.Add(new ObjectParameter("firstName", firstName));

        //        return people.ToList();
        //    }
        //}
        #endregion
        #region public static IEnumerable<Person> GetPeopleByName(string firstName)
        //public static IEnumerable<Person> GetPeopleByName(string firstName)
        //{
        //    using (var context = new AdventureWorksEntities())
        //    {
        //        var people = 
        //            context.People
        //            .Where((c) => c.FirstName == firstName)
        //            .OrderBy(c => c.LastName);

        //        return people.ToList();
        //    }
        //}
        #endregion
        #region public static List<string> EntityClientQueryContacts(string firstName)
        //public static List<string> EntityClientQueryContacts(string firstName)
        //{
        //    List<string> names = new List<string>();

        //    using (EntityConnection conn = new EntityConnection("name=AdventureWorksEntities"))
        //    {
        //        conn.Open();

        //        var queryString = 
        //            "SELECT VALUE p " +
        //            "FROM AdventureWorksEntities.People AS p " +
        //            "WHERE p.FirstName='" + firstName + "'";

        //        EntityCommand cmd = conn.CreateCommand();
        //        cmd.CommandText = queryString;
        //        using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
        //        {
        //            while (rdr.Read())
        //            {
        //                var titleDB = rdr[3];
        //                var firstNameDB = rdr[4];
        //                var middleNameDB = rdr[5];
        //                var lastNameDB = rdr[6];

        //                string fullName = AdventureWorksEntities.FormFullName(titleDB, firstNameDB, middleNameDB, lastNameDB);
        //                names.Add(fullName);
        //            }
        //        }

        //        conn.Close();

        //        return names;
        //    }
        //}
        #endregion
        #region public static IEnumerable<Person> GetPeopleByName(string firstName)
        public static IEnumerable<Person> GetPeopleByName(string firstName)
        {
            using (var context = new AdventureWorksEntities())
            {
                #region working code commented out
                //var people =
                //    ((IObjectContextAdapter)context).ObjectContext.CreateObjectSet<Person>()
                //    .Where((c) => c.FirstName == firstName)
                //    .OrderBy(c => c.LastName);

                //var people =
                //    ((IObjectContextAdapter)context).ObjectContext.CreateObjectSet<Person>()
                //    .Where(p.FirstName = '" + firstName + "'")
                //    .OrderBy(c => c.LastName);

                //var people =
                //    ((IObjectContextAdapter)context).ObjectContext.CreateObjectSet<Person>()
                //    .Where("it.FirstName = 'Amy'")
                //    .OrderBy(c => c.LastName);
                #endregion

                var people =
                    ((IObjectContextAdapter)context).ObjectContext.CreateObjectSet<Person>()
                    .Where("it.FirstName = '" + firstName + "'")
                    .OrderBy(c => c.LastName);


                return people.ToList();
            }
        }
        #endregion
        #endregion
        #region Console Application 02 callable methods
        #region public static List<string> GetPeopleNamesWithProjection(string firstName)
        //public static List<string> GetPeopleNamesWithProjection(string firstName)
        //{
        //    List<string> names = new List<string>();

        //    using (var context = new AdventureWorksEntities())
        //    {
        //        var people =
        //            (
        //                from p in context.People
        //                where p.FirstName == firstName
        //                orderby p.LastName
        //                select new { p.Title, p.FirstName, p.MiddleName, p.LastName }
        //            ).ToList();

        //        foreach (var person in people)
        //        {
        //            string name = AdventureWorksEntities.FormFullName(person.Title, person.FirstName, person.MiddleName, person.LastName);
        //            names.Add(name);
        //        }

        //        return names;
        //    }
        //}
        #endregion
        #region public static List<string> GetPeopleNamesWithProjection(string firstName)
        //public static List<string> GetPeopleNamesWithProjection(string firstName)
        //{
        //    List<string> names = new List<string>();

        //    using (var context = new AdventureWorksEntities())
        //    {
        //        var people = 
        //            context.People
        //                .Where(p => p.FirstName == firstName)
        //                .OrderBy(p => p.LastName)
        //                .Select(p => new { p.Title, p.FirstName, p.MiddleName, p.LastName });

        //        foreach (var person in people)
        //        {
        //            string name = AdventureWorksEntities.FormFullName(person.Title, person.FirstName, person.MiddleName, person.LastName);
        //            names.Add(name);
        //        }

        //        return names;
        //    }
        //}
        #endregion
        #region public static List<string> GetPeopleAndAddressInformation(string firstName)
        //public static List<string> GetPeopleAndAddressInformation(string firstName)
        //{
        //    List<string> result = new List<string>();

        //    using (var context = new AdventureWorksEntities())
        //    {
        //        #region working code commented out
        //        //List<Person> lstPersons = context.People.Where(p => p.FirstName == firstName).ToList();
        //        //List<BusinessEntity> lstBusinessEntities = lstPersons.Select(be => be.BusinessEntity).ToList();
        //        //List<BusinessEntityAddress> lstBusinessEntityAddresses = lstBusinessEntities.SelectMany(bea => bea.BusinessEntityAddresses).ToList();
        //        //List<Address> lstAddresses = lstBusinessEntityAddresses.Select(a => a.Address).ToList();
        //        #endregion

        //        List<Person> lstPersons = context.People.Where(p => p.FirstName == firstName).ToList();
        //        foreach (Person p in lstPersons)
        //        {
        //            result.Add(AdventureWorksEntities.FormFullName(p.Title, p.FirstName, p.MiddleName, p.LastName));
        //            foreach (BusinessEntityAddress bea in p.BusinessEntity.BusinessEntityAddresses.ToList())
        //            {
        //                result.Add(FormFullAddress(bea.Address));
        //            }
        //        }

        //        return result;
        //    }
        //}
        #endregion
        #region public static List<string> GetPeopleAndAddressInformation(string firstName)
        //public static List<string> GetPeopleAndAddressInformation(string firstName)
        //{
        //    List<string> result = new List<string>();

        //    using (var context = new AdventureWorksEntities())
        //    {
        //        #region working code commented out
        //        //List<Person> lstPersons = context.People.Where(p => p.FirstName == firstName).ToList();
        //        //List<BusinessEntity> lstBusinessEntities = lstPersons.Select(be => be.BusinessEntity).ToList();
        //        //List<BusinessEntityAddress> lstBusinessEntityAddresses = lstBusinessEntities.SelectMany(bea => bea.BusinessEntityAddresses).ToList();
        //        //List<Address> lstAddresses = lstBusinessEntityAddresses.Select(a => a.Address).ToList();
        //        #endregion
        //        #region working code commented out
        //        //List<Person> lstPersons = context.People.Where(p => p.FirstName == firstName).ToList();
        //        //foreach (Person p in lstPersons)
        //        //{
        //        //    result.Add(AdventureWorksEntities.FormFullName(p.Title, p.FirstName, p.MiddleName, p.LastName));
        //        //    foreach (BusinessEntityAddress bea in p.BusinessEntity.BusinessEntityAddresses.ToList())
        //        //    {
        //        //        result.Add(FormFullAddress(bea.Address));
        //        //    }
        //        //}
        //        #endregion

        //        List<Person> lstPersons = context.People.Where(p => p.FirstName == firstName).ToList();
        //        List<BusinessEntityAddress> lstBusinessEntityAddresses = context.BusinessEntityAddresses.ToList();
        //        List<Address> lstAddresses = context.Addresses.ToList();

        //        var query = from person in lstPersons
        //                    join businessEntityAddress in lstBusinessEntityAddresses on person.BusinessEntityID equals businessEntityAddress.BusinessEntityID
        //                    join address in lstAddresses on businessEntityAddress.AddressID equals address.AddressID
        //                    select new { Title = person.Title, FirstName = person.FirstName, MiddleName = person.MiddleName, LastName = person.LastName, AddressLineOne = address.AddressLine1, AddressLineTwo = address.AddressLine2, City = address.City };

        //        foreach (var person in query)
        //        {
        //            result.Add(AdventureWorksEntities.FormFullName(person.Title, person.FirstName, person.MiddleName, person.LastName));
        //            result.Add(person.AddressLineOne);
        //            result.Add(person.City);
        //            result.Add(Environment.NewLine);
        //        }

        //        return result;
        //    }
        //}
        #endregion
        #region public static List<string> GetPeopleAndAddressInformation(string firstName)
        //public static List<string> GetPeopleAndAddressInformation(string firstName)
        //{
        //    List<string> result = new List<string>();

        //    using (var context = new AdventureWorksEntities())
        //    {
        //        #region working code commented out
        //        //List<Person> lstPersons = context.People.Where(p => p.FirstName == firstName).ToList();
        //        //List<BusinessEntity> lstBusinessEntities = lstPersons.Select(be => be.BusinessEntity).ToList();
        //        //List<BusinessEntityAddress> lstBusinessEntityAddresses = lstBusinessEntities.SelectMany(bea => bea.BusinessEntityAddresses).ToList();
        //        //List<Address> lstAddresses = lstBusinessEntityAddresses.Select(a => a.Address).ToList();
        //        #endregion
        //        #region working code commented out
        //        //List<Person> lstPersons = context.People.Where(p => p.FirstName == firstName).ToList();
        //        //foreach (Person p in lstPersons)
        //        //{
        //        //    result.Add(AdventureWorksEntities.FormFullName(p.Title, p.FirstName, p.MiddleName, p.LastName));
        //        //    foreach (BusinessEntityAddress bea in p.BusinessEntity.BusinessEntityAddresses.ToList())
        //        //    {
        //        //        result.Add(FormFullAddress(bea.Address));
        //        //    }
        //        //}
        //        #endregion
        //        #region working code commented out
        //        //List<Person> lstPersons = context.People.Where(p => p.FirstName == firstName).ToList();
        //        //List<BusinessEntityAddress> lstBusinessEntityAddresses = context.BusinessEntityAddresses.ToList();
        //        //List<Address> lstAddresses = context.Addresses.ToList();

        //        //var query = from person in lstPersons
        //        //            join businessEntityAddress in lstBusinessEntityAddresses on person.BusinessEntityID equals businessEntityAddress.BusinessEntityID
        //        //            join address in lstAddresses on businessEntityAddress.AddressID equals address.AddressID
        //        //            select new { Title = person.Title, FirstName = person.FirstName, MiddleName = person.MiddleName, LastName = person.LastName, AddressLineOne = address.AddressLine1, AddressLineTwo = address.AddressLine2, City = address.City };
        //        #endregion

        //        var query = from p in context.People
        //                    join bea in context.BusinessEntityAddresses on p.BusinessEntityID equals bea.BusinessEntityID
        //                    join a in context.Addresses on bea.AddressID equals a.AddressID
        //                    where p.FirstName == firstName
        //                    select new { Title = p.Title, FirstName = p.FirstName, MiddleName = p.MiddleName, LastName = p.LastName, AddressLineOne = a.AddressLine1, AddressLineTwo = a.AddressLine2, City = a.City };


        //        foreach (var person in query)
        //        {
        //            result.Add(AdventureWorksEntities.FormFullName(person.Title, person.FirstName, person.MiddleName, person.LastName));
        //            result.Add(person.AddressLineOne);
        //            result.Add(person.City);
        //            result.Add(Environment.NewLine);
        //        }

        //        return result;
        //    }
        //}
        #endregion
        #region public static List<string> GetPeopleAndAddressInformation(string firstName)
        //public static List<string> GetPeopleAndAddressInformation(string firstName)
        //{
        //    List<string> result = new List<string>();

        //    using (var context = new AdventureWorksEntities())
        //    {
        //        #region working code commented out
        //        //List<Person> lstPersons = context.People.Where(p => p.FirstName == firstName).ToList();
        //        //List<BusinessEntity> lstBusinessEntities = lstPersons.Select(be => be.BusinessEntity).ToList();
        //        //List<BusinessEntityAddress> lstBusinessEntityAddresses = lstBusinessEntities.SelectMany(bea => bea.BusinessEntityAddresses).ToList();
        //        //List<Address> lstAddresses = lstBusinessEntityAddresses.Select(a => a.Address).ToList();
        //        #endregion

        //        var people = from p in context.People
        //                     .Include("BusinessEntity.BusinessEntityAddresses.Address")
        //                     .Where(p => p.FirstName == firstName).ToList()
        //                     select p;

        //        foreach (Person p in people)
        //        {
        //            result.Add(AdventureWorksEntities.FormFullName(p.Title, p.FirstName, p.MiddleName, p.LastName));
        //            foreach (BusinessEntityAddress bea in p.BusinessEntity.BusinessEntityAddresses.ToList())
        //            {
        //                result.Add(FormFullAddress(bea.Address));
        //            }
        //        }

        //        return result;
        //    }
        //}
        #endregion
        #region public static List<string> GetPeopleAndAddressInformation(string firstName)
        //public static List<string> GetPeopleAndAddressInformation(string firstName)
        //{
        //    List<string> result = new List<string>();

        //    using (var context = new AdventureWorksEntities())
        //    {
        //        List<Person> lstPersons = context.People.Where(p => p.FirstName == firstName).ToList();
        //        List<BusinessEntity> lstBusinessEntities = lstPersons.Select(be => be.BusinessEntity).ToList();
        //        List<BusinessEntityAddress> lstBusinessEntityAddresses = lstBusinessEntities.SelectMany(bea => bea.BusinessEntityAddresses).ToList();
        //        List<Address> lstAddresses = lstBusinessEntityAddresses.Select(a => a.Address).ToList();

        //        foreach (Person p in lstPersons)
        //        {
        //            result.Add(AdventureWorksEntities.FormFullName(p.Title, p.FirstName, p.MiddleName, p.LastName));
        //            foreach (BusinessEntityAddress bea in p.BusinessEntity.BusinessEntityAddresses)
        //            {
        //                result.Add(AdventureWorksEntities.FormFullAddress(bea.Address));
        //            }
        //        }

        //        return result;
        //    }
        //}
        #endregion


        #region public static List<string> GetProductCategoriesAndProductSubcategoriesWithProjection()
        //public static List<string> GetProductCategoriesAndProductSubcategoriesWithProjection()
        //{
        //    List<string> results = new List<string>();

        //    using (var context = new AdventureWorksEntities())
        //    {
        //        var productCategories =
        //            (
        //                from pc in context.ProductCategories
        //                orderby pc.Name
        //                select new { pc.Name, pc.ProductSubcategories }
        //            ).ToList();

        //        foreach (var productCategory in productCategories)
        //        {
        //            string name = productCategory.Name;
        //            results.Add(name);
        //            foreach (var productSubCategory in productCategory.ProductSubcategories.OrderBy(psc => psc.Name))
        //            {
        //                results.Add("\t" + productSubCategory.ToString());
        //            }
        //        }

        //        return results;
        //    }
        //}
        #endregion
        #region public static List<string> GetProductCategoriesAndProductSubcategoriesWithProjectionShaped()
        //public static List<string> GetProductCategoriesAndProductSubcategoriesWithProjectionShaped()
        //{
        //    List<string> results = new List<string>();

        //    using (var context = new AdventureWorksEntities())
        //    {
        //        var productCategories =
        //            (
        //                from pc in context.ProductCategories
        //                orderby pc.Name
        //                select new { pc.Name, ProductSubcategories = from psc in pc.ProductSubcategories
        //                                                             orderby psc.Name
        //                                                             select new { psc.Name }
        //                           }
        //            ).ToList();

        //        foreach (var productCategory in productCategories)
        //        {
        //            string name = productCategory.Name;
        //            results.Add(name);
        //            foreach (var productSubCategory in productCategory.ProductSubcategories)
        //            {
        //                results.Add("\t" + productSubCategory.Name.ToString());
        //            }
        //        }

        //        return results;
        //    }
        //}
        #endregion
        #region public static List<string> GetProductCategoriesAndProductSubcategoriesWithProjectionFlattened()
        //public static List<string> GetProductCategoriesAndProductSubcategoriesWithProjectionFlattened()
        //{
        //    List<string> results = new List<string>();

        //    using (var context = new AdventureWorksEntities())
        //    {
        //        var productSubcategories =
        //            (
        //                from psc in context.ProductSubcategories
        //                orderby psc.ProductCategory.Name
        //                select new
        //                {
        //                    ProductCategory = psc.ProductCategory.Name,
        //                    ProductSubCategory = psc.Name
        //                }
        //            ).ToList();

        //        foreach (var psc in productSubcategories)
        //        {
        //            string line = "Product Sub Category :: " + psc.ProductSubCategory + "\t Product Category :: " + psc.ProductCategory;
        //            results.Add(line);
        //        }

        //        return results;
        //    }
        //}
        #endregion
        #endregion

        #region Cosole Application 03 callable methods
        #region public static IEnumerable<Person> GetPeopleByName(string firstName)
        //public static IEnumerable<string> GetPeopleByName(string firstName)
        //{
        //    List<string> returnValue = new List<string>();

        //    using (var context = new AdventureWorksEntities())
        //    {

        //        string query = "SELECT p.Title, p.FirstName, p.MiddleName, p.LastName " +
        //                       "FROM AdventureWorksEntities.People AS p " +
        //                       "WHERE p.FirstName = '" + firstName + "'";

        //        ObjectQuery<DbDataRecord> result = ((IObjectContextAdapter)context).ObjectContext.CreateQuery<DbDataRecord>(query);

        //        foreach (DbDataRecord record in result)
        //        {
        //            returnValue.Add(AdventureWorksEntities.FormFullName(record["Title"].ToString().Trim(), record["FirstName"].ToString().Trim(), record["MiddleName"].ToString().Trim(), record["LastName"].ToString().Trim()));
        //        }
        //        return returnValue;
        //    }
        //}
        #endregion
        #region public static IEnumerable<Person> GetPeopleByName(string firstName)
        //public static IEnumerable<string> GetPeopleByName(string firstName)
        //{
        //    List<string> result = new List<string>();

        //    using (var context = new AdventureWorksEntities())
        //    {

        //        string query = "SELECT p, p.BusinessEntity.BusinessEntityAddresses " +
        //                       "FROM AdventureWorksEntities.People AS p " +
        //                       "WHERE p.FirstName = '" + firstName + "'";

        //        ObjectQuery<DbDataRecord> people = ((IObjectContextAdapter)context).ObjectContext.CreateQuery<DbDataRecord>(query);

        //        foreach (DbDataRecord p in people)
        //        {
        //            var person = p[0] as Person;
        //            result.Add(AdventureWorksEntities.FormFullName(person.Title, person.FirstName, person.MiddleName, person.LastName));

        //            foreach (var a in person.BusinessEntity.BusinessEntityAddresses)
        //            {
        //                result.Add(AdventureWorksEntities.FormFullAddress(a.Address));
        //            }
        //        }
        //        return result;
        //    }
        //}
        #endregion
        #region public static IEnumerable<Person> GetPeopleByName(string firstName)
        //public static IEnumerable<string> GetPeopleByName(string firstName)
        //{
        //    List<string> result = new List<string>();

        //    using (var context = new AdventureWorksEntities())
        //    {

        //        string query = "SELECT p " +
        //                       "FROM AdventureWorksEntities.People AS p " +
        //                       "WHERE p.FirstName = '" + firstName + "'";

        //        ObjectQuery<DbDataRecord> people = ((IObjectContextAdapter)context).ObjectContext.CreateQuery<DbDataRecord>(query);

        //        foreach (DbDataRecord p in people)
        //        {
        //            var person = p[0] as Person;
        //            result.Add(AdventureWorksEntities.FormFullName(person.Title, person.FirstName, person.MiddleName, person.LastName));

        //            foreach (var a in person.BusinessEntity.BusinessEntityAddresses)
        //            {
        //                result.Add(AdventureWorksEntities.FormFullAddress(a.Address));
        //            }
        //        }
        //        return result;
        //    }
        //}
        #endregion
        #endregion


        #region  private static string FormFullName(object title, object firstName, object middleName, object lastName)
        private static string FormFullName(object title, object firstName, object middleName, object lastName)
        {
            StringBuilder sb = new StringBuilder();

            if (title == null)
                title = string.Empty;
            else
                title = (title == DBNull.Value) ? string.Empty : title.ToString().Trim();

            if (firstName == null)
                firstName = string.Empty;
            else
                firstName = (firstName == DBNull.Value) ? string.Empty : firstName.ToString().Trim();

            if (middleName == null)
                middleName = string.Empty;
            else
                middleName = (middleName == DBNull.Value) ? string.Empty : middleName.ToString().Trim();

            if (lastName == null)
                lastName = string.Empty;
            else
                lastName = (lastName == DBNull.Value) ? string.Empty : lastName.ToString().Trim();

            if (title.ToString().Length > 0)
            {
                sb.Append(title.ToString().Trim() + " ");
            }

            if (firstName.ToString().Length > 0)
            {
                sb.Append(firstName.ToString().Trim() + " ");
            }

            if (middleName.ToString().Length > 0)
            {
                sb.Append(middleName.ToString().Trim() + " ");
            }

            if (lastName.ToString().Length > 0)
            {
                sb.Append(lastName.ToString().Trim() + " ");
            }

            return sb.ToString();
        }
        #endregion
        #region private static string FormFullAddress(Address address)
        private static string FormFullAddress(Address address)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(address.AddressLine1);
            if (address.AddressLine2 != null && address.AddressLine2.ToString().Length > 0)
            {
                sb.AppendLine(address.AddressLine2);
            }
            sb.AppendLine(address.City + " " + address.StateProvince.Name + ", " + address.PostalCode);
            sb.AppendLine();

            return sb.ToString();
        }
        #endregion
    }

    public partial class ProductSubcategory
    {
        public override string ToString()
        {
            return this.Name;
        }

    }


}

#region working code commented out
//var titleDB = (rdr[3] == DBNull.Value) ? string.Empty : rdr.GetString(3);
//var firstNameDB = (rdr[4] == DBNull.Value) ? string.Empty : rdr.GetString(4);
//var middleNameDB = (rdr[5] == DBNull.Value) ? string.Empty : rdr.GetString(5);
//var lastNameDB = (rdr[6] == DBNull.Value) ? string.Empty : rdr.GetString(6);

//var titleDB = (rdr[3] == DBNull.Value) ? string.Empty : rdr[3].ToString();
//var firstNameDB = (rdr[4] == DBNull.Value) ? string.Empty : rdr[4].ToString();
//var middleNameDB = (rdr[5] == DBNull.Value) ? string.Empty : rdr[5].ToString();
//var lastNameDB = (rdr[6] == DBNull.Value) ? string.Empty : rdr[6].ToString();

//titleDB = (titleDB == DBNull.Value) ? string.Empty : titleDB.ToString().Trim();
//firstNameDB = (firstNameDB == DBNull.Value) ? string.Empty : firstNameDB.ToString().Trim();
//middleNameDB = (middleNameDB == DBNull.Value) ? string.Empty : middleNameDB.ToString().Trim();
//lastNameDB = (lastNameDB == DBNull.Value) ? string.Empty : lastNameDB.ToString().Trim();

//Console.WriteLine("{0}{1}{2}{3}", titleDB, firstNameDB, middleNameDB, lastNameDB);
//Console.WriteLine("{0} {1} {2} {3}", titleDB.ToString().Trim(), firstNameDB.ToString().Trim(), middleNameDB.ToString().Trim(), lastNameDB.ToString().Trim());

//public static List<string> EntityClientQueryContacts(string firstName)
//{
//    List<string> names = new List<string>();

//    using (EntityConnection conn = new EntityConnection("name=AdventureWorksEntities"))
//    {
//        conn.Open();

//        var queryString =
//            "SELECT VALUE p " +
//            "FROM AdventureWorksEntities.People AS p " +
//            "WHERE p.FirstName='" + firstName + "'";

//        EntityCommand cmd = conn.CreateCommand();
//        cmd.CommandText = queryString;
//        using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
//        {
//            while (rdr.Read())
//            {
//                var titleDB = rdr[3];
//                var firstNameDB = rdr[4];
//                var middleNameDB = rdr[5];
//                var lastNameDB = rdr[6];

//                string fullName = AdventureWorksEntities.FormFullName(titleDB, firstNameDB, middleNameDB, lastNameDB);

//                Console.WriteLine(fullName);
//            }
//        }

//        conn.Close();

//        Console.Write("Press Enter...");
//        Console.ReadLine();
//    }
//}
#endregion
