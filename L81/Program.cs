using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
namespace L81
{
    class Library
    {
        public string Name;
        public string Surname;
        public string Book;
        public int Class;
        public int Number;

        public Library() { }
        public Library(string name, string surname, string book, int clas, int number)
        {
            Name = name;
            Surname = surname;
            Book = book;
            Class = clas;
            Number = number;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Surname + " " + this.Book + " " + this.Class + " " + this.Number;
        }

    }
    class Program
    {
        static public void FileInformationRewrite(string path, List<Library> users)
        {
            File.WriteAllText(path, String.Empty);
            using (StreamWriter s = new StreamWriter(path))
            {
                foreach (Library informationUnit in users)
                {
                    s.WriteLine(informationUnit.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            List<Library> A = new List<Library>();
            using (StreamReader s = new StreamReader("lib.txt"))
            {
                string str;
                string[] a;
                while (s.EndOfStream == false)
                {
                    str = s.ReadLine();
                    if (str != "" && str != " ")
                    {
                        a = str.Split(" ");
                        A.Add(new Library(a[0], a[1], a[2], int.Parse(a[3]), int.Parse(a[4])));
                    }
                }
            }
            Console.WriteLine("Add note: A");
            Console.WriteLine("Edit note: E");
            Console.WriteLine("Remove note: R");
            Console.WriteLine("Show notes: Enter");
            Console.WriteLine("Sort by name: N");
            Console.WriteLine("Sort by book: D");
            Console.WriteLine("Sort by number: S");
            Console.WriteLine("Sort by surname: U");
            Console.WriteLine("Sort by class: G");
            Console.WriteLine("Exit: Esc");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                foreach (Library p in A)
                {
                    Console.WriteLine(p.ToString());

                }
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by book: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by class: G");
                Console.WriteLine("Exit: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.A)
            {
                Console.Clear();
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("Disease:");
                string dis = Console.ReadLine();
                Console.WriteLine("Age:");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Number:");
                int num = int.Parse(Console.ReadLine());


                if (name != null && surname != null && dis != null && age != null && num != null)
                {
                    A.Add(new Library() { Name = name, Surname = surname, Book = dis, Class = age, Number = num });
                    FileInformationRewrite("doctor.txt", A);
                }
                else
                    Console.WriteLine("You do not add a new user!");
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by book: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by class: G");
                Console.WriteLine("Exit: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.R)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of file you want to delete");
                int n = int.Parse(Console.ReadLine());
                A.RemoveAt(n - 1);
                Console.WriteLine(n + " is deleted");
                FileInformationRewrite("doctor1.txt", A);
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by book: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by class: G");
                Console.WriteLine("Exit: Esc");

            }

            if (Console.ReadKey().Key == ConsoleKey.E)
            {
                Console.Clear();
                Library A1 = new Library();
                Console.WriteLine("Which file you want to edit");
                int k = int.Parse(Console.ReadLine());

                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                A1.Name = name;
                Console.WriteLine("Surname:");
                string sur = Console.ReadLine();
                A1.Surname = sur;
                Console.WriteLine("Disease:");
                string dis = Console.ReadLine();
                A1.Book = dis;
                Console.WriteLine("Age:");
                int age = int.Parse(Console.ReadLine());
                A1.Class = age;
                Console.WriteLine("Number:");
                int num = int.Parse(Console.ReadLine());
                A1.Number = num;

                A.RemoveAt(k - 1);
                A.Insert(k - 1, A1);
                FileInformationRewrite("lib.txt", A);
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by book: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by class: G");
                Console.WriteLine("Exit: Esc");
            }


            if (Console.ReadKey().Key == ConsoleKey.N)

            {

                var result = from u in A
                             orderby u.Name
                             select u;
                foreach (Library a in result)
                {
                    Console.WriteLine("\n" + a.ToString());
                }
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by book: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by class: G");
                Console.WriteLine("Exit: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.D)

            {

                var result = from u in A
                             orderby u.Book
                             select u;
                foreach (Library a in result)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by book: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by class: G");
                Console.WriteLine("Exit: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.U)
            {

                var result = from u in A
                             orderby u.Surname
                             select u;
                foreach (Library a in result)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by book: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by class: G");
                Console.WriteLine("Exit: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.G)

            {

                var result = from u in A
                             orderby u.Class
                             select u;
                foreach (Library a in result)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by book: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by class: G");
                Console.WriteLine("Exit: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.S)

            {
                var result = from u in A
                             orderby u.Number
                             select u;
                foreach (Library a in result)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by book: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by class: G");
                Console.WriteLine("Exit: Esc");
            }
            Console.ReadKey();
        }
    }
}