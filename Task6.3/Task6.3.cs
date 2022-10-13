using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа удаляет текст в фигурных скобках");
            Console.WriteLine("Введите предложение ");
            string str = Console.ReadLine();

            int count = 0;
            string str2 = "";

            foreach (char c in str)
            {
                if (c == '{')
                    count++;
                else if (c == '}')
                    count--;
                else if (count == 0)
                    str2 += c;
            }
            Console.WriteLine("Строка без фигурных скобок и их содержимого: {0}", str2);
            Console.ReadKey();
        }
    }
}
