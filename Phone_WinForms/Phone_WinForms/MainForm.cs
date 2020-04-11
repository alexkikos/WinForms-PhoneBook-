using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Phone_WinForms
{
	public partial class MainForm : Form
	{
		int posx, posy;
		bool move = false;
		DateTime startt;
		List<Phone> phones;
		AddPhone AddPhone;
		SearchForms searchForms;
		SortForm sortForm;

		bool searching = false;
		/// <summary>
		/// храню результат поиска данныъ
		/// </summary>
		IEnumerable<Phone> obj;
		public MainForm()
		{
			InitializeComponent();
			startt = new DateTime();
			startt = DateTime.Now;
			phones = new List<Phone>();
			AddPhone = new AddPhone();
			searchForms = new SearchForms();
			sortForm = new SortForm();		
		}


		private void BtnAddPhone_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = AddPhone.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					phones.Add(AddPhone.Tag as Phone);
					lstbLISTPHONE.Items.Add(AddPhone.Tag as Phone);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Add phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

			foreach (var item in lstbLISTPHONE.Items)
			{
				item.ToString();
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.DefaultExt = "txt";
				saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
				DialogResult dialogResult = saveFileDialog.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{

					FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					binaryFormatter.Serialize(fileStream, phones);
					fileStream.Close();
					MessageBox.Show("Выполнено", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
				if (!Directory.Exists("Database"))
				{
					Directory.CreateDirectory("Database");
				}
				openFileDialog.InitialDirectory = Environment.CurrentDirectory + @"\Database\";
				DialogResult dialogResult = openFileDialog.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					if (phones.Count > 0)
					{
						phones.Clear();
						lstbLISTPHONE.Items.Clear();
					}
					FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					phones = (List<Phone>)binaryFormatter.Deserialize(fileStream);
					fileStream.Close();
					if (phones.Count > 0)
					{
						foreach (var item in phones)
						{
							lstbLISTPHONE.Items.Add(item);
						}
						MessageBox.Show("Выполнено", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else MessageBox.Show("Обьектов не найдено", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void lstbLISTPHONE_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				if (lstbLISTPHONE.SelectedIndex != ListBox.NoMatches)
				{
					if (lstbLISTPHONE.SelectedIndices.Count > 1)
					{
						MessageBox.Show("Вы можете редактировать только одну позицию", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					Phone temp_obj = lstbLISTPHONE.SelectedItem as Phone;
					AddPhone.Tag = temp_obj;
					var res = AddPhone.ShowDialog();
					if (res == DialogResult.OK)
					{
						//если мы получили ответ что нужно отредактировать запись, то пересохраняем поля
						temp_obj = AddPhone.Tag as Phone;						
						lstbLISTPHONE.Items.Remove(lstbLISTPHONE.SelectedItem);
						lstbLISTPHONE.Items.Insert(0, temp_obj);
						//из массива телефонов не перезаписываю обьект, поскольку мы распокавали выделенные обьект, и через ссылочный тип посути перезаписали обьект
						//а вот чтобы отобразить перезаписанынй обьект на экране, в лст боксе удалил и вставил
						if (searching)
						{
							RefReshItems();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			lstbLISTPHONE_DoubleClick(this, null);
		}

		/// <summary>
		/// обновление после поискового запроса
		/// </summary>
		void RefReshItems()
		{
			lstbLISTPHONE.Items.Clear();
			foreach (var item in phones)
			{
				lstbLISTPHONE.Items.Add(item);
			}
		}






		private void btnDel_Click(object sender, EventArgs e)
		{
			try
			{
				if (lstbLISTPHONE.SelectedIndices.Count != ListBox.NoMatches && lstbLISTPHONE.SelectedIndices.Count > 0)
				{
					
					var res = MessageBox.Show("Вы действительно хотите удалить?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					if (res == DialogResult.Yes)
					{
						if (!searching)
						{
							for (int i = 0; i < lstbLISTPHONE.SelectedIndices.Count; i++)
							{
								phones.RemoveAt(lstbLISTPHONE.SelectedIndices[i]);
								lstbLISTPHONE.Items.RemoveAt(lstbLISTPHONE.SelectedIndices[i]);
								i--;
							}
						}
						else
						{
							//если я вывел данные после поиска и удалял/изменял их у меня текущий листбокс не обновленный == обновляю его
							for (int i = 0, c = 0; i < lstbLISTPHONE.SelectedIndices.Count; i++, c++)
							{
								phones.Remove(obj.ElementAt(i));
								lstbLISTPHONE.Items.RemoveAt(lstbLISTPHONE.SelectedIndices[i]);
								i--;
							}
							RefReshItems();
							searching = false;
						}
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Del", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				if (phones.Count > 0)
				{				
					var res = searchForms.ShowDialog();
					if (res == DialogResult.OK)
					{
						int a = int.Parse(searchForms.Tag.ToString());
						switch (a)
						{
							case 1: obj = phones.Where(s => s.Name == searchForms.SearchText); break;
							case 2: obj = phones.Where(s => s.Price == double.Parse(searchForms.SearchText)); break;
							case 3: obj = phones.Where(s => s.Color_phone == searchForms.SearchText); break;
							case 4: obj = phones.Where(s => s.Producer == searchForms.SearchText); break;
							case 5: obj = phones.Where(s => s.Phone_width == int.Parse(searchForms.SearchText)); break;
							case 6: obj = phones.Where(s => s.Phone_height == int.Parse(searchForms.SearchText));  break;
							default:
								break;
						}
						if (obj.Count() > 0)
						{
							lstbLISTPHONE.Items.Clear();
							foreach (var item in obj)
							{
								lstbLISTPHONE.Items.Add(item);
							}
							searching = true;
						}
						else MessageBox.Show("No results", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else MessageBox.Show("No results", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DateTime_Tick(object sender, EventArgs e)
		{
			dateTimePicker1.Value = DateTime.Now;
			TimeSpan a = DateTime.Now - startt;
			LBLuptime.Text = a.Hours + ":" + a.Minutes + ":" + a.Seconds;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			var res = MessageBox.Show("Вы действительно хотите выйти?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (res != DialogResult.Yes)
			{
				e.Cancel = true;
			}
		}

		private void MainForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (move)
			{
				this.Top = this.Top + (Cursor.Position.Y - posy);
				this.Left = this.Left + (Cursor.Position.X - posx);
				posx = Cursor.Position.X;
				posy = Cursor.Position.Y;

			}
		}

		private void MainForm_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (move) move = false;
			}
		}




		private void btnSort_Click(object sender, EventArgs e)
		{
			var res = sortForm.ShowDialog();
			if (res == DialogResult.OK)
			{
				if (phones.Count < 2)
				{
					return;
				}
				int a = int.Parse(sortForm.Tag.ToString());
				switch (a)
				{
					case 1: phones.Sort((u1, u2) => u1.Name.CompareTo(u2.Name)); break;
					case 2: phones.Sort((s, s1) => s.Producer.CompareTo(s1.Producer)); break;
					case 3:
						phones.Sort((s, s1) =>
						{
							if (s.Price < s1.Price) return 1;
							else if (s.Price > s1.Price) return -1;
							else return 0;
						}); break;
					case 4:
						phones.Sort((s, s1) =>
						{
							if (s.Color_phone.Length < s1.Color_phone.Length) return 1;
							else if (s.Color_phone.Length > s1.Color_phone.Length) return -1;
							else return 0;
						}); break;
					case 5:
						phones.Sort((s, s1) =>
						{
							if (s.Phone_width < s1.Phone_width) return 1;
							else if (s.Phone_width > s1.Phone_width) return -1;
							else return 0;
						}); break;
					case 6:
						phones.Sort((s, s1) =>
						{
							if (s.Phone_height < s1.Phone_height) return 1;
							else if (s.Phone_height > s1.Phone_height) return -1;
							else return 0;
						}); break;

					default:
						break;
				}
				RefReshItems();
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			RefReshItems();
		}

		private void btnexit_Click(object sender, EventArgs e)
		{			
				Close();			
		}

	

		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				posx = Cursor.Position.X;
				posy = Cursor.Position.Y;
				move = true;
			}
		}


	}
}
