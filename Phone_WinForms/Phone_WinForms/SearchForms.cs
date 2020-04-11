using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_WinForms
{
	public partial class SearchForms : Form
	{
		public string SearchText
		{
			get
			{
				return txbSearchText.Text;
			}
			private set
			{
				txbSearchText.Text = value;
			}
		}
		public SearchForms()
		{
			InitializeComponent();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (txbSearchText.Text.Length < 1)
			{
				MessageBox.Show("Введите поисковый запрос!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else
			{				
				this.DialogResult = DialogResult.OK;
				Close();				
			}
		}

		private void rbPrice_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton a = sender as RadioButton;
			Tag = a.Tag;
		}

	}
}
