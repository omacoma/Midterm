using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace mid4
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(start));
            t.Start();
        }
            static void start()
        {
            int i = 0;
            string s1 = "   		 12";
            string s2 = "   	 11";
            string s3="   	         1";
            string s4 = "    10";
            string s5="   			    2";
            string s6 = "9";
            string s7="   				        3";
            string s8 = "    8";
            string s9="   			    4";
            string s10 = "   	 7";
            string s11="   		5";
            string s12 = "   		 6 ";
            string[] s = { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12 };
            while (true)
                {
                i++;
                i %= 12;
                for (int j = 0; j < 12; j++) {if (i == 0 && j == 0 || i == 1 && j == 2 || i == 2 && j == 4 || i == 3 && j == 6 || i == 4 && j == 8 || i == 5 && j == 10 || i == 6 && j == 11 || i == 7 && j == 9 ||
                        i == 8 && j == 7 || i == 9 && j == 5 || i == 10 && j == 3 || i == 11 && j == 1) Console.ForegroundColor = ConsoleColor.Red;
                    else Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(s[j]);
                    if (j % 2 == 0) Console.WriteLine();
                }
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
        
    }
}
