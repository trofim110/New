using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите слово");
            string word;

            word = Console.ReadLine();

            // Подсчитываю количество цифр в слове
            int zero  = word.ToCharArray().Where(i => i == '0').Count();
            int one   = word.ToCharArray().Where(i => i == '1').Count();
            int two   = word.ToCharArray().Where(i => i == '2').Count();
            int three = word.ToCharArray().Where(i => i == '3').Count();
            int four  = word.ToCharArray().Where(i => i == '4').Count();
            int five  = word.ToCharArray().Where(i => i == '5').Count();
            int six   = word.ToCharArray().Where(i => i == '6').Count();
            int seven = word.ToCharArray().Where(i => i == '7').Count();
            int eight = word.ToCharArray().Where(i => i == '8').Count();
            int nine  = word.ToCharArray().Where(i => i == '9').Count();


            if (nine>0)    Console.WriteLine($"9 -- {nine} ");
            if (eight > 0) Console.WriteLine($"8 -- {eight}");
            if (seven > 0) Console.WriteLine($"7 -- {seven}");
            if (six > 0)   Console.WriteLine($"6 -- {six } ");
            if (five > 0)  Console.WriteLine($"5 -- {five} ");
            if (four > 0)  Console.WriteLine($"4 -- {four} ");
            if (three > 0) Console.WriteLine($"3 -- {three}");
            if (two > 0)   Console.WriteLine($"2 -- {two } ");
            if (one > 0)   Console.WriteLine($"1 -- {one}  ");
            if (zero >0)   Console.WriteLine($"0 -- {zero} ");

        }
    }

}