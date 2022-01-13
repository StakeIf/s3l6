using System;
using System.Collections.Generic;
using System.Text;

namespace s3l6
{
	//Платформе
	public class Button
	{
		private bool OnOff;

		//Конструктор
		public Button()
		{
			OnOff = false;
		}

		//Ф-ии получения данных из полей
		public bool GetButton()
		{
			return OnOff;
		}

		//Задание полей класса кнопка
		public void Set(bool onoffi)
		{
			OnOff = onoffi;
		}

		//Вывод данных о кнопке
		public void Display()
		{
			if (OnOff == true)
				Console.Write("Button pressed");
	else
				Console.Write("Button NOT pressed");
		}

		//Нажатие кнопки
		public void RandRotate()
		{
			if (OnOff == true)
				OnOff = false;
			else
				OnOff = true;
		}

	}
}
