using System;

namespace Dot_Project_Calculator
{
    class Program
    {
        static void add()
        {
            Console.WriteLine("Enter the first number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());
            int result = first_number + second_number;
            Console.WriteLine("The Addition is: " + result);
      
        }
        static void sub()
        {
            Console.WriteLine("Enter the first number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());
            int result = first_number - second_number;
            Console.WriteLine("The Subtraction is: " + result);
        }
        static void mul()
        {
            Console.WriteLine("Enter the first number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());
            int result = first_number * second_number;
            Console.WriteLine("The Multiplication is: " + result);
        }
        static void div()
        {
            Console.WriteLine("Enter the first number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());
            int result = first_number / second_number;
            Console.WriteLine("The Division is: " + result);
        }
        static void mod()
        {
            Console.WriteLine("Enter the first number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());
            int result = first_number % second_number;
            Console.WriteLine("The Modulus is: " + result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Console Calculator!!! \n\n Which Calculation You want to do: \n Choice a number from the below list \n 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division \n 5. Modulus");
           int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    add();
                    break;
                case 2:
                    sub();
                    break;
                case 3:
                    mul();
                    break;
                case 4:
                    div();
                    break;
                case 5:
                    mod();
                    break;
                default:
                    Console.WriteLine("You have entered an invalid number");
                    break;                            
            }
        }
    }
}
