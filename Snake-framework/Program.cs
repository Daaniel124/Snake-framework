using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = Menu.Start();
            if (choice == 1)
            {
                Game.MainGame();
            }
            if (choice == 2)
            {

            }
            if (choice == 3)
            {
                Environment.Exit(0);
            }
        }
    }
}
