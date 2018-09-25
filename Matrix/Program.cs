using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            byte y;
            Matrix x = new Matrix();
            Matrix x1 = new Matrix();

            Console.Clear();
            Label1:
            

            Console.WriteLine("Какие действия желаете произвести с матрицами ?\n" +
                "Вывести на консоль 1ю матрицу - нажмите \"1\"\n"
                + "Вывести на консоль 2ю матрицу - нажмите \"2\"\n"
                + "Произведение матриц - нажмите \"3\"\n"
                + "Возведение матрицы в степень - нажмите \"4\"\n"
                + "Транспонирование матрицы - нажмите \"5\"\n"
                + "Умножение матрицы на число - нажмите \"6\"\n"
                + "Сложение 2х матриц - нажмите \"7\"\n"
                + "Вычитание 2х матриц - нажмите \"8\"\n"
                + "Для завершения программы - нажмите \"9\"\n");


            string str = Console.ReadLine();
            y = Convert.ToByte(str);

            switch (y)
            {
                case 1:
                    Console.WriteLine(x);
                    goto Label1;

                case 2:
                    Console.WriteLine(x1);
                    goto Label1;

                case 3:
                    Console.WriteLine(x * x1);
                    goto Label1;

                case 4:
                    Console.WriteLine("Введите степень матрицы => ");
                    int n = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine(x ^ n);
                    goto Label1;

                case 5:
                    x.Transportir_Matrix();
                    Console.WriteLine(x);
                    goto Label1;

                case 6:
                    Console.WriteLine("Введите число для умножения матрицы => ");
                    int u = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine(x ^ u);
                    goto Label1;

                case 7:
                    Console.WriteLine(x + x1);
                    goto Label1;

                case 8:
                    Console.WriteLine(x - x1);
                    goto Label1;

                case 9:
                    break;





            }


        }
    }
}
