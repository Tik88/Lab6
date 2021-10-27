using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = Console.ReadLine();

            string[] w = q.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int max = w.Max(x => x.Length);
            Console.WriteLine("Самое длинное слово из {0} букв", max);
            Console.ReadLine();

        }
    }
}
