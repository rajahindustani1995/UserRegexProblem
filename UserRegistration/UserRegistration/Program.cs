﻿namespace UserRegistration
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to User Registration Problem");
            while (true)
            {
                Console.WriteLine("\n1. Enter valid First Name");
                Console.WriteLine("2. Enter valid Last Name");
                Console.WriteLine("3. Enter valid email");

                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        RegisterUser registerUser = new RegisterUser();
                        Console.WriteLine(registerUser.Name("First"));
                        break;
                    case 2:
                        RegisterUser registerUser1 = new RegisterUser();
                        Console.WriteLine(registerUser1.Name("Last"));
                        break;
                    case 3:    
                        RegisterUser registerUser2 = new RegisterUser();
                        Console.WriteLine("abc+100@gmail.com : " + registerUser2.Email("abc+100@gmail.com"));
                        Console.WriteLine("abc@gmail.com.aa.au : " + registerUser2.Email("abc@gmail.com.aa.au"));
                        break;
                    default:
                        Console.WriteLine("Please enter correct choice");
                        break;
                }
            }
        }
    }
}
