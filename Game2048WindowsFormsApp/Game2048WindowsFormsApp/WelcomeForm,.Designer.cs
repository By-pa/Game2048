namespace Game2048WindowsFormsApp
{
	partial class WelcomeForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.userNameTextBox = new System.Windows.Forms.TextBox();
			this.StartButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(41, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(328, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Добро пожаловать в игру 2048";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(22, 195);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Введите свое имя";
			// 
			// userNameTextBox
			// 
			this.userNameTextBox.Location = new System.Drawing.Point(192, 195);
			this.userNameTextBox.Name = "userNameTextBox";
			this.userNameTextBox.Size = new System.Drawing.Size(183, 22);
			this.userNameTextBox.TabIndex = 2;
			this.userNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// StartButton
			// 
			this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StartButton.Location = new System.Drawing.Point(97, 270);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(229, 135);
			this.StartButton.TabIndex = 3;
			this.StartButton.Text = "Начать игру";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// WelcomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 481);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.userNameTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "WelcomeForm";
			this.Text = "WelcomeForm";
			this.Load += new System.EventHandler(this.WelcomeForm__Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button StartButton;
		public System.Windows.Forms.TextBox userNameTextBox;
	}
}