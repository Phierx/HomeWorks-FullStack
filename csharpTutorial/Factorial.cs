using System;

namespace csharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial - APP");
            Console.WriteLine("Please enter the desired number");
            int input ;
            input = int.Parse(Console.ReadLine());
            int i  ;
            int result = 1;
             
            for (i = 1 ; i <= input; i++)
            {
                result = result * i;
                
            }
            //Console.WriteLine("My Age Is "+ myAge); 
            Console.WriteLine("The factorial of " + input + " is " + result);
        }
    }
}
