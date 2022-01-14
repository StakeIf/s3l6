using System;
using System.Collections.Generic;
using System.Text;

namespace s3l6
{
	class Ball
	{
		private int x = 0;
		private int y = 0;
		private String Name = "";

		private static Ball lastBall;
		private Ball prev;
		private Ball next;

		public int X
		{
			get => x;
			set => x = value;
		}
		public int Y
		{
			get => y;
			set => y = value;
		}
		public string name
		{
			get => Name;
			set => Name = value;
		}

		//Конструктор
		public Ball()
		{
			x = 0;
			y = 0;
			Name = "";
		}

		public Ball(int x_s, int y_s, string Name_s)
		{
			this.x = x_s;
			this.y = y_s;
			this.Name = Name_s;
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
		public String GetName()
		{
			return this.Name;
		}

		//Задание полей класса Мяч
		public void Set(int xi, int yi, String Namei)
		{
			x = xi;
			y = yi;
			this.Name = Namei;
		}
		//Ввод данных о Мяче
		public void InpData()
		{
			Console.Write("Input x: ");
			x = Convert.ToInt32(Console.ReadLine());
			Console.Write("Input y: ");
			y = Convert.ToInt32(Console.ReadLine());
			Console.Write("Input Name: ");
			Name = Console.ReadLine();
		}

		//Вывод данных о Мяче
		public void Display()
		{
			Console.Write("\nX = " + x + " Y = " + y + " Name - " + Name + "\n");
		}
		public void MoveBall()
		{
			Console.Write("\nPress \n  'D' to increase the x value \n  'A' to decrease the x value\n  'W' to increase the y value\n  'S' to decrease the y value \n");
			string k = Console.ReadLine();
			char key = k[0];
			if (key == 'a')
				x--;
			if (key == 'd')
				x++;
			if (key == 'w')
				y++;
			if (key == 's')
				y--;
		}


		// Новый список
		public void NewList()
		{
			lastBall = null;
		}

		// Добавление элемента в конец списка
		public void Add()
		{
			if (lastBall == null)
				this.prev = null;
			else
			{
				lastBall.next = this;
				prev = lastBall;
			}
			lastBall = this;
			this.next = null;
		}

		// Вывод на дисплей содержимого списка
		public void reprint()
		{
			Ball uk;   // Вспомогательная ссылка
			uk = lastBall;
			if (uk == null)
			{
				Console.WriteLine("Список пуст!");
				return;
			}
			else
				Console.WriteLine("\nСодержимое списка:\n");

			// Цикл печати в обратном порядке значений элементов списка:
			while (uk != null)
			{
				Console.WriteLine(uk.GetX() + " " + uk.GetY() + " " + uk.GetName() + " " + "\t");
				uk = uk.prev;
			}
		}

		public void ModernName()
		{
			Name = "Ball " + Name;
		}

	}
}
