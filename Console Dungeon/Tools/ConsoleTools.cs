using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Dungeon
{
    public class ConsoleTools
    {

        public void ShowMessageToUser(string text)
        {
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
