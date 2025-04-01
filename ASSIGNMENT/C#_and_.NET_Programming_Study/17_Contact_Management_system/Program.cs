using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_Contact_Management_system

{
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, string phone, string email)
        {
            Name = name;
            PhoneNumber = phone;
            Email = email;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Phone: {PhoneNumber}, Email: {Email}";
        }
    }

    class ContactManager
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine()?.Trim();
            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine()?.Trim();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Error: All fields are required.");
                return;
            }

            contacts.Add(new Contact(name, phone, email));
            Console.WriteLine("Contact added successfully.");
        }

        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            Console.WriteLine("\n--- Contact List ---");
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }

        public void SearchContact()
        {
            Console.Write("Enter Name or Phone Number to search: ");
            string query = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                Console.WriteLine("Error: Search input cannot be empty.");
                return;
            }

            var results = contacts.Where(c => c.Name.ToLower().Contains(query.ToLower()) ||
                                              c.PhoneNumber.Contains(query)).ToList();
            if (results.Count > 0)
            {
                Console.WriteLine("\n--- Search Results ---");
                foreach (var contact in results)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine("No matching contacts found.");
            }
        }

        public void DeleteContact()
        {
            Console.Write("Enter Name to delete: ");
            string nameToDelete = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(nameToDelete))
            {
                Console.WriteLine("Error: Name cannot be empty.");
                return;
            }

            var contact = contacts.FirstOrDefault(c => c.Name.Equals(nameToDelete, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ContactManager manager = new ContactManager();

            while (true)
            {
                Console.WriteLine("\n--- Contact Management System ---");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contacts");
                Console.WriteLine("3. Search Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine()?.Trim();

                switch (choice)
                {
                    case "1":
                        manager.AddContact();
                        break;
                    case "2":
                        manager.DisplayContacts();
                        break;
                    case "3":
                        manager.SearchContact();
                        break;
                    case "4":
                        manager.DeleteContact();
                        break;
                    case "5":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
