using System;

namespace NestedLoop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
        }
    }
}
