using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>
        {
            new Student { ID = 1, Name = "Aarav", Age = 20, Grade = 'A' },
            new Student { ID = 2, Name = "Priya", Age = 22, Grade = 'B' },
            new Student { ID = 3, Name = "Rahul", Age = 19, Grade = 'A' },
            new Student { ID = 4, Name = "Sneha", Age = 21, Grade = 'C' },
            new Student { ID = 5, Name = "Vikram", Age = 23, Grade = 'B' }
        };

            Console.WriteLine("All Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.ID}. {student.Name} - Age: {student.Age}, Grade: {student.Grade}");
            }

            Console.WriteLine("\nStudents with Grade 'A':");
            var gradeAStudents = students.Where(s => s.Grade == 'A');
            foreach (var student in gradeAStudents)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("\nStudents Sorted by Age:");
            var sortedByAge = students.OrderBy(s => s.Age);
            foreach (var student in sortedByAge)
            {
                Console.WriteLine($"{student.Name} - Age: {student.Age}");
            }

            Console.WriteLine($"\nTotal Students Count: {students.Count}");

            var oldestStudent = students.OrderByDescending(s => s.Age).First();
            Console.WriteLine($"\nOldest Student: {oldestStudent.Name} - Age: {oldestStudent.Age}");

            Console.WriteLine("\nGrouping Students by Grade:");
            var groupedByGrade = students.GroupBy(s => s.Grade);
            foreach (var group in groupedByGrade)
            {
                Console.WriteLine($"Grade {group.Key}: {string.Join(", ", group.Select(s => s.Name))}");
            }

            bool anyMinor = students.Any(s => s.Age < 18);
            Console.WriteLine($"\nAny student below 18? {anyMinor}");
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public char Grade { get; set; }
    }
}