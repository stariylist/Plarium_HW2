using System;
/*Найти расположение (индекс) наибольшего числа в массиве. 
  Если таких чисел несколько, найти индекс первого из них.*/
namespace task3._1
{
    class Program
    {
        public static int[] fill_array(int num)//заполнение массива
        {
            Random rand = new Random();//случайные значения
            int[] array = new int[num];//инициализация массива
            for (int i = 0; i < num; i++)
            {
                array[i] = rand.Next(-20, 50);//заполнение
            }
            return array;//возвращаем массив
        }

        public static void show_array(int [] array)//вывод массива
        {
            Console.Write("Массив элементов: ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");//ну тут все понятно
            }
        }

        public static void find_max(int [] array)
        {
            int index = 0;//индекс максимального элемента
            int max = array[index];//максимальный элемент массива
            for(int i = 0; i < array.Length; i++)
            {
                if (max < array[i])//если максимальный элемент меньше следующего
                {
                    max = array[i];//то максимальный = следующий
                    index = i;//индекс тоже
                }
            }
            Console.WriteLine("\nМаксимальный элемент массива = " + max);
            Console.WriteLine("Индекс максимального элемента = " + index);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int num = int.Parse(Console.ReadLine());
            show_array(fill_array(num));
            find_max(fill_array(num));
        }
    }
}
