using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avto2;

namespace Avto2
{
    internal class Avto
    {
        
            private string number;
            private float fuel;
            private float rashod;

            public void info(string number, float fuel, float rashod)
            {
                this.number = number;
                this.fuel = fuel;
                this.rashod = rashod;
            }
            public void Outinfo()
            {
                
            Console.WriteLine($"Номер: {this.number}\n");
            Console.WriteLine($"Топливо: {this.fuel} \n");
            Console.WriteLine($"Расход: {this.rashod}\n");

            }

            public void zaprawka(float top)
            {
                this.fuel += top;
            }
            public void move(int km)
            {

                float ostatok = this.fuel - (km * (this.rashod) / 100);
                if (ostatok > 0)
                {
                    Console.WriteLine($"Машина доехала до точки назначения, а в баке осталось {ostatok} л.");
                }
                if (ostatok < 0)
                {
                    Console.WriteLine("Машина не доедет, нужно долить бензина:");
                    zaprawka(float.Parse(Console.ReadLine()));
                    if (ostatok > 0)
                    {
                        Console.WriteLine($"Машина доехала до точки назначения, а в баке осталось{ostatok} л.");
                    }
                    if (ostatok < 0)
                    {
                        float for_ostatok = (ostatok * (- 1));
                        Console.WriteLine($"Машине не хватило бензина, нужно было долить {for_ostatok:F1} л");
                    }
                }


            }
        }
    }

