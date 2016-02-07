using System;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{

           
            Console.Write("Press a number followed by ENTER: ");
            int a = int.Parse(Console.ReadLine());
            FizzBuzz fizzbuzz = new FizzBuzz();
            string result = fizzbuzz.RunFizzBuzz(a);
            Console.WriteLine("the result={0} " ,result);
           
        }
	}
}
