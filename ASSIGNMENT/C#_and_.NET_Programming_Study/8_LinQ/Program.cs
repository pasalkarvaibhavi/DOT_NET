using System;
using System.Linq;
using System.Collections.Generic;

namespace _8_LinQ
{
    public class Program
    {
        public static void Main()
        {
           
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenSquares = from num in numbers
                              where num % 2 == 0
                              select num * num;
            Console.WriteLine("Squares of even numbers:");
            foreach (var square in evenSquares)
            {
                Console.WriteLine(square);
            }

   
            List<string> names = new List<string> { "Ram", "Bob", "Charlie", "David", "Eve", "Frank" };
            var filteredNames = from name in names
                                where "AEIOU".Contains(name[0])
                                select name.ToUpper();
            Console.WriteLine("\nNames starting with a vowel in uppercase:");
            foreach (var name in filteredNames)
            {
                Console.WriteLine(name);
            }

          
            var groupedNumbers = from num in numbers
                                 group num by (num % 2 == 0 ? "Even" : "Odd") into numGroup
                                 select new
                                 {
                                     Key = numGroup.Key,
                                     Numbers = numGroup.OrderByDescending(n => n)
                                 };
            Console.WriteLine("\nGrouped numbers (Even/Odd):");
            foreach (var group in groupedNumbers)
            {
                Console.WriteLine($"{group.Key}: {string.Join(", ", group.Numbers)}");
            }

            
            List<Person> persons = new List<Person>
            {
                new Person { Id = 1, Name = "Jack" },
                new Person { Id = 2, Name = "Bob" },
                new Person { Id = 3, Name = "Charlie" }
            };

            List<Department> departments = new List<Department>
            {
                new Department { PersonId = 1, DepartmentName = "HR" },
                new Department { PersonId = 2, DepartmentName = "Finance" },
                new Department { PersonId = 3, DepartmentName = "IT" },
                new Department { PersonId = 1, DepartmentName = "Marketing" }
            };

            var personDepartments = from p in persons
                                    join d in departments on p.Id equals d.PersonId
                                    select new { p.Name, d.DepartmentName };
            Console.WriteLine("\nPerson Departments:");
            foreach (var pd in personDepartments)
            {
                Console.WriteLine($"{pd.Name} works in {pd.DepartmentName}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Department
    {
        public int PersonId { get; set; }
        public string DepartmentName { get; set; }
    }
}

/* 
 *Squares of even numbers:
4
16
36
64
100

Names starting with a vowel in uppercase:
EVE

Grouped numbers (Even/Odd):
Odd: 9, 7, 5, 3, 1
Even: 10, 8, 6, 4, 2

Person Departments:
Jack works in HR
Jack works in Marketing
Bob works in Finance
Charlie works in IT

*/