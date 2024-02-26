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
		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			InitMap();
			GenerateNumber();
			ShowScore();
			

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
			}
		}

		private Label CreateLabel(int indexRow, int indexColumn)
		{
			var label = new Label();
			label.BackColor = SystemColors.Info;
			label.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
			label.Size = new Size(70, 70);
			label.Text = "";
			label.TextAlign = ContentAlignment.MiddleCenter;
			int x = 10 + indexColumn * 76;
			int y = 70 + indexRow * 76;
			label.Location = new Point(x, y);

			return label;
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Right) 
			{
				for (int i = 0; i < mapSize; i++)
				{
					for (int j = mapSize - 1; j >= 0; j--)
					{
						if (labelsMap[i, j].Text != String.Empty)
						{
							for (int k = j - 1; k >= 0; k--)
							{
								if (labelsMap[i,k].Text != String.Empty)
								{
									if(labelsMap[i, j].Text == labelsMap[i, k].Text)
									{
										var number = int.Parse(labelsMap[i, j].Text);
										score += number * 2;
										labelsMap[i, j].Text = (number*2).ToString();
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
			if (e.KeyCode == Keys.Left)
			{
				for (int i = 0; i < mapSize; i++)
				{
					for (int j = 0; j < mapSize; j++)
					{
						if (labelsMap[i, j].Text != String.Empty)
						{
							for (int k = j +1; k < mapSize; k++)
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
			if (e.KeyCode == Keys.Up)
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
			if (e.KeyCode == Keys.Down)
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

			GenerateNumber();
			ShowScore();
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
	}
}
