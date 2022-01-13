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

		//Ф-ии получения данных из полей
		public int GetPoints()
		{
			return points;
		}


		//Задание полей класса 
		public void Set(int pointsi, Coin[] array)
		{
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

		public void PlusRating()
		{
			points = points + 1;
		}
	}
}
