using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game2048WindowsFormsApp
{
	public partial class MainForm : Form
	{
		private const int mapSize = 4;
		private Label[,] labelsMap;
		private static Random random = new Random();
		private int score = 0;
		private int bestScore = 0;
		private static User user = new User("Не известно", 0);
		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var welcomeForm = new WelcomeForm();
			welcomeForm.ShowDialog();

			user.Name = welcomeForm.userNameTextBox.Text;

			InitMap();
			GenerateNumber();
			ShowScore();
			CalculateBestScore();

		}

		private void CalculateBestScore()
		{
			var users = UserResultsStorage.GetUserResults();
			if (users.Count == 0)
			{
				return;
			}
			bestScore = users[0].Score;
			foreach (var user in users)
			{
				if(user.Score > bestScore)
				{
					bestScore = user.Score;
				}
			}

			ShowBestScore();
		}
		private void ShowBestScore()
		{
			if (score > bestScore)
			{
				bestScore = score;
			}
			bestScoreLabel.Text = bestScore.ToString();
		}

		private void ShowScore()
		{
			scoreLabel.Text = score.ToString();
		}


		private void InitMap()
		{
			labelsMap = new Label[mapSize, mapSize];
			for (int i = 0; i < mapSize; i++)
			{
				for (int j = 0; j < mapSize; j++)
				{
					var newLabel = CreateLabel(i, j);
					Controls.Add(newLabel);
					labelsMap[i, j] = newLabel;
				}
			}
		}

		private void GenerateNumber()
		{
			int count = 0;

			while (true)
			{
				var randomNumberLabel = random.Next(mapSize * mapSize);
				var indexRow = randomNumberLabel / mapSize;
				var indexColumn = randomNumberLabel % mapSize;

				if (labelsMap[indexRow, indexColumn].Text == String.Empty)
				{
					var random = new Random();
					var randomNumber = random.Next(1, 101);
					if (randomNumber >= 1 && randomNumber <= 75)
						randomNumber = 2;
					else
						randomNumber = 4;

					labelsMap[indexRow, indexColumn].Text = randomNumber.ToString();
					break;
				}
				count++;

				if (count > 18)
				{
					break;
				}

			}
		}

		private Label CreateLabel(int indexRow, int indexColumn)
		{
			var label = new Label();
			label.BackColor = SystemColors.ButtonShadow;
			label.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
			label.Size = new Size(70, 70);
			label.Text = "";
			label.TextAlign = ContentAlignment.MiddleCenter;
			int x = 10 + indexColumn * 76;
			int y = 70 + indexRow * 76;
			label.Location = new Point(x, y);

			label.TextChanged += Label_TextChanged;

			return label;
		}

		private void Label_TextChanged(object sender, EventArgs e)
		{
			var label = (Label)sender;
			switch (label.Text)
			{
				case "": label.BackColor = SystemColors.ButtonShadow; break;
				case "2": label.BackColor = Color.FromArgb(255,255, 224); break;
				case "4": label.BackColor = Color.FromArgb(255, 255, 0); break;
				case "8": label.BackColor = Color.FromArgb(255, 215, 0); break;
				case "16": label.BackColor = Color.FromArgb(255,165,0); break;
				case "32": label.BackColor = Color.FromArgb(255,140,0); break;
				case "64": label.BackColor = Color.FromArgb(255, 160, 122); break;
				case "128": label.BackColor = Color.FromArgb(255, 127, 80); break;
				case "256": label.BackColor = Color.FromArgb(255,99,71); break;
				case "512": label.BackColor = Color.FromArgb(255, 69, 0); break;
				case "1024": label.BackColor = Color.FromArgb(178,34,34); break;
				case "2048": label.BackColor = Color.FromArgb(139, 0, 0); break;
				default:
					break;
			}
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
			{
				return;
			}
			if (e.KeyCode == Keys.Right)
			{
				MoveRight();
			}
			if (e.KeyCode == Keys.Left)
			{
				MoveLeft();
			}
			if (e.KeyCode == Keys.Up)
			{
				MoveUp();
			}
			if (e.KeyCode == Keys.Down)
			{
				MoveDown();
			}

			GenerateNumber();
			ShowScore();
			ShowBestScore();

			if(Win())
			{
				user.Score = score;
				UserResultsStorage.Append(user);
				MessageBox.Show("Поздравляю, вы победили!");
				return;
			}
			if (EndGame())
			{
				user.NewScore(score);
				UserResultsStorage.Append(user);
				MessageBox.Show($"К сожалению вы проиграли. Ваш счет: {user.Score}");
				return;
			}
		}

		private bool EndGame()
		{
			for (int i = 0; i < mapSize; i++)
			{
				for (int j = 0; j < mapSize; j++)
				{
					if (labelsMap[i, j].Text == String.Empty)
					{
						return false;
					}
				}
			}
			for (int i = 0; i < mapSize - 1; i++)
			{
				for (int j = 0; j < mapSize - 1; j++)
				{
					if (labelsMap[i, j].Text == labelsMap[i, j + 1].Text || labelsMap[i, j].Text == labelsMap[i + 1, j].Text)
					{
						return false;
					}
				}
			}
			for (int i = mapSize - 1; i >= 1; i--)
			{
				for (int j = mapSize - 1; j >= 1; j--)
				{
					if (labelsMap[i, j].Text == labelsMap[i, j - 1].Text || labelsMap[i, j].Text == labelsMap[i - 1, j].Text)
					{
						return false;
					}
				}
			}
			return true;
		}

		private bool Win()
		{
			for (int i = 0; i < mapSize; i++)
			{
				for (int j = 0; j < mapSize; j++)
				{
					if (labelsMap[i, j].Text == "2048")
					{
						return true;
					}
				}
			}
			return false;
		}


		private void MoveDown()
		{
			for (int j = 0; j < mapSize; j++)
			{
				for (int i = mapSize - 1; i >= 0; i--)
				{
					if (labelsMap[i, j].Text != String.Empty)
					{
						for (int k = i - 1; k >= 0; k--)
						{
							if (labelsMap[k, j].Text != String.Empty)
							{
								if (labelsMap[i, j].Text == labelsMap[k, j].Text)
								{
									var number = int.Parse(labelsMap[i, j].Text);
									score += number * 2;
									labelsMap[i, j].Text = (number * 2).ToString();
									labelsMap[k, j].Text = string.Empty;
								}
								break;
							}
						}
					}
				}
			}
			for (int j = 0; j < mapSize; j++)
			{
				for (int i = mapSize - 1; i >= 0; i--)
				{
					if (labelsMap[i, j].Text == String.Empty)
					{
						for (int k = i - 1; k >= 0; k--)
						{
							if (labelsMap[k, j].Text != String.Empty)
							{
								labelsMap[i, j].Text = labelsMap[k, j].Text;
								labelsMap[k, j].Text = string.Empty;
								break;
							}
						}
					}
				}
			}
		}

		private void MoveUp()
		{
			for (int j = 0; j < mapSize; j++)
			{
				for (int i = 0; i < mapSize; i++)
				{
					if (labelsMap[i, j].Text != String.Empty)
					{
						for (int k = i + 1; k < mapSize; k++)
						{
							if (labelsMap[k, j].Text != String.Empty)
							{
								if (labelsMap[i, j].Text == labelsMap[k, j].Text)
								{
									var number = int.Parse(labelsMap[i, j].Text);
									score += number * 2;
									labelsMap[i, j].Text = (number * 2).ToString();
									labelsMap[k, j].Text = string.Empty;
								}
								break;
							}
						}
					}
				}
			}
			for (int j = 0; j < mapSize; j++)
			{
				for (int i = 0; i < mapSize; i++)
				{
					if (labelsMap[i, j].Text == String.Empty)
					{
						for (int k = i + 1; k < mapSize; k++)
						{
							if (labelsMap[k, j].Text != String.Empty)
							{
								labelsMap[i, j].Text = labelsMap[k, j].Text;
								labelsMap[k, j].Text = string.Empty;
								break;
							}
						}
					}
				}
			}
		}

		private void MoveLeft()
		{
			for (int i = 0; i < mapSize; i++)
			{
				for (int j = 0; j < mapSize; j++)
				{
					if (labelsMap[i, j].Text != String.Empty)
					{
						for (int k = j + 1; k < mapSize; k++)
						{
							if (labelsMap[i, k].Text != String.Empty)
							{
								if (labelsMap[i, j].Text == labelsMap[i, k].Text)
								{
									var number = int.Parse(labelsMap[i, j].Text);
									score += number * 2;
									labelsMap[i, j].Text = (number * 2).ToString();
									labelsMap[i, k].Text = string.Empty;
								}
								break;
							}
						}
					}
				}
			}
			for (int i = 0; i < mapSize; i++)
			{
				for (int j = 0; j < mapSize; j++)
				{
					if (labelsMap[i, j].Text == String.Empty)
					{
						for (int k = j + 1; k < mapSize; k++)
						{
							if (labelsMap[i, k].Text != String.Empty)
							{
								labelsMap[i, j].Text = labelsMap[i, k].Text;
								labelsMap[i, k].Text = string.Empty;
								break;
							}
						}
					}
				}
			}
		}

		private void MoveRight()
		{
			for (int i = 0; i < mapSize; i++)
			{
				for (int j = mapSize - 1; j >= 0; j--)
				{
					if (labelsMap[i, j].Text != String.Empty)
					{
						for (int k = j - 1; k >= 0; k--)
						{
							if (labelsMap[i, k].Text != String.Empty)
							{
								if (labelsMap[i, j].Text == labelsMap[i, k].Text)
								{
									var number = int.Parse(labelsMap[i, j].Text);
									score += number * 2;
									labelsMap[i, j].Text = (number * 2).ToString();
									labelsMap[i, k].Text = string.Empty;
								}
								break;
							}
						}
					}
				}
			}
			for (int i = 0; i < mapSize; i++)
			{
				for (int j = mapSize - 1; j >= 0; j--)
				{
					if (labelsMap[i, j].Text == String.Empty)
					{
						for (int k = j - 1; k >= 0; k--)
						{
							if (labelsMap[i, k].Text != String.Empty)
							{
								labelsMap[i, j].Text = labelsMap[i, k].Text;
								labelsMap[i, k].Text = string.Empty;
								break;
							}
						}
					}
				}
			}
		}

		private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var rules = "Ваша цель получить число 2048 путем складывания цифр, для этого используйте стрелочки 'Вверх, вниз, вправо, влево'. Перемещаются все цифры разом в ту сторону, в которую вы направили, если числа одинаковые - они складываются ";
			MessageBox.Show(rules);
		}

		private void рекордыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var resultsForm = new ResultsForm();
			resultsForm.ShowDialog();
		}

	}
}
