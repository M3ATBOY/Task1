using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько здесь человек?");
            for (int amount = Convert.ToInt32(Console.ReadLine()); amount != 0; amount--)
            {
                Console.WriteLine(amount);
                Console.WriteLine("Привет, как тебя зовут?");
                string name = Console.ReadLine();
                Console.WriteLine($"Привет,{name}.А ты любишь читать? д/н/очл/нез");
                string answer = Console.ReadLine();
                while (answer != "н" && answer != "д" && answer != "очл" && answer != "нез")
                {
                    Console.WriteLine($"{name}, ты ответил на вопрос некорректно");
                    answer = Console.ReadLine();
                    if (answer == "д" | answer == "очл")
                    {
                        Console.WriteLine("Хорошо! Книга - источник знаний.");
                    }
                    else
                    {
                        Console.WriteLine("Плохо, из книг можно узнать много интересного");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
