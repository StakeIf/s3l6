using System;
using System.Collections.Generic;
using System.Text;

namespace s3l6
{
	//Платформе
	public class Platform
	{
		private int angle;
		private int height;

		
		//Конструктор
		public Platform()
		{
			angle = 0;
			height = 0;
		}


		// Конструктор с одним параметром
		public Platform(int height)
		{
			angle = 0;
			this.height = height;
		}

		// Конструктор с параметрами
		public Platform(int angle, int height)
		{
			this.angle = angle;
			this.height = height;
		}

		//Установка угла
		public void SetAngle(int angle)
		{
			this.angle = angle;
		}
		//Установка длины
		public void SetHeight(int height)
		{
			this.height = height;
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
			Console.Write("angle = " + angle + " \nheight = " + height + "\n\n");
		}

		//Случайное изменение угла
		public void RandRotate()
		{
			Random rand = new Random();
			angle = rand.Next(10);
		}

		// Проверка возврата значения по ref
        public void TestRef4(ref int Value)
        {
            Value = 80;
        }

        // Проверка возврата значения по out
        public void TestOut5(out int Value)
        {
            Value = 90;
        }

		public static Platform operator +(Platform operand1, Platform operand2)
			=> new Platform(operand1.angle + operand2.angle, operand1.height + operand2.height);
		public static Platform operator ++(Platform operand1)
		=> new Platform(operand1.angle + 1, operand1.height + 1);
	}
}
