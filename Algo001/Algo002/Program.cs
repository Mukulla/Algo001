using System;

namespace Algo002
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountPars = 1;
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
                        MaLinkedList Li001 = new MaLinkedList();
                        TesterList Te001 = new TesterList();
                        Te001.TestAddNode(Li001, 2, 2, null);
                        //Li001.Show();

                        Te001.TestAddNode(Li001, 3, 3, null);
                        //Li001.Show();

                        Te001.TestAddNode(Li001, 6, 6, null);
                        //Li001.Show();

                        Node N001 = new Node();
                        N001.Value = 4;
                        Te001.TestAddNodeAfter(Li001, Li001.FindNode(3), 4, 4, null);
                        //Li001.Show();

                        Te001.TestFindNode(Li001, 2, 2, null);

                        Te001.TestGetCount(Li001, 4, null);                        

                        Te001.TestRemoveNode(Li001, 2, 4, 4, null);
                        //Li001.Show();

                        Te001.TestRemoveNode(Li001, N001, 4, null);
                        break;
                }
                if (i == 1)
                {
                    int[] Array001 = { 1, 2, 3, 4, 5 };
                    Console.WriteLine(binarySearch(Array001, 4));

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
}
