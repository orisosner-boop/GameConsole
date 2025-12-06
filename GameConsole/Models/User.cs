using System;
namespace GameConsole.Models
{

    public class User
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<HighScores> Highscores { get; set; }

        public User(string name, string username, string password)
        {
            this.Name = name;
            this.UserName = username;
            this.Password = password;
            this.Highscores = new List<HighScores>();
        }
    }
}
