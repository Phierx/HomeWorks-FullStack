using System;

namespace csharpTutorial
{
    class Program
    {
          static void MyMethod()
        {
            string we = Console.ReadLine();
            int weLenght = we.Length -1;
            int res1;
            bool success = Int32.TryParse(we, out res1);
            if (Char.IsNumber(we,weLenght) == false)
            {
                Console.WriteLine("The factorial work with number not Alphabet");
                MyMethod();
            }
            else if (success)
            {
                if(res1 > 30)
                {
                    Console.WriteLine("To prevent the average machine to crash, please keep the number below 30");
                    MyMethod();
                }
            }
            else
            {
                // int res1 = Char.Parse(we);         
                Console.WriteLine("Please type "+ res1 +" Again, Thank you");


                int input = res1;
                int i;
                int result = 1;

                for (i = 1; i <= input; i++)
                {
                    result = result * i;
                }
                Console.WriteLine("The factorial of " + input + " is " + result);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial - APP");
            Console.WriteLine("Please enter the desired number");
            MyMethod();

          
        }
    }
}
