using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lokaverk_Jol_2016
{
    class Intro_and_shit
    {
        int counter = 10;
        int counter_2 = 5;
        string alert = "welcome to the tower game";
        string text = "congratulations you have won the game";
        string text_2 = "A Game After Styrkár blær and Magnús orri";
        public void intro()
        {
            bool visible = true;
            for (int i = 0; i < counter; i++)
            {
                do
                {
                    foreach (var c in alert)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(c);
                        Console.ForegroundColor = visible ? ConsoleColor.Red : ConsoleColor.White;
                        visible = !visible;
                        Thread.Sleep(10);
                        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (alert.Length / 2)) + "}", alert));
                        Thread.Sleep(10);
                    }
                } while (!true);

            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\n");
            Console.ForegroundColor = ConsoleColor.Red;
            string alert_2 = "Press Any Key To Start...";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (alert_2.Length / 2)) + "}", alert_2));
            Console.ReadKey();
            Console.Clear();
        }

        public void the_end()
        {
            bool visible = true;
            for (int i = 0; i < counter_2; i++)
            {
                do
                {
                    foreach (var c in alert)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(c);
                        Console.ForegroundColor = visible ? ConsoleColor.Red : ConsoleColor.Magenta;
                        visible = !visible;
                        Thread.Sleep(10);
                        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
                        Thread.Sleep(10);
                    }
                } while (!true);
              }//for
                Console.WriteLine("\r\n");
                for (int i = 0; i < counter_2; i++)
                {
                    do
                    {
                        foreach (var c in alert)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(c);
                            Console.ForegroundColor = visible ? ConsoleColor.Red : ConsoleColor.Green;
                            visible = !visible;
                            Thread.Sleep(10);
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text_2.Length / 2)) + "}", text_2));
                            Thread.Sleep(10);
                        }
                    } while (!true);
                }//for
        }
    }
}

