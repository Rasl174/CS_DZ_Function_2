using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Function_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int helth = 4;
            int maxHelth = 10;

            while (true)
            {
                HelthDrawBar(helth, maxHelth);

                Console.SetCursorPosition(0, 3);
                Console.Write("Введите число для изменения жизней: ");
                helth += Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();
            }
            
        }

        static void HelthDrawBar(int value, int maxValue)
        {
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += '#';
            }

            Console.SetCursorPosition(5, 1);
            Console.Write('[');
            Console.Write(bar);

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += ' ';
            }

            Console.Write(bar + "]");
        }
    }
}
