using System;
using System.Collections.Generic;

namespace PersonManagement
{
    internal class Program
    {

        public static List<Person> persons { get; set; } = new List<Person>();

        static void Main(string[] args)
        {
            Console.WriteLine("Our available commands :");
            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/exit");


            while (true)
            {

                Console.WriteLine();
                Console.Write("Enter your command : ");
                string command = Console.ReadLine();

                if (command == "/register")
                {
                    Console.Write("Please add person's name :");
                    string name = Console.ReadLine();
                    if (name.Length < 3 || name.Length > 30)
                    {
                        Console.WriteLine("The namespace entered is not valid");
                        Console.WriteLine("Please add person's name 3 < name.Length < 30 :");
                        Console.ReadLine();




                    }
                    else if (name.Length >= 3 || name.Length <= 30)
                    {

                    }



                    Console.Write("Please add person's surname :");
                    string lastName = Console.ReadLine();
                    if (lastName.Length < 5 || lastName.Length > 20)
                    {
                        Console.WriteLine("The namespace entered is not valid");
                        Console.WriteLine("Please add person's LastName 3 < name.Length < 30 :");


                    }
                    else if (lastName.Length >= 5 || lastName.Length <= 20)
                    {

                    }

                    Console.Write("Please add person's mailAdress :");
                    string mailadress = Console.ReadLine();
                    //bool CheckName = Person.IsMailTrue();
                    for (int i = 0; i < mailadress.Length; i++)
                    {
                        if (mailadress[i] == '@')
                        {
                            break;
                        }
                    }

                    Console.WriteLine("Right the password true");
                    break;



                    Console.Write("Please add person's password :");
                    string password = Console.ReadLine();
                    string password2 = Console.ReadLine();
                    if (password == password2)
                    {

                        break;
                    }
                    else
                    {

                        Console.WriteLine("Passwords aren`t same");
                    }
                    break;

                    Person person = new Person(name, lastName, mailadress, password);
                    persons.Add(person);

                    Console.WriteLine(person.GetMail() + " - Added to system.");

                }
                else if (command == "/login")
                {

                }
                else
                {
                    Console.WriteLine("Command not found, please enter command from list!");
                    Console.WriteLine();
                }
            }
        }
        public static void GetAddedPerson(string name, string lastName, string mailadress, string password)
        {
            Person person = new Person(name, lastName, mailadress, password);
            persons.Add(person);
        }

    }

    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MailAdress { get; set; }
        public string Password { get; private set; }


        public Person(string name, string lastName, string mailadress, string password)
        {
            Name = name;
            LastName = lastName;
            MailAdress = mailadress;
            Password = password;


        }
        public string GetMail()
        {
            return MailAdress;
        }
        public static bool IsMailTrue(string mailadress)
        {
            for (int i = 0; i < mailadress.Length; i++)
            {
                if (mailadress[i] == '@')
                {
                    return true;
                }
            }
            return false;
        }



    }
}
