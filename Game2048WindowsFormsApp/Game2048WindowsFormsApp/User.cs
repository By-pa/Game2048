namespace Game2048WindowsFormsApp
{
	public class User
	{
		public string Name { get; set; }
		public int Score { get; set; }

		public User(string name, int score)
		{
			Name = name;
			Score = score;
		}

		public void NewScore(int newScore)
		{
			if (Score < newScore)
			{
				Score = newScore;
			}
		}
	}
}