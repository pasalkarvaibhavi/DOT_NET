using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q2_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument xmlDoc = new XDocument(
                new XElement("Students",
                    new XElement("Student", new XAttribute("ID", 1),
                        new XElement("Name", "Aarav"),
                        new XElement("Age", 20),
                        new XElement("Grade", "A")),
                    new XElement("Student", new XAttribute("ID", 2),
                        new XElement("Name", "Priya"),
                        new XElement("Age", 22),
                        new XElement("Grade", "B")),
                    new XElement("Student", new XAttribute("ID", 3),
                        new XElement("Name", "Rahul"),
                        new XElement("Age", 19),
                        new XElement("Grade", "A")),
                    new XElement("Student", new XAttribute("ID", 4),
                        new XElement("Name", "Sneha"),
                        new XElement("Age", 21),
                        new XElement("Grade", "C")),
                    new XElement("Student", new XAttribute("ID", 5),
                        new XElement("Name", "Vikram"),
                        new XElement("Age", 23),
                        new XElement("Grade", "B"))
                )
            );

            Console.WriteLine("Students with Grade 'A':");
            var gradeAStudents = xmlDoc.Descendants("Student")
                                       .Where(s => s.Element("Grade")?.Value == "A");
            foreach (var student in gradeAStudents)
            {
                Console.WriteLine(student.Element("Name")?.Value);
            }

            Console.WriteLine("\nStudents sorted by Age:");
            var sortedStudents = xmlDoc.Descendants("Student")
                                       .OrderBy(s => int.Parse(s.Element("Age")?.Value ?? "0"));
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Element("Name")?.Value} - Age: {student.Element("Age")?.Value}");
            }

            Console.WriteLine("\nTotal Number of Students:");
            int totalStudents = xmlDoc.Descendants("Student").Count();
            Console.WriteLine(totalStudents);

            Console.WriteLine("\nAverage Age of Students:");
            double avgAge = xmlDoc.Descendants("Student")
                                  .Average(s => int.Parse(s.Element("Age")?.Value ?? "0"));
            Console.WriteLine(avgAge);

            Console.WriteLine("\nStudents who have Grade 'B':");
            var gradeBStudents = xmlDoc.Descendants("Student")
                                       .Where(s => s.Element("Grade")?.Value == "B")
                                       .Select(s => s.Element("Name")?.Value);
            Console.WriteLine(string.Join(", ", gradeBStudents));
        }
    }

}

/*
 Students with Grade 'A':
Aarav
Rahul

Students sorted by Age:
Rahul - Age: 19
Aarav - Age: 20
Sneha - Age: 21
Priya - Age: 22
Vikram - Age: 23

Total Number of Students:
5

Average Age of Students:
21

Students who have Grade 'B':
Priya, Vikram
*/