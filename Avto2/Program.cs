﻿using System;
using Avto2;
namespace Avto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Avto carAuto = new Avto();
            Console.WriteLine("Количество топлива: ");
            carAuto.info("1ААА23", float.Parse(Console.ReadLine()), 10.0F);
            carAuto.outinfo();
            Random random = new Random();
            int a = random.Next(1, 200);
            Console.WriteLine($"До кабинета 1.11 (ДАЛЬШЕ БОГА НЕТ, до него осталось {a} км)");//эту часть кода придумал не я
            carAuto.move(km: a);
        }
    }
}