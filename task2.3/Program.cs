using System;
//Составить программу нахождения цифрового корня натурального числа.
namespace task2._3
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

        public static long function(long num)
        {
            long sum = 0; //переменная суммы
            if ((num / 10) == 0) // если число состоит из 1 цифры, мы его и возвращаем
            {
                return num;
            }
            else
            {
                while (num > 0)//пока число больше 0
                {
                    sum += num % 10;// добавляем в сумму последнюю цифру числа
                    num /= 10; // убираем последнюю цифру числа
                    if (num == 0 && sum > 9) // если у нас число уже закончилось, но сумма все еще не 1 цифра
                    {
                        num = sum; // мы изначальному числу присваеваем сумму
                        sum = 0; // а сумме 0 т.е. считай повторяем заново алгоритм, но с другим числом, а именно уже нашей суммой
                    }
                }
                return sum; // ну и возвращаем сумму
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите любое натуральное число: ");
            long num = long.Parse(Console.ReadLine());//перевод строки в long
            if (proverka(num))//проверяем на положительность
            {
                Console.WriteLine("Цифровой корень числа " + num + " = " + function(num));
            }
            else//если отрицательное число
            {
                Console.WriteLine("Вы ввели не натуральное число!");
            }
        }
    }
}
