using System;

using MyLib;

namespace Algo001
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountPars = 3;
            string[] Denuntiatio = new string[]
            {
                "Функция по блок схеме",
                "Странный сумматор",
                "Вычисление числа Фибоначи итеративно и рекурсивно"
            };
            //Console.WriteLine(System.Text.Encoding.Default.HeaderName);
            //Цикл-обработчик каждого задания
            for (int i = 0; i < CountPars; ++i)
            {
                //Вывод части и названия задания
                Console.WriteLine($"Часть {i + 1}: {Denuntiatio[i]}");
                //Создаём класс тестер
                Tester Te001 = new Tester();

                switch (i)
                {
                    case 0:

                        Te001.TestPrimeNumber(-123, "Число простое");
                        Te001.TestPrimeNumber(126, "Число НЕ простое");
                        Te001.TestPrimeNumber(541, "Число простое");
                        break;
                    case 1:
                        int[] Array001 = { 1, 2, 23 };
                        Console.WriteLine(StrangeSum(Array001));
                        break;
                }
                if (i == 2)
                {
                    Te001.TestRecFibonachi(-156378, 0);
                    Te001.TestRecFibonachi(3, 2);
                    Te001.TestRecFibonachi(8, 123);

                    Te001.TestIterFibonachi(-153, 0);
                    Te001.TestIterFibonachi(5, 5);
                    Te001.TestIterFibonachi(12, 144);
                    Te001.TestIterFibonachi(21, 65);


                    Console.WriteLine();
                    Console.WriteLine("Все части пройдены");
                    Console.WriteLine("Для выхода нажмите любую клавишу");
                    Console.ReadKey();

                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Для перехода к следующей части нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }
            //Сложность O( 5* N^3 )

            return sum;
        }
    }
}
