using System;

namespace s3l6
{
    class Program
    {
        static void Main(string[] args)
        {

			
			Ball Ball1 = new Ball(1, 1, "One");
			/*Point Point1 = new Point(2, 2);

			Console.WriteLine("3) Продемонстрировать перегрузку метода... ");

			Point1.Display();
			Ball1.Display();
			Point1.MyLocation();
			Ball1.MyLocation();

			Console.WriteLine("\n6) Заменить методы Display используя метод ToString для C#\n");
			Console.WriteLine("Данные мяча: " + Ball1.ToString());

			*///

			Console.WriteLine("8) Придумать разумное использовани абстрактного класса и создать его. \nПродемонстрировать его использование;\n");
			Ball1.InpData();
			Console.WriteLine();
			Ball1.Display();



			//Ball1.Display();


			/*
			Console.WriteLine("Лабораторная 10\n");
			Console.WriteLine("Значение в отрезке [0;15]\n");
			Rating Rating1 = new Rating(-5);
			Console.WriteLine("Текущее значение: " + Rating1.GetPoints());
			Rating1.SetPoint(16);
			Console.WriteLine("Текущее значение: " + Rating1.GetPoints());
			Rating1.SetPoint(14);
			Console.WriteLine("Текущее значение: " + Rating1.GetPoints());
			Rating1.PlusRating();
			Console.WriteLine("Текущее значение: " + Rating1.GetPoints());
			Rating1.PlusRating();
			Console.WriteLine("Текущее значение: " + Rating1.GetPoints());

			/*
			Coin[] Coin1 = new Coin[3]; 
			Coin[,] Coin2 = new Coin[2, 2];

			Coin1[0] = new Coin(3,3);
			Coin1[1] = new Coin(4,4);
			Coin1[2] = new Coin(5,5);

			for (int i = 0; i < 2; i++)
				for (int j = 0; j < 2; j++)
					Coin2[i, j] = new Coin(j,j+2);

			// Вывод
			Console.WriteLine("Одномерный массив размером [3]");
			for (int i = 0; i < 3; i++)
				Coin1[i].Display();

			Console.WriteLine("\nДвумерный массив размером [2][2]");
			for (int i = 0; i < 2; i++)
				for (int j = 0; j < 2; j++)
					Coin2[i, j].Display();


			/*
            Ball MyBall = new Ball();
			Platform MyPlatform = new Platform();
            Rating MyRating = new Rating();
            Button MyButton = new Button();

			Coin[] masCoin = new Coin[5];
			for (int i = 0; i < 5; i++)
			{
				masCoin[i] = new Coin();
				masCoin[i].RandXY();
			}

			Console.WriteLine("Лабораторная 9");
			Console.WriteLine("МЯЧ:");

			Ball Ball1 = new Ball();
			Ball Ball2 = new Ball("Круглый");
			Ball Ball3 = new Ball(1, 1, "Один");

			Console.WriteLine();
			Console.WriteLine("1) Конструктор без параметров:");
			Ball1.Display();
			Console.WriteLine("\n2) Конструктор с 1-им параметром:");
			Ball2.Display();
			Console.WriteLine("\n3) Конструктор с параметрами:");
			Ball3.Display();
			Console.WriteLine("\n\n");

			///////////////
			Console.WriteLine("ПЛАТФОРМА:");

			Platform Platform1 = new Platform();
			Platform Platform2 = new Platform(2);
			Platform Platform3 = new Platform(1,1);

			Console.WriteLine();
			Console.WriteLine("1) Конструктор без параметров:");
			Platform1.Display();
			Console.WriteLine("\n2) Конструктор с 1-им параметром:");
			Platform2.Display();
			Console.WriteLine("\n3) Конструктор с параметрами:");
			Platform3.Display();
			Console.WriteLine("\n\n");

			///////////
			Console.WriteLine("МОНЕТА:");

			Coin Coin1 = new Coin();
			Coin Coin2 = new Coin(3);
			Coin Coin3 = new Coin(2, 3);

			Console.WriteLine();
			Console.WriteLine("1) Конструктор без параметров:");
			Coin1.Display();
			Console.WriteLine("\n2) Конструктор с 1-им параметром:");
			Coin2.Display();
			Console.WriteLine("\n3) Конструктор с параметрами:");
			Coin3.Display();
			Console.WriteLine("\n\n");

			////////
			Console.WriteLine("РЕЙТИНГ:");

			Rating Rating1 = new Rating();
			Rating Rating2 = new Rating(10);
			Rating Rating3 = new Rating(3, masCoin);

			Console.WriteLine();
			Console.WriteLine("1) Конструктор без параметров:");
			Rating1.Display();
			Console.WriteLine("\n2) Конструктор с 1-им параметром:");
			Rating2.Display();
			Console.WriteLine("\n3) Конструктор с параметрами:");
			Rating3.Display();
			Console.WriteLine("\n\n");

			////////////
			Console.WriteLine("КНОПКА:");

			Button Button1 = new Button();
			Button Button2 = new Button(true);

			Console.WriteLine();
			Console.WriteLine("1) Конструктор без параметров:");
			Button1.Display();
			Console.WriteLine("\n2) Конструктор с 1-им параметром:");
			Button2.Display();
			Console.WriteLine("\n\n");

			/////////////
			Coin[] CoinArr = new Coin[3];
			for (int j = 0; j < 3; j++)
				CoinArr[j] = new Coin(j);
			Console.WriteLine("\nИнициализировать небольшой массив конструктором с одним параметром:");
			for (int j = 0; j < 3; j++)
				CoinArr[j].Display();
			Console.WriteLine("\n\n");


			//////////////
			Console.WriteLine("Продемонстрировать различие между мелким и глубоким копированием:");
			Coin CoinTestCopy1 = new Coin(4,4), CoinTestCopy2 = new Coin(5,5);

			CoinTestCopy2 = CoinTestCopy1;

			Console.WriteLine("Поверхностная копия 1-го объекта во 2-ой:");
			CoinTestCopy1.Display();
			CoinTestCopy2.Display();
			Console.WriteLine("");
			Console.WriteLine("Изменение 1-го объекта, а 2-ой не трогается:");
			CoinTestCopy1.Set(3,3);
			CoinTestCopy1.Display();
			CoinTestCopy2.Display();
			Console.WriteLine("");

			CoinTestCopy1.Set(4,4);
			CoinTestCopy2 = CoinTestCopy1.DeepCopy();

			Console.WriteLine("Глубокая копия 1-го объекта во 2-ой:");
			CoinTestCopy1.Display();
			CoinTestCopy2.Display();
			Console.WriteLine("");
			Console.WriteLine("Изменение 1-го объекта, а 2-ой не трогается:");
			CoinTestCopy1.Set(3,3);
			CoinTestCopy1.Display();
			CoinTestCopy2.Display();
			Console.WriteLine("\n\n");



			/*
			Console.Write("\nЛаба 8. Модифицировать проект путем добавления в один из классов \nкак минимум одного статического поля и одного статического метода:");
			Console.Write("На примере класса Мяч, двусвязанный список\n\n");

			Ball[] balls = new Ball[3];
			for (int j = 0; j < 3; j++)
				balls[j] = new Ball();
			// Формирование объектов класса Ball:
			balls[0].Set(1,1, "One");
			balls[1].Set(2, 2, "Two");
			balls[2].Set(3, 3, "Three");

			Console.Write("\nВызов статической компанентной функции: 'Новый список'\n");
			balls[0].NewList();

			Console.Write("\nВызов статической компанентной функции: 'Напечатать список'\n");
			// Вызов статической компанентной функции:
			balls[2].reprint();

			Console.Write("\n\nДобавление элементов в список.\n\n");
			// Включение созданных компанентов в двусвязанный список:
			balls[0].Add(); balls[1].Add(); balls[2].Add();

			Console.Write("\nВызов статической компанентной функции: 'Напечатать список'\n");
			// Печать в обратном порядке значений элементов списка:
			balls[2].reprint();

			

			/*
			Console.Write("\nData Ball:\n");
			MyBall.Set(0, 0, "BOSS");
			MyBall.Display();

			
			//Platform
			Console.Write("\nData Platform:\n");
			MyPlatform.Set(25, 10);
			MyPlatform.Display();
			

			Console.Write("\n\nData Rating:\n");
			MyRating.Set(4, MyArrayCoins);
			MyRating.Display();

			
			//Button
			Console.Write("\nData Button:\n");
			MyButton.Set(false);
			MyButton.Display();
			

			Console.Write("\n\nIndividual functions:\n");
			Console.Write("\nTake a ball step:\n");
			MyBall.MoveBall();
			MyBall.Display();

			Console.Write("\nRandom changing the platform angle:\n");
			MyPlatform.RandRotate();
			MyPlatform.Display();


			
			Console.Write("\n\nEntering data using the example of a ball:\n");
			MyBall.InpData();
			Console.Write("\nNew data Ball:\n");
			MyBall.Display();
			*/
		}
	}
}
