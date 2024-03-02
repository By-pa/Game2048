namespace Game2048WindowsFormsApp
{
    partial class ResultsForm
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
			this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
			this.UserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BestResultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// ResultsDataGridView
			// 
			this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNameColumn,
            this.BestResultColumn});
			this.ResultsDataGridView.Location = new System.Drawing.Point(12, 12);
			this.ResultsDataGridView.Name = "ResultsDataGridView";
			this.ResultsDataGridView.RowHeadersWidth = 51;
			this.ResultsDataGridView.RowTemplate.Height = 24;
			this.ResultsDataGridView.Size = new System.Drawing.Size(403, 465);
			this.ResultsDataGridView.TabIndex = 0;
			// 
			// UserNameColumn
			// 
			this.UserNameColumn.HeaderText = "Имя";
			this.UserNameColumn.MinimumWidth = 6;
			this.UserNameColumn.Name = "UserNameColumn";
			this.UserNameColumn.Width = 125;
			// 
			// BestResultColumn
			// 
			this.BestResultColumn.HeaderText = "Лучший Результат";
			this.BestResultColumn.MinimumWidth = 6;
			this.BestResultColumn.Name = "BestResultColumn";
			this.BestResultColumn.Width = 125;
			// 
			// ResultsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 489);
			this.Controls.Add(this.ResultsDataGridView);
			this.Name = "ResultsForm";
			this.Text = "ResultsForm";
			this.Load += new System.EventHandler(this.ResultsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView ResultsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn BestResultColumn;
	}
}