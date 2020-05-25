using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Random(1, 200));
            Console.ReadLine();
        }
        static int Random(int min, int max)
        {
            Random random = new System.Random();
            return random.Next(min, max);
        }
    }
}
