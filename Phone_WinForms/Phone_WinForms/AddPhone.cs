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
	public partial class AddPhone : Form
	{
		public AddPhone()
		{
			InitializeComponent();
		}

		private void AddPhone_MouseMove(object sender, MouseEventArgs e)
		{

			if (TXBprice.Text.Length > 0 && TXBproducer.TextLength > 0 && TBXcolor.Text.Length > 0 && TXBheight.Text.Length > 0 && TBXwidth.TextLength > 0 && TXBheight.Text.Length > 0 && TXBname.TextLength > 0 && TXBprice.Text.Length > 0 && TXBproducer.TextLength > 0 && TXBwidth.Text.Length > 0)
			{
				button1.Enabled = true;
				button1.BackColor = Color.Green;
			}
			else
			{
				button1.Enabled = false;
				button1.BackColor = Color.Gray;
			}

		}

		private void TBXwidth_Leave(object sender, EventArgs e)
		{
			AddPhone_MouseMove(this, null);//сделал для навигации табом
		}

		private void AddPhone_Load(object sender, EventArgs e)
		{
			Phone temp_obj = Tag as Phone;
			if (temp_obj != null)
			{
				TBXheight.Text = temp_obj.Phone_height.ToString();
				TBXwidth.Text = temp_obj.Phone_width.ToString();
				TXBprice.Text = temp_obj.Price.ToString();
				TXBproducer.Text = temp_obj.Producer.ToString();
				TXBname.Text = temp_obj.Name.ToString();
				txbColor.Text = temp_obj.Color_phone.ToString();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Phone temp_obj;
			temp_obj = Tag as Phone;
			//если мы редактируем обьект, то память будет выделена, а если обьект новый = выделяю память ему
			if (temp_obj == null) temp_obj = new Phone();
			temp_obj.Name = TXBname.Text;
			double.TryParse(TXBprice.Text, out double res22);
			temp_obj.Price = res22;
			temp_obj.Producer = TXBproducer.Text;
			int.TryParse(TBXheight.Text, out int res1);
			int.TryParse(TBXwidth.Text, out int res2);
			temp_obj.Phone_width = res2;
			temp_obj.Phone_height = res1;
			temp_obj.Color_phone = txbColor.Text;
			Tag = temp_obj;
		}
	}
}
