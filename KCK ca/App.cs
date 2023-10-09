    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace KCK_ca
{
    internal class App
    {
        public void Start()
        {
            Title = "BurnOut";
            RunMainMenu();
          
        }

        private void RunMainMenu()
        {
            string prompt = @"                                          
 ▄▄▄▄    █    ██  ██▀███   ███▄    █  ▒█████   █    ██ ▄▄▄█████▓
▓█████▄  ██  ▓██▒▓██ ▒ ██▒ ██ ▀█   █ ▒██▒  ██▒ ██  ▓██▒▓  ██▒ ▓▒
▒██▒ ▄██▓██  ▒██░▓██ ░▄█ ▒▓██  ▀█ ██▒▒██░  ██▒▓██  ▒██░▒ ▓██░ ▒░
▒██░█▀  ▓▓█  ░██░▒██▀▀█▄  ▓██▒  ▐▌██▒▒██   ██░▓▓█  ░██░░ ▓██▓ ░ 
░▓█  ▀█▓▒▒█████▓ ░██▓ ▒██▒▒██░   ▓██░░ ████▓▒░▒▒█████▓   ▒██▒ ░ 
░▒▓███▀▒░▒▓▒ ▒ ▒ ░ ▒▓ ░▒▓░░ ▒░   ▒ ▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒   ▒ ░░   
▒░▒   ░ ░░▒░ ░ ░   ░▒ ░ ▒░░ ░░   ░ ▒░  ░ ▒ ▒░ ░░▒░ ░ ░     ░    
 ░    ░  ░░░ ░ ░   ░░   ░    ░   ░ ░ ░ ░ ░ ▒   ░░░ ░ ░   ░      
 ░         ░        ░              ░     ░ ░     ░              
      ░                                                         
Welcome to the Burnout. What would you like to do?
Use arrows key to navigate. Press enter to Select
";

            string[] options = { "Create Pearson", "Choose Pearson", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
        }
    }
}
