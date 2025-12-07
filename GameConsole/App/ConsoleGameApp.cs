using GameConsole.Base;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.App
{
    internal class ConsoleGameApp
    {
        private Screen mainPage;
        public ConsoleGameApp()
        {
            this.mainPage = new Pages.StartScreen();
        }
        public void StartApp()
        {
            mainPage.Show();
        }
        public static User user;
    }
}
