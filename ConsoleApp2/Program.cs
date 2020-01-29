using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput_1;
            string userInput_2;
            string userInput_3;
            int n, a, b;
            
            Console.WriteLine("n : ");
            userInput_1 = Console.ReadLine();
            n = Convert.ToInt32(userInput_1);

            Console.WriteLine("a : ");
            userInput_2 = Console.ReadLine();
            a = Convert.ToInt32(userInput_2);

            Console.WriteLine("b : ");
            userInput_3 = Console.ReadLine();
            b  = Convert.ToInt32(userInput_3);
            if (n < 1)
            {
                Console.WriteLine("Ваше число не натуально");
            }
            else
            {

                string n_string = n.ToString();
                int sum = 0;
                foreach (char c in n_string)
                {
                    sum += (int)Char.GetNumericValue(c); ;
                }
                Console.WriteLine(sum);
                if (sum > a)
                {
                    Console.WriteLine("Это правда что сумма чисел больше чем a");
                }
                else
                {
                    Console.WriteLine("Это не правда что сумма чисел больше чем a");
                }
                
                if(n%2 != 0)
                {
                    Console.WriteLine("Это правда что n не делиться на b");
                }
                else
                {
                    Console.WriteLine("Это не правда что n не делиться на b");
                }
            }

            // check out

           








        }
    }
}
