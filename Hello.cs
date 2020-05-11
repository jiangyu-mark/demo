using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "0";
            string test = "sin(0)/cos(0)";
            //数字表示数，单词表示符号
            string TempFirst2 = "", TempSecond2 = "", TempFirstTwo = "", TempSecondTwo="";
            double First2, Second2;
            int i11 = 0;
            do
            {
                TempFirstTwo += test.ToArray()[i11];
                i11++;
                Console.WriteLine(TempFirstTwo);
            }
            while (test.ToArray()[i11] < 123 && test.ToArray()[i11] > 96 && i11 < test.ToArray().Length - 2);

            int i12 = i11+1;
            do
            {
                TempFirst2 += test.ToArray()[i12];
                i12++;
                Console.WriteLine(TempFirst2);
            }
            while (test.ToArray()[i12] < 58 && test.ToArray()[i12] > 47 && i12 < test.ToArray().Length-2);
            //part2
            int i22 = test.ToArray().Length - 2;//或者i2=i1;
            do
            {
                TempSecond2 += test.ToArray()[i22];
                i22--;
                Console.WriteLine(TempSecond2);
            }
            while (test.ToArray()[i22] < 58 && test.ToArray()[i22] > 47 && i22 > 1);
            //Console.WriteLine(TempSecond2);
            //char[] 转换为string
            TempSecond2 = new string(TempSecond2.ToArray().Reverse().ToArray());
            Console.WriteLine(TempSecond2);
            int i21 = i22 -1;
            do
            {
                TempSecondTwo += test.ToArray()[i21];
                i21--;
                Console.WriteLine(TempSecondTwo);
            }
            while (test.ToArray()[i21] < 123 && test.ToArray()[i21] > 96 && i21 < test.ToArray().Length - 2);
            TempSecondTwo = new string(TempSecondTwo.ToArray().Reverse().ToArray());
            Console.WriteLine(TempSecondTwo);

            
            double.TryParse(TempFirst2, out First2);
            double.TryParse(TempSecond2, out Second2);
            switch (TempFirstTwo)
            {
                case "sin": First2 = Math.Sin(First2); break;
                case "cos": First2 = Math.Cos(First2); break;
                case "tan": First2 = Math.Tan(First2); break;
            }
            switch (TempSecondTwo)
            {
                case "sin": Second2 = Math.Sin(Second2); break;
                case "cos": Second2 = Math.Cos(Second2); break;
                case "tan": Second2 = Math.Tan(Second2); break;
            }

            for (int i = 0; i < test.ToArray().Length; i++)
                    switch (test.ToArray()[i].ToString())
                    {
                        case "+": result = (First2 + Second2).ToString(); break;
                        case "-": result = (First2 - Second2).ToString(); break;
                        case "*": result = (First2 * Second2).ToString(); break;
                        case "/": result = (First2 / Second2).ToString(); break;
                    }
            Console.WriteLine(result);
            Console.WriteLine(“yes”);

        }
    }
}
