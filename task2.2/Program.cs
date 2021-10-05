using System;
//Дано натуральное число. Определить количество цифр в нем;
namespace task2._2
{
    class Program
    {
        public static bool proverka(long num) //функция проверки на положительность числа
        {
            if (num > 0)
                return true;
            else
                return false;
        }
        public static int function(long num)
        {
            int k = 0; //счетчик цифр
            while (num != 0)//пока не равно 0
            {
                k += 1;//считаем кол-во цифр
                num /= 10;//убираем последнюю цифру у числа
            }
            return k;//возвращаем кол-во цифр
        }
        static void Main(string[] args)
        {
            Console.Write("Введите любое натуральное число: ");
            long num = long.Parse(Console.ReadLine());//перевод строки в long
            if (proverka(num))//проверяем на положительность
            {
                Console.WriteLine("Количество цифр в числе "+num+" = "+ function(num));
            }
            else//если отрицательное число
            {
                Console.WriteLine("Вы ввели не натуральное число!");
            }
        }
    }
}
