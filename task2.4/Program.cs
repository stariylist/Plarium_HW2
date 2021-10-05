using System;
/*Дано натуральное число. Если в нем есть цифры а и b, то определить, 
  какая из них расположена в числе правее. Если одна или обе эти цифры 
  встречаются в числе несколько раз, то должны быть рассмотрены последние из одинаковых цифр*/
namespace task2._4
{
    class Program
    {
        public static bool proverka(int num) //функция проверки на положительность числа
        {
            if (num > 0)
                return true;
            else
                return false;
        }
        public static int Lenght(int num)
        {
            int k = 0; //счетчик цифр
            while (num != 0)//пока не равно 0
            {
                k += 1;//считаем кол-во цифр
                num /= 10;//убираем последнюю цифру у числа
            }
            return k;//возвращаем кол-во цифр
        }

        public static int[] ToArray(int num) //разбиваем число на массив чисел
        { 
            int lenght = Lenght(num); //сколько цифр в числе
            int[] array = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
               array[lenght - i - 1] = num % 10; //записывам цифру в массив, начиная с конца
                num /= 10; //отбрасываем последнюю цифру
            }
            return array;
        }

        public static int find_index(int[] array, int digit)
        {
            for (int i = array.Length - 1; i >= 0; i--)//перебираем массив с конца
            {
                if (array[i] == digit)
                {
                    return i; // возвращаем индекс, если нашли совпадение
                }
            }
            return -1;//нужно дальше для проверки условий, типо если не нашли цифру в числе
        }

        static void Main(string[] args)
        {
            Console.Write("Введите любое натуральное число: ");
            int num = int.Parse(Console.ReadLine());//перевод строки в long
            if (proverka(num))//проверяем на положительность
            {
                Console.Write("Введите число a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите число b: ");
                int b = int.Parse(Console.ReadLine());
                if ((find_index(ToArray(num),a) > find_index(ToArray(num), b)) && find_index(ToArray(num), b)!=-1 )//если и а и b есть в числе
                {
                    Console.WriteLine("Цифра " + a + " в числе " + num + " находится правее, чем цифра " + b);
                }
                else if((find_index(ToArray(num), a) < find_index(ToArray(num), b)) && find_index(ToArray(num), a)!=-1)//если и а и b есть в числе
                {
                    Console.WriteLine("Цифра " + b + " в числе " + num + " находится правее, чем цифра " + a);
                }
                else if ((find_index(ToArray(num), a) == find_index(ToArray(num), b))&& find_index(ToArray(num), a)!=-1)//если а=b и они есть в числе
                {
                    Console.WriteLine("Вы ввели одинаковые цифры!");
                }
                else//если а или b нет в числе, тогда логично, что одна из цифр будет правее, тогда не надо и проверок, в общем я это вынес в отдельный вариант
                {
                    Console.WriteLine("Число "+num+" не содержит цифр "+a+" или "+b+"!");
                }
            }
            else//если отрицательное число
            {
                Console.WriteLine("Вы ввели не натуральное число!");
            }
        }
    }
}
