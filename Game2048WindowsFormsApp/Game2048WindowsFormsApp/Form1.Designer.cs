namespace Game2048WindowsFormsApp
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.scoreLabel = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.рекордыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.рестартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bestScoreLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cчёт:";
			// 
			// scoreLabel
			// 
			this.scoreLabel.AutoSize = true;
			this.scoreLabel.Location = new System.Drawing.Point(60, 33);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(14, 16);
			this.scoreLabel.TabIndex = 1;
			this.scoreLabel.Text = "0";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(358, 25);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рекордыToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.рестартToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// рекордыToolStripMenuItem
			// 
			this.рекордыToolStripMenuItem.Name = "рекордыToolStripMenuItem";
			this.рекордыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.рекордыToolStripMenuItem.Text = "Рекорды";
			this.рекордыToolStripMenuItem.Click += new System.EventHandler(this.рекордыToolStripMenuItem_Click);
			// 
			// просмотрToolStripMenuItem
			// 
			this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
			this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.просмотрToolStripMenuItem.Text = "Правила игры";
			this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
			// 
			// рестартToolStripMenuItem
			// 
			this.рестартToolStripMenuItem.Name = "рестартToolStripMenuItem";
			this.рестартToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.рестартToolStripMenuItem.Text = "Рестарт";
			this.рестартToolStripMenuItem.Click += new System.EventHandler(this.рестартToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// bestScoreLabel
			// 
			this.bestScoreLabel.AutoSize = true;
			this.bestScoreLabel.Location = new System.Drawing.Point(332, 33);
			this.bestScoreLabel.Name = "bestScoreLabel";
			this.bestScoreLabel.Size = new System.Drawing.Size(14, 16);
			this.bestScoreLabel.TabIndex = 4;
			this.bestScoreLabel.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(194, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Лучший результат:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 490);
			this.Controls.Add(this.bestScoreLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.scoreLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Game 2048";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem рестартToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem рекордыToolStripMenuItem;
		private System.Windows.Forms.Label bestScoreLabel;
		private System.Windows.Forms.Label label3;
	}
}

