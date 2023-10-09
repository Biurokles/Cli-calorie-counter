using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace KCK_ca
{
    internal class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options) {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }
        private void DisplayOptions()
        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;
                if (i == SelectedIndex)
                {
                    prefix = "  \u001b[32m*";

                }
                else {
                    prefix = "";
                }
                ResetColor();
                WriteLine($"{prefix}<<{currentOption}>>\u001b[0m");
            }
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                if(keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                }
                else if(keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                }
                SelectedIndex= (SelectedIndex+Options.Length)%Options.Length;

            }
            while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }
    }
}
