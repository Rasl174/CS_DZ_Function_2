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

            float health = 100;
            float maxHealth = 200;
            float maxHealthBar = 10;
            float healthProcent = health / maxHealth;
            
            DrawBar(healthProcent * maxHealthBar, maxHealthBar);

            Console.ReadKey();
        }

        static void DrawBar(float value, float maxValue)
        {
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += "#";
            }

            Console.SetCursorPosition(3, 3);
            Console.Write('[');
            Console.Write(bar);

            bar = "";
            for (double i = value; i < maxValue; i++)
            {
                bar += " ";
            }

            Console.Write(bar + ']');
        }
    }
}
