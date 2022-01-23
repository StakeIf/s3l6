using System;
using System.Collections.Generic;
using System.Text;

namespace s3l6
{
	class Ball : Point
	{
		private String Name = "";

		private static Ball lastBall;
		private Ball prev;
		private Ball next;

		
		public string name
		{
			get => Name;
			set => Name = value;
		}

		//Конструктор
		public Ball(): base()
		{
			Name = "";
		}

		public Ball(String name) : base()
		{
			//x = 0;
			//y = 0;
			Name = name;
		}

		//Конструктор с параметрами
		public Ball(int x_, int y_, String name): base(x_,y_)
		{
			Name = name;
		}

		public void SetName(String name)
		{
			Name = name;
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
		public override void InpData() 
		{
			base.InpData();
			Console.Write("Input Name: ");
			Name = Console.ReadLine();
		}

		//Вывод данных о Мяче
		public void Display()
		{
			Console.Write("X = " + x + " Y = " + y + " Name - " + Name + "\n");
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
		// Виртуальная/не виртуальная функция вывода, что за объект
		public override string Who()
        {
			return "Мяч ";
        }
		public String ToString()
        {
			return ("X = " + x + " Y = " + y + " Name - " + Name + "\n");
		}
	}
}
