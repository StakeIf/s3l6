using System;
using System.Collections.Generic;
using System.Text;

namespace s3l6
{
	//Монета
	public class Coin : Point
	{
		//Конструктор
		public Coin()
		{
			x = 0;
			y = 0;
		}

		public Coin(int x)
		{
			this.x = x;
			y = 0;
		}

		public Coin(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		// Поверхностная копия
		public Coin ShallowCopy()
		{
			return (Coin)this;
		}

		// Глубокая копия
		public Coin DeepCopy()
		{
			Coin other = (Coin)this.MemberwiseClone();
			other.Set(x,y);
			return other;
		}

		//Случайный ввод координат монеты
		public void RandXY()
		{
			Random rand = new Random();
			x = rand.Next(10);
			y = rand.Next(10);
		}


		//Вывод данных о Монете
		public override void Display()
		{
			Console.Write("Coin data:\nX = " + x + " Y = " + y + "\n");
		}

		// Виртуальная/не виртуальная функция вывода, что за объект
		public override string Who()
		{
			return "Монета ";
		}
	}
}
