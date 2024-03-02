namespace Game2048.Common
{
	public class User
	{
		public string Name { get; set; }
		public int BestScore { get; set; }

		public User(string name)
		{
			Name = name;
			BestScore = 0;
		}

		public void AddBestScore(int score)
		{
			if (BestScore < score)
			{
				BestScore = score;
			}
			
		}
	}
}