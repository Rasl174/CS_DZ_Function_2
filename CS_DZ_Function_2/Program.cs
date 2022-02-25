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
            Console.CursorVisible = false;

            int helth = 3, maxHelth = 10;

            DrawHelthBar(helth, maxHelth);

            Console.ReadKey();
        }

        static void DrawHelthBar(int helthValue, int maxHelthValue)
        {
            string bar = "";

            for (int i = 0; i < helthValue; i++)
            {
                bar += "#";
            }

            Console.SetCursorPosition(3, 3);
            Console.Write('[');
            Console.Write(bar);

            bar = "";
            for (int i = helthValue; i < maxHelthValue; i++)
            {
                bar += " ";
            }

            Console.Write(bar + ']');
        }
    }
}
