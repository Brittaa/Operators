using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int x = 5;
            int y = 2;

            //Aritmetic Operators
            /*Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);*/

            //Console.WriteLine(x = y);
            //Console.WriteLine(x += y);
            //Console.WriteLine(x -= y);
            //Console.WriteLine(x *= y);
            //Console.WriteLine(x % y);  jääk on vastus ilma =


            //Comparison Operators
            /*Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x > y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x < y);
            Console.WriteLine(x <= y);*/

            //Logical Operators
            //&& - AND
            //|| - OR (pipes)
            Console.WriteLine(x != y && y == 2);
            Console.WriteLine(x != y && y == 10);
            Console.WriteLine(x != y || y ==2);
            Console.WriteLine(!(y == 10));

            Console.ReadLine();


        }
    }
}
