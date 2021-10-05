using System;
/*Дана целочисленная прямоугольная матрица. Определить:
количество строк, не содержащих ни одного нулевого элемента;
максимальное из чисел, встречающихся в заданной матрице более одного раза.*/
namespace task3._4
{
    class Program
    {
        public static int[,] fill_array(int n)
        {
            Random rand = new Random();//случайные значения для заполнения
            int[,] array = new int[n,n];//инициализация двумерного массива
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    array[i, j] = rand.Next(-2, 10);//заполнение массива
                }
            }
            return array;//возвращаем массив
        }

        public static void show_array(int [,] array)
        {
            Console.WriteLine("\t~~~Исходная матрица~~~");
            for (int i = 0; i < Math.Sqrt(array.Length); i++)//так как я не передаю размерность матрицы
            {
                for (int j = 0; j < Math.Sqrt(array.Length); j++)//то я использую квадратный корень длинны массива, т.к. матрица прямоугольная
                {
                    Console.Write(array[i, j] + "\t");//вывод элементов с табуляцией
                }
                Console.WriteLine();
            }
        }
        public static void function(int n)
        {
            int[,] array = fill_array(n);//заполняем двумерный массив с помощью функции
            show_array(array);//выводим массив на экран с помощью функции
            int strZero=0, strTotal=0;//нулей в строке, строк с нулевыми элементами
            int maxElem = 0, maxAppear = 0;//текущий максимальный элемент, его колличество
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (array[i, j] == 0) strZero++;//если находим 0 в строке, то увеличиваем переменную на 1
                }
                Console.WriteLine("Строка {0} содержит {1} нулевых элементов", (i + 1), strZero);
                if (strZero == 0)//если нулей в строке нет
                {
                    strTotal++;//мы увеличиваем счетчик ненулевых строк
                }
                else
                {
                    strZero = 0;//иначе сбрасываем счетчик нулей в строках
                }
            }
            Console.WriteLine("Таким образом матрица содержит {0} строк(и), не содержащих нулевой элемент!", strTotal);
            
            for (int i = 0; i < n; i++)//тут мы снова проходи весь массив
            {
                for (int j = 0; j < n; j++)//не стал писать это в предыдущем цикле, т.к. сам бы запутался
                {
                    if (array[i, j] == maxElem)//если элемент массива == текущему максимуму
                    {
                        maxAppear++;//увеличиваем счетчик колличества
                    }

                    else if (array[i, j] > maxElem)//если элемент массива > текущего максимума
                    {
                        maxElem = array[i, j];//присваеваем текущему максимуму его значение
                        maxAppear = 1;//ну и колличество его встреч ставим в 1, так как сменился максимум
                    }

                }
            }
            while (maxAppear < 2)//пока не нашли максимум, что встречается более 1го раза
            {
                if (maxAppear <= 1)
                {
                    Console.WriteLine("Максимальный элемент: {0} отбрасываем, так как он встречается в матрице 1 раз!", maxElem);
                    int maxElemPrevious = maxElem;//создаем переменную прошлого максимума
                    maxElem = 0;//сбрасываем в 0
                    maxAppear = 0;
                    for (int i = 0; i < n; i++)//опять проходим массив т.к. ищем второй максимум
                    {
                        for (int j = 0; j < n; j++)
                        {//если элемент массива = текущему максимуму и меньше предыдущего
                            if ((array[i, j] == maxElem) && (array[i, j] < maxElemPrevious))
                            {
                                maxAppear++;//мы увеличиваем колличество встреч
                            }
                            //если текущий элемент больше текущего максимума и меньше предыдущего
                            else if ((array[i, j] > maxElem) && (array[i, j] < maxElemPrevious))
                            {
                                maxElem = array[i, j];// мы присваеваем текущему максимуму - текущий элемент массива
                                maxAppear = 1; // кол-во встреч в 1
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Максимальный элемент: {0}, встречается {1} раз(а)!", maxElem, maxAppear);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размерность матрицы: ");
            int n = int.Parse(Console.ReadLine());
            function(n);
        }
    }
}
