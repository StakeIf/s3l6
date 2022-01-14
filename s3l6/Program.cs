using System;

namespace s3l6
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball MyBall = new Ball();
			Platform MyPlatform = new Platform();
            Rating MyRating = new Rating();
            Button MyButton = new Button();


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
