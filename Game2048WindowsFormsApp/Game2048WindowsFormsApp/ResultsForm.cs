using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2048WindowsFormsApp
{
	public partial class ResultsForm : Form
	{
		public ResultsForm()
		{
			InitializeComponent();
		}

		private void ResultsForm_Load(object sender, EventArgs e)
		{
			var results = UserResultsStorage.GetUserResults();

			foreach (var result in results)
			{
				ResultsDataGridView.Rows.Add(result.Name, result.Score);
			}
		}
	}
}
