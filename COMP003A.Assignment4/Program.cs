/*
 * Author: Emily Cornelius
 * Course: COMP-003A
 * Purpose: Looping Statements Assignment
 */ 
 namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("for loop Section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("*********************************************");

            Console.Write("Enter a positive whole number: ");
            string integer = Console.ReadLine();
            int limit = Convert.ToInt32(integer);

            string output = "";
            for (int i = 0; i < limit; i ++)
            {
                output += "#";
                Console.WriteLine(output);
 
            }
            
            Console.WriteLine("\n\n********************************************");
            Console.WriteLine("foreach Section");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("*********************************************");

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine("\n\n**********************************************");
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("***********************************************");

            int counter = 0;
            do
            {
                Console.WriteLine(counter); counter += 5; 
            } while (counter <= 50);

            Console.WriteLine("***********************************************");
            Console.WriteLine("while Section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divisible by 2, output Foo");
            Console.WriteLine("If the number is divisible by 5, output Bar");
            Console.WriteLine("If the number is divisible by 2 & 5, output FooBar");
            Console.WriteLine("************************************************");

            int counter2 = 1;
            while (counter2 <= 20)
            {
                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                else if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else { Console.WriteLine(counter2); }
                counter2++;
            }
        }
    }
}
