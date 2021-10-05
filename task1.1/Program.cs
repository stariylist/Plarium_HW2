using System;

//номер по списку 11 -> вариант №1
namespace task1._1
{
    /*1.1 Написать программу,  которая введет семь значений и
    посчитает сумму целых чисел, делящихся на 3 без остатка.*/
    class Program
    {
        public static int function(int num)
        {
            int sum = 0; //переменная суммы
            int[] array = new int[num];//массив на 7 элементов
            Random rand = new Random();
            Console.WriteLine("Массив на 7 элементов: ");
            for (int i = 0; i < num; i++)
            {
                array[i] = rand.Next(-20,50); //заполнение массива случайными числами
                Console.Write(array[i] + " "); // вывод массива
            }
            for(int i = 0; i < num; i++)
            {
                if (array[i] % 3 == 0)//проверка на кратность 3
                {
                    sum += array[i];//подсчет суммы
                }
            }
            return sum; //возвращает сумму
        }
        static void Main(string[] args)
        {
            int num = 7;//кол-во элементов массива
            Console.WriteLine("\nСумма элементов, делящихся на 3 без остатка = "+function(num));
        }
    }
}
