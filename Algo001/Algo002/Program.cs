using System;

namespace Algo002
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountPars = 2;
            string[] Denuntiatio = new string[]
            {
                "Тест двусвязного списка",
                "Бинарный поиск"
            };
            //Console.WriteLine(System.Text.Encoding.Default.HeaderName);
            //Цикл-обработчик каждого задания
            for (int i = 0; i < CountPars; ++i)
            {
                //Вывод части и названия задания
                Console.WriteLine($"Часть {i + 1}: {Denuntiatio[i]}");

                switch (i)
                {
                    case 0:
                        TesterList Te001 = new TesterList();
                        break;
                }
                if (i == 1)
                {
                    WriteToBinare Binarrer = new WriteToBinare();
                    Binarrer.ReadNumbers();
                    Binarrer.Write("Numbers.bin");
                    Binarrer.Show("Numbers.bin");

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

            //O( Log2( N ) )
            int binarySearch(int[] SomeArray, int SearchValue)
            {
                if (SomeArray == null)
                {
                    return -1;
                }
                int Low = SomeArray[0];
                int High = SomeArray[SomeArray.GetUpperBound(0)];
                // Repeat until the pointers Low and High meet each other
                while (Low <= High)
                {
                    int Medium = Low + (High - Low) / 2;

                    if (SomeArray[Medium] == SearchValue)
                    {
                        return Medium;
                    }

                    if (SomeArray[Medium] < SearchValue)
                    {
                        Low = Medium + 1;
                    }
                    else
                    {
                        High = Medium - 1;
                    }
                }

                return -1;
            }
        }
}
