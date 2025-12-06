using System;
namespace GameConsole.Models
{

	internal class HighScores
	{
		public string UserName { get; set; }
		public int Score { get; set; }
		public DateTime Date { get; set; }

		public HighScores(string UserName, int Score)
		{
			this.UserName = UserName;
			this.Score = Score;
			this.Date = DateTime.Now;
		}
	}
}
