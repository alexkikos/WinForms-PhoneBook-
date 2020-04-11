using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace Phone_WinForms
{
	[Serializable]
	public class Phone
	{
	
		string name;
		double price;
		string color_phone;
		string producer;
		int phone_width;
		int phone_height;



		public string Name { get => name; set => name = value; }
		public double Price { get => price; set => price = value; }
		public string Color_phone { get => color_phone; set => color_phone = value; }
		public string Producer { get => producer; set => producer = value; }
		public int Phone_width { get => phone_width; set => phone_width = value; }
		public int Phone_height { get => phone_height; set => phone_height = value; }

	

		public override string ToString()
		{
			return "Имя: " + name + "| Производитель: " + producer + "| Цена: " + price + "| Цвет: " + color_phone + "| Ширина: " + phone_width + "| Высота:" + Phone_height;
		}
	}
}
