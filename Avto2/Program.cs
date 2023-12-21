using System;
using Avto2;
namespace Avto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Avto carAuto = new Avto();
            Console.WriteLine("Количество топлива: ");
            Random rand = new Random();
            int value = rand.Next(0, 3);
            string[] mas = new string[4] { "Вишнёвая семерка", "Мерседес", "Матиз", "Ока" };
            carAuto.info(mas[value], float.Parse(Console.ReadLine()), 10);
            carAuto.Outinfo();
            Random random = new Random();
            int a = random.Next(1, 200);
            Console.WriteLine($"До точки назначения осталось {a} км");
            carAuto.move(km: a);
        }
    }
}
