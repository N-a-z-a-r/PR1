using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Tabul
    {
        //Поле з результуючим масивом
        public double[,] xy = new double[1000, 21];
        //Реальна кількість елементів в масиві
        public int n = 0;
        //Метод для обрахунку функцій
        private double f1(double x)
        {
            return x * x + Math.Sin(7 * x);
        }
        private double f2(double x)
        {
            return Math.Abs(Math.Pow(x, 3) + Math.Pow(10, x));
        }
        private double f3(double x)
        {
            return Math.Abs(Math.Pow(2 * Math.Pow(x, 4) + x * x + 1, 1.0 / 7.0));
        }
        //Метод табулювання
        public void tab(double xn = -1.7, double xk = 45.3, double h = 0.1, double a = 0.3)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                        y = f3(x);
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}
