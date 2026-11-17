using System;

namespace OOPHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HOMEWORK 1
            Console.WriteLine("=== Homework 1: Books ===");

            Book[] books = new Book[]
            {
                new Book("Suc ve Ceza", "Dostoyevski", 687),
                new Book("1984", "George Orwell", 328),
                new Book(
                    "The Little Prince",
                    "Antoine de Saint-Exupery",
                    96
                )
            };

            Book longestBook = books[0];

            foreach (Book book in books)
            {
                Console.WriteLine(book.Info());

                if (book.Pages > longestBook.Pages)
                {
                    longestBook = book;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Book with the most pages:");
            Console.WriteLine(longestBook.Info());

            // HOMEWORK 2
            Console.WriteLine();
            Console.WriteLine("=== Homework 2: Course Registration ===");

            Course[] courses = new Course[]
            {
                new Course(
                    "CENG211",
                    "Object Oriented Programming",
                    4
                ),
                new Course("MATH201", "Calculus", 5),
                new Course("CENG203", "Data Structures", 4),
                new Course("CENG205", "Digital Logic", 3),
                new Course("ENG201", "Academic English", 2)
            };

            int totalCredits = 0;

            foreach (Course course in courses)
            {
                Console.WriteLine(course.Info());
                totalCredits += course.Credits;
            }

            Console.WriteLine();
            Console.WriteLine($"Total credits: {totalCredits}");

            string[] courseNames = new string[courses.Length];

            for (int i = 0; i < courses.Length; i++)
            {
                courseNames[i] = courses[i].Name;
            }

            Array.Sort(courseNames);

            Console.WriteLine();
            Console.WriteLine("Course names in alphabetical order:");

            foreach (string name in courseNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}