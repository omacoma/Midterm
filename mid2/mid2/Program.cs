using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = (Console.ReadLine()).Split();
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            for(int i=1;i<=Math.Min(n,m);i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
        }
    }
}
