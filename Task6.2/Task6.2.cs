using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Прогрмма определяет является ли Предложение палиндромом");
            Console.WriteLine("Введите предложение без знаков препинания");
            string strFull = Console.ReadLine();
            string strRemSpace = strFull.Replace(" ", "").ToLower();

            string strInverse = "";
            foreach (char c in strRemSpace)
            {
                strInverse = c + strInverse;
            }
            if (strRemSpace.Equals(strInverse)) Console.WriteLine("Предложение является палиндромом");
            else Console.WriteLine("Предложение не является палиндромом");
            Console.ReadKey();
        }
    }
}
