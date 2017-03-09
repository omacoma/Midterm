using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace mid3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss = Console.ReadLine();
            DirectoryInfo[] dirs = (new DirectoryInfo(ss)).GetDirectories();
            foreach (DirectoryInfo papka in dirs)
            {
                string s = papka.Name;
                for (int i = 0;i < s.Length-3; i++){
                    if (s[i] == 't' && s[i + 1] == 'e' && s[i + 2] == 's' && s[i + 3] == 't')
                    {
                        Console.WriteLine(papka.Name);
                        break;
                    }
                }
            }
            FileInfo[] files = new DirectoryInfo(ss).GetFiles();
            foreach (FileInfo file in files)
            {
                string s = file.Name;
                for (int i = 0; i < s.Length - 3; i++)
                {
                    if (s[i] == 't' && s[i + 1] == 'e' && s[i + 2] == 's' && s[i + 3] == 't')
                    {
                        Console.WriteLine(file.Name);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
