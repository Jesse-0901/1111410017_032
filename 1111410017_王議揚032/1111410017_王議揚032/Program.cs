using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111410017_王議揚032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入介於1至3999間的數字");
            int input = int.Parse(Console.ReadLine());
            if (input > 3999 || input < 1)
            {
                Console.WriteLine("僅接受1至3999");
            }
            string result = TransToRoman(input);
            Console.WriteLine(result);
        }
        static string TransToRoman(int num)
        {
            string[] romanword = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            int[] value = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

            string roman = "";

            for (int i = value.Length - 1; i >= 0; i--)
            {
                while (num >= value[i])
                {
                    roman += romanword[i];
                    num -= value[i];
                }
            }
            return roman;
        }
    }
}