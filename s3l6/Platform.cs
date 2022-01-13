using System;
using System.Collections.Generic;
using System.Text;

namespace s3l6
{
	//Платформе
	public class Platform
	{
		private int angle = 0;
		private int height = 0;

		//Конструктор
		public Platform()
		{
			angle = 0;
			height = 0;
		}

		//Ф-ии получения данных из полей
		public int GetAngle()
		{
			return angle;
		}
		public int GetHeight()
		{
			return height;
		}

		//Задание полей класса Платформа
		public void Set(int anglei, int heighti)
		{
			angle = anglei;
			height = heighti;
		}

		//Ввод данных о Платформе
		public void InpData()
		{
			Console.Write("Input angle");
			angle = Convert.ToInt32(Console.ReadLine());
			Console.Write("Input height");
			height = Convert.ToInt32(Console.ReadLine());
		}


		//Вывод данных о Платформе
		public void Display()
		{
			Console.Write("angle = " + angle + " \nheight = " + height);
		}

		//Случайное изменение угла
		public void RandRotate()
		{
			Random rand = new Random();
			angle = rand.Next(10);
		}

	}
}
