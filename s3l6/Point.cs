using System;
using System.Collections.Generic;
using System.Text;

interface ICoord
{
    // Ввод 
    void InpData();

    // Вывод 
    void Display();

    // Виртуальная/не виртуальная функция вывода что за объект
    string Who();
}

namespace s3l6
{
    public abstract class Point: ICoord
    {
        protected int x;
        protected int y;

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

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int X)
        {
            x = X;
        }
        public Point(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public void SetX(int X)
        {
            x = X;
        }
        public void SetY(int Y)
        {
            y = Y;
        }

        public void Set(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Ввод данных
        public virtual void InpData()
        {
            Console.Write("Input x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input y: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        //Вывод данных 
        public virtual void Display()
        {
            Console.Write("X = " + x + " Y = " + y + "\n");
        }

        // Виртуальная/не виртуальная функция вывода, что за объект
        public virtual string Who()
        {
            return "Точка ";
        }

        public void MyLocation()
        {
            Console.WriteLine(Who());
            Display();
        }
    }
}
