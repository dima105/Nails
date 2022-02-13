using System;

namespace nails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество гвоздей: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество ударов: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int z;

            while (x > 0)
            {
                x--;
                z = y;
                while (z > 0)
                {
                    z--;
                }
            }
        }
    }
}