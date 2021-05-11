using System;
using System.Collections.Generic;
using System.Text;

namespace Algo001
{
    class Tester
    {
        //Запускт некоторого количества случайных тестов
        static public void ExecuteTest()
        {
            Random Rnd001 = new Random();
            int Length001, Min001, Max001;

            for (int i = 0; i < 7; ++i)
            {
                Length001 = Rnd001.Next(3, 23);
                Min001 = Rnd001.Next(-19, -1);
                Max001 = Rnd001.Next(1, 19);
                //Создать, отсортировать, проверить, вывести итог проверки
                Resulter(CheckerSorte(BuSorter.Sorte(BuSorter.GetRandomArray(Length001, Min001, Max001))));
            }
        }
        //Проверка сортировки - каждый следующий элемент должен быть больше текущего
        static bool CheckerSorte(int[] SomeArray001)
        {
            for (int i = 0; i < SomeArray001.Length - 1; ++i)
            {
                if (SomeArray001[i] > SomeArray001[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        //Вывод итога проверки
        static void Resulter(bool Value001)
        {
            if (Value001)
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }
        }
    }
}
