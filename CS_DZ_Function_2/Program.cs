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

            float health = 90;
            float maxHealth = 1000;
            float maxHealthBar = 10;
            float healthProcent = maxHealthBar / maxHealth;
            
            health = healthProcent * health;

            DrawHelthBar(health, maxHealthBar);

            Console.ReadKey();
        }

        static void DrawHelthBar(float healthValue, float maxHealthValue)
        {
            string bar = "";

            for (int i = 0; i < healthValue; i++)
            {
                bar += "#";
            }

            Console.SetCursorPosition(3, 3);
            Console.Write('[');
            Console.Write(bar);

            bar = "";
            for (double i = healthValue; i < maxHealthValue; i++)
            {
                bar += " ";
            }

            Console.Write(bar + ']');
        }
    }
}
