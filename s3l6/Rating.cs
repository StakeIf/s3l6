using System;
using System.Collections.Generic;
using System.Text;

namespace s3l6
{
	//Рейтинг
	public class Rating
	{
		private int points = 0;
		private Coin[] ArrayCoins = new Coin[5];


		//Конструктор
		public Rating()
		{
			points = 0;
			Coin C = new Coin();
			C.Set(0, 0);
			for (int i = 0; i < 5; i++)
				ArrayCoins[i] = C;
		}

		//Конструктор с 1 параметром
		public Rating(int points)
		{
			this.points = 0;
			if (IsRightRating(points))
				this.points = points;
			Coin C = new Coin();
			for (int i = 0; i < 5; i++)
				ArrayCoins[i] = C;
		}
		
		//Конструктор с параметрами
		public Rating(int pointsi, Coin[] array)
		{
			points = 0;
			if (IsRightRating(pointsi))
				points = pointsi;
			Coin C = new Coin();
			for (int i = 0; i < 5; i++)
				ArrayCoins[i] = array[i];
		}

		//Задание поля Очки
		public void SetPoint(int pointsi)
		{
			points = 0;
			if (IsRightRating(pointsi))
				points = pointsi;
		}

		//Задания поля Монеты
		public void SetCoinArray(Coin[] array)
		{
			Coin C;
			for (int i = 0; i < 5; i++)
				ArrayCoins[i] = array[i];
		}

		//Ф-ии получения данных из полей
		public int GetPoints()
		{
			return points;
		}


		//Задание полей класса 
		public void Set(int pointsi, Coin[] array)
		{
			points = 0;
			if (IsRightRating(pointsi))
				points = pointsi;

			for (int i = 0; i < 5; i++)
				ArrayCoins[i] = array[i];
		}

		//Вывод рейтинга
		public void Display()
		{
			Console.Write("Points = {0}\n", points);
			Console.Write("Coins: \n");
			for (int i = 0; i < 5; i = i + 1)
				ArrayCoins[i].Display();
		}

		//Увеличение рейтинга на 1
		public void PlusRating()
		{
			points++;
			if (IsRightRating(points) == false)
				points--;
		}

		// Проверка числа на подходяее 
		public bool IsRightRating(int Rating)
		{
			bool res = true;
			try                                                    // ищем исключения внутри этого блока и отправляем их в соответствующий обработчик catch
			{
				if (Rating < 0 || Rating > 15)                          // Если пользователь ввел неверное число, то выбрасывается исключение
					throw new Exception("Incorrect value.");       // выбрасывается исключение типа const char*
				return res;
			}
			catch (Exception ex)           // обработчик исключений типа const char*
			{
				Console.WriteLine("\nError: " + ex.Message + '\n');
				res = false;
				return res;
			}
		}

	}
}
