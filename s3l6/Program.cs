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
