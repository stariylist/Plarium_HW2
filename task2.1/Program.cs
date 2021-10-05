using System;

/*В некотором году (назовем его условно первым) на участке в 100 гектаров 
 средняя урожайность ячменя составила 20 центнеров с гектара. 
 После этого каждый год площадь участка увеличивалась на 5%, а средняя урожайность — на  2%. 
 Определить: а) урожайность за второй, третий, ..., восьмой год; 
 б) площадь участка в четвертый, пятый, ..., седьмой год;
 в) какой урожай будет собран за первые шесть лет.*/
namespace task2._1
{
    class Program
    {
        public static void function()
        {
            double area = 100, productivity = 20, harvest = 0;//участок, урожайность, урожай
            int area_percent = 5, productivity_percent = 2;//приросты участка и урожайности
            for(int i = 1; i < 9; i++)
            {
                harvest += area * productivity;//вычисляем урожай
                Console.WriteLine("За " + i + "й год урожайность составила " + productivity + " центнеров с гектара.");
                productivity += Math.Round(productivity) * productivity_percent / 100; //вычисляем урожайность за год
                area += Math.Round(area) * area_percent / 100;// вычисляем участок за год
                if(i>3 && i < 8)//выводим площадь участка за 4-7 года
                {
                    Console.WriteLine("За " + i + "й год площадь участка составила " + area + " гектар.");
                }
                if (i == 6)//выводим урожай за первые 6 лет
                {
                    Console.WriteLine("Урожай за 6 лет составил " + Math.Round(harvest/10) + " тонн.");
                }
            }
            
        }
        static void Main(string[] args)
        {
            function();
        }
    }
}
