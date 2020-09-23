using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Console_Dungeon
{
    public class ConsoleTools
    {

        public void ShowMessageToUser(string text, ConsoleColor colorText)
        {
            Console.ForegroundColor = colorText;
            Console.WriteLine(text);
        }

        public void ShowMessageToUser(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
        }

        public ConsoleKey ReadKey()
        {
            var keyPressed = Console.ReadKey().Key;
            return keyPressed;
        }

        public void Close()
        {
            Environment.Exit(0);
        }
    }
}
