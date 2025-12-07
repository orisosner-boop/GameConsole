using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class RegisterScreen : Screen
    {
        public RegisterScreen() : base("REGISTER PAGE")
        {
        }

        public override void Show()
        {
            base.Show();
            CenterText("Enter Your Desired Details");
            CenterText("Name");
            string name = Console.ReadLine();
            CenterText("Username");
            string username = Console.ReadLine();
            CenterText("Password");
            string password = Console.ReadLine();
            UserDb.RegisterUser(name, username, password);
            CenterText("Registration successful! press any key to continue...");
            Console.ReadKey();
            Screen next = new MainMenu();
            next.Show();
        }
    }
}
