using LinqTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask.Methods
{
   public  class Methods
    {
        public static Array Task1()
        {
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            var query = numbers.Where(num => num > 30 && num%2==0).ToArray();
            return query;
        }

        public static List<string> Task2()
        {
            List<User> users = new List<User>();
            users.Add(new User { Name = "Asim", Age = 20 });
            users.Add(new User { Name = "Aygun", Age = 25 });
            var query = from user in users

                        select user.Name;


            return query.ToList();
        }
        public static void Task3()
        {
            List<User> users = new List<User>();
            users.Add(new User { Name = "Asim", Age = 20 });
            users.Add(new User { Name = "Aygun", Age = 25 });
            var query = from user in users
                        select new
                        {
                            Name = user.Name,
                            birthDate = DateTime.Now.Year - user.Age
                        };


        }
        public static Array Task4()
        {
            int[] numbers = { 3, 12, 4, 10, 34, 20, 55, -66, 77, 88, 4 };
            var query = from number in numbers
                        orderby number
                        select number;
            return query.ToArray() ;
        }
        public static Array Task5()
        {
            string[] languages = { "C#", "PLSQL", "MySQL" };
            string[] companies = { "Microsoft", "Oracle", "PHP" };
            var newarray=languages.Concat(companies).ToArray();

            return newarray;
        }
        public static IEnumerable<object> Task6()
        {
            List<Category> categories = new List<Category>()
            {
             new Category{ Name = "Milk", Country ="Belorussia" },
             new Category{ Name = "Juice", Country ="Poland" }
            };
            List<Product> products = new List<Product>()
            {
             new Product{Name="Yoghurt", Category ="Milk"},
             new Product{Name="Cheese", Category ="Milk"},
             new Product{Name="Fruktoviy sad", Category ="Juice"}
            };

            var q = products.Join(categories, str1 => str1.Category,
                      str2 => str2.Name,
                      (str1, str2) => new  // result selector
                      {
                          Name = str1.Name,
                          Category = str1.Category,
                          Country = str2.Country
                      }).ToList();

            return q;
        }


    }
}
