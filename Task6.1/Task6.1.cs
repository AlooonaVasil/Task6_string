using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Прогрмма определяет самое длинное слово в строке");
            Console.WriteLine("Введите предложение без знаков препинания");
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string max = strArray[0];
            foreach (var s in strArray)
            {
                if (s.Length > max.Length)
                {
                    max = s;
                }
            }
            Console.WriteLine("Самое длинное слово в предложении - {0}", max);
            Console.ReadKey();
        }
    }
}
