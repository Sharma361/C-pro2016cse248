using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Elena", "Gilbert" };
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\Student\Desktop\c.txt"))
            //{
            //    foreach (string s in names)
            //    {
            //        sw.WriteLine(s);
            //    }
          //  }
            string line = "";
            using (StreamReader sr = new StreamReader(@"C:\Users\Student\Desktop\c.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}
