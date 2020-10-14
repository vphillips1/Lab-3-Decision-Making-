using System;
using System.Reflection.Metadata.Ecma335;

namespace Lab_3_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int iNum = 0;
            string name;
            bool containsOddNum = true;
            bool containsEvenNum = true;
            

            Console.Write(" Please enter your Name: ");
            name = Console.ReadLine();

            bool shouldcontinue = true;

            while (shouldcontinue)

            {
                Console.WriteLine(name + "," + " Enter a number between 1 and 100:");
                iNum = int.Parse(Console.ReadLine());

                if (iNum % 2 != 0)
                {
                    Console.WriteLine(name + " Your output is : " + iNum + " and Odd ");
                    
                }

                else if (containsEvenNum && iNum >= 2 && iNum <= 25)
                {
                    Console.WriteLine(name + " Your output is: " + iNum + " Even and less than 25.");
                    
                }

                else if (containsEvenNum && iNum >= 26 && containsEvenNum && iNum <= 60)

                {
                    Console.WriteLine(name + " Your output is: Even");
                    
                }

                else if (containsEvenNum && iNum > 60)
                {
                    Console.WriteLine(name + " Your output is: " + iNum + " Even");
                    
                }

                else if (containsOddNum && iNum > 60)

                {
                    Console.WriteLine(name + " Your output is : " + iNum + " Odd");
                    
                }

                Console.WriteLine("Would you like to continue? Press 'y' to continue and  'n' to exit:");
                if (Console.ReadKey().Key == ConsoleKey.N)

                {
                    Console.WriteLine(" Good Bye !");
                    return;
                }
                   
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    return;
              
               
            }
           

        }
    }
}
