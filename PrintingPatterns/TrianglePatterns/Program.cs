using System;

namespace TrianglePatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayPatternA();
			DisplayPatternB();
			DisplayPatternC();
			DisplayPatternD();

			Console.ReadLine();
		}

        static void DisplayPatternA()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // your implementation here
        }
        static void DisplayPatternB()
        {
            for (int i = 10; i >= 0; i--)
            {
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            // your implementation here
        }

        static void DisplayPatternC()
        {
            for (int i = 10; i >= 0; i--)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            // your implementation here
        }
        static void DisplayPatternD()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            // your implementation here
        }
    }
}
