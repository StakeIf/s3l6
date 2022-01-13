using System;
using System.Collections.Generic;
using System.Text;

namespace s3l6
{
	//Монета
	public class Coin
	{
		private int x = 0;
		private int y = 0;


		//Конструктор
		public Coin()
		{
			x = 0;
			y = 0;
		}

		//Ф-ии получения данных из полей
		public int GetX()
		{
			return x;
		}
		public int GetY()
		{
			return y;
		}

		//Задание полей класса Монета
		public void Set(int xi, int yi)
		{
			x = xi;
			y = yi;
		}

		//Ввод данных о Монете
		public void InpData()
		{
			Console.Write("Input x");
			x = Convert.ToInt32(Console.ReadLine());
			Console.Write("Input y");
			y = Convert.ToInt32(Console.ReadLine());
		}

		//Случайный ввод координат монеты
		public void RandXY()
		{
			Random rand = new Random();
			x = rand.Next(10);
			y = rand.Next(10);
		}


		//Вывод данных о Монете
		public void Display()
		{
			Console.Write("X = " + x + " Y = " + y + "\n");
		}
	}
}
