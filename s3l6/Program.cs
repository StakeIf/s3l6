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

			////////////
			Console.Write("10) Для полей добавить свойства и продемонстрировать работу с ними\n");
			Console.Write("\nНа примере класса Мяч:\n");
			Ball BigBall = new Ball();
			BigBall.X = 2;
			BigBall.Y = 3;
			BigBall.name = "VeryBig";
			BigBall.Display();

			////////////
			
			Console.Write("\n11) Cоздать массив объектов и продемонстрировать работу с ним\n");
			Console.Write("\nНа примере класса Монета:\n");
			Coin[] MyArrayCoins = new Coin[5];
			for (int i = 0; i < 5; i = i + 1)
			{
				MyArrayCoins[i] = new Coin();
				MyArrayCoins[i].RandXY();
				MyArrayCoins[i].Display();
			}

			////////////
			Console.Write("12) Заменить класс на структуру. Продемонстрировать различие между присваиванием объектов класса и структуры\n");
			Console.Write("На примере класса Мяч и структуры Платформа\n\n");
			Platform Arena = new Platform();
			Platform Arena2 = new Platform();
			Ball BallNikolay = new Ball();
			Arena.Set(15,10);
			BallNikolay.Set(3,3, "Three");
			Console.WriteLine("Элемент структуры до копирования:");
			Arena.Display();
			Console.Write("\n");
			Console.WriteLine("Элемент класса до копирования:");
			BallNikolay.Display();
			Console.Write("\n");
			Console.WriteLine("Элемент структуры копируется на:");
			Arena2.Display();
			Console.Write("\n");
			Console.WriteLine("Элемент класса копируется на:");
			BigBall.Display();
			Console.Write("\n");
			Arena = Arena2;
			BallNikolay = BigBall;
			Console.WriteLine("Элемент структуры после копирования:");
			Arena.Display();
			Console.Write("\n");
			Console.WriteLine("Элемент класса после копирования:");
			BallNikolay.Display();
			Console.Write("\n\n");
			Console.WriteLine("Если изменить те объекты, на которые менялись объект класса и структуры:");
			Arena2.Set(9,9);
			BigBall.Set(0,0, "Bro");
			Arena2.Display();
			BigBall.Display();
			Console.Write("\n");
			Console.WriteLine("То новые объектыбудут таковыми:");
			Arena.Display();
			BallNikolay.Display();
			Console.WriteLine("Объект класса изменился, потому что копируется ссылка \nна объект, а объект структуры не изменился, т.к. \nкопируются значения полей.");

			////////////
			Console.Write("\n13) Продемонстрировать работу с массивом объектов\n");
			Console.Write("На примере структуры Платформа\n");
			Platform[][] PlatformsTest = new Platform[1][];
			PlatformsTest[0] = new Platform[5];
			Console.Write("Массив платформ:\n");
			for (int j = 0; j < 5; j++)
			{
				PlatformsTest[0][j].Set(j + 1, j);
				PlatformsTest[0][j].Display();
				Console.Write("\n");
			}

			////////////

			Console.Write("14) Продемонстрировать возврат значения через параметр out и через\nпараметр ref. Показать различие этих механизмов\n");
			Console.Write("На примере структуры платформа\n");
			// Инициализация объектов структуры
			Platform PlatformForRef = new Platform();
			Platform PlatformForOut = new Platform();

			// Инициализация переменной для передачи по ref
			int ArgRef = 2;
			// Описание переменной для передачи по out
			int ArgOut;

			PlatformForRef.Set(60, 10);
			// Передача аргумента по ref
			PlatformForRef.TestRef4(ref ArgRef);
			Console.WriteLine("Аргумент функции после использования по ref: " + ArgRef);

			PlatformForOut.Set(70,5);
			// Передача аргумента по out
			PlatformForOut.TestOut5(out ArgOut);
			Console.WriteLine("Аргумент функции после использования по out: " + ArgOut);

			////////////

			Console.Write("\n15) Продемонстрировать разумное использование оператора this\n");
			Console.Write("На примере класса Мяч, двусвязанный список\n\n");

			Ball[] balls = new Ball[3];
			for (int j = 0; j < 3; j++)
				balls[j] = new Ball();
			// Формирование объектов класса Teacher:
			balls[0].Set(1,1, "One");
			balls[1].Set(2, 2, "Two");
			balls[2].Set(3, 3, "Three");

			balls[0].NewList();

			// Вызов статической компанентной функции:
			balls[2].reprint();

			// Включение созданных компанентов в двусвязанный список:
			balls[0].Add(); balls[1].Add(); balls[2].Add();

			// Печать в обратном порядке значений элементов списка:
			balls[2].reprint();

			////////////
			Console.Write("\n16) Продемонстрировать перегрузку операторов '+', '++'\n");
			Console.Write("На примере структуры Оценка\n");
			Platform Platform1 = new Platform();
			Platform Platform2 = new Platform();
			Console.Write("Платформа 1 и Платформа 2:\n");
			Platform1.Set(45,10);
			Platform2.Set(50,12);
			Platform1.Display();
			Platform2.Display();
			Console.Write("Сумма оценок через оператор \'+\':\n");
			Platform1 = Platform1 + Platform2;
			Platform2 = Platform1;
			Platform1.Display();
			Console.Write("Прибавление к сумме 1 через постфиксный оператор \'++\':\n ");
			(Platform1++).Display();
			Console.Write("Прибавление к сумме 1 через префиксный оператор \'++\':\n ");
			(++Platform2).Display();

			////////////
			Console.Write("\n17) Продемонстрировать обработку строк: ");
			MyBall.Set(0, 0, "BOSS");
			MyBall.Display();
			MyBall.ModernName();
			MyBall.Display();

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
