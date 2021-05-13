using System;

namespace Algo001
{
    struct Str_Geminus
    {
        public int Primis, Secundus;
    }
    class Program
    {
        static int CountWays = 0;
        static void Main(string[] args)
        {
            TestCalc();

            Console.ReadKey();
        }

        static void TestCalc()
        {
            //Сравниваем вычисляемое значение и ожидаемое, 
            //итговый результат сравнения выдаётся как проверка теста
            Resulter(CalculateCount(Set(-112, 0)) == 0);
            Resulter(CalculateCount(Set(1, 1)) == 0);
            Resulter(CalculateCount(Set(2, 4)) == 4);
            Resulter(CalculateCount(Set(5, 5)) == 70);
            Resulter(CalculateCount(Set(9, 10)) == 24310);

            Console.WriteLine();
            //Проверка со случайными препятствиями
            CountWays = 0;
            int[,] Field = new int[7, 5];

            Fill(Field, 0);
            SetRandomValues(Field, 13, -1);
            Set(Field, 1, 1);

            Show(Field);

            CalculateCountWays(Field, Set(0, 0));

            Console.WriteLine(CountWays);
        }

        static void Resulter(bool value001)
        {
            if (value001)
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }
        }


        static int CalculateCount(Str_Geminus sizes001)
        {
            CountWays = 0;

            SetToOne(ref sizes001.Primis);
            SetToOne(ref sizes001.Secundus);

            int[,] someArray001 = new int[sizes001.Secundus, sizes001.Primis];

            Fill(someArray001, 0);
            //SetRandomValues(someArray001, 3, -1);
            Set(someArray001, 1, 1);

            //Show(someArray001);

            CalculateCountWays(someArray001, Set(0, 0));
            //Console.WriteLine(CountWays);

            return CountWays;
        }

        //Вычисление количества маршрутов
        static void CalculateCountWays(int[,] someArray001, Str_Geminus koords001)
        {
            Str_Geminus Right = koords001;
            ++Right.Primis;
            Str_Geminus Down = koords001;
            ++Down.Secundus;

            if (Get(someArray001, Right) == 1)
            {
                ++CountWays;
                return;
            }
            if (Get(someArray001, Right) == -1)
            {
                return;
            }
            else
            {
                if (Right.Primis > someArray001.GetLength(1))
                {
                    return;
                }
                CalculateCountWays(someArray001, Right);
            }

            if (Get(someArray001, Down) == 1)
            {
                ++CountWays;
                return;
            }
            if (Get(someArray001, Down) == -1)
            {
                return;
            }
            else
            {
                if (Down.Secundus > someArray001.GetLength(0))
                {
                    return;
                }
                CalculateCountWays(someArray001, Down);
            }
        }

        //Заполнение массива одним значением
        static void Fill(int[,] someArray001, int value001)
        {
            for (int i = 0; i < someArray001.GetLength(0); ++i)
            {
                for (int j = 0; j < someArray001.GetLength(1); ++j)
                {
                    someArray001[i, j] = value001;
                }
            }
        }

        static void SetRandomValues(int[,] someArray001, int countValues, int value001)
        {
            //Дабы не было больше чем есть в массиве
            int MaxCount = someArray001.Length * 1 / 3;
            if (countValues > MaxCount)
            {
                countValues = MaxCount;
            }

            Random Rnd001 = new Random();
            Str_Geminus Let;

            for (int i = 0; i < countValues; ++i)
            {
                do
                {
                    Let.Primis = Rnd001.Next(1, someArray001.GetLength(1));
                    Let.Secundus = Rnd001.Next(1, someArray001.GetLength(0));
                }
                while (someArray001[Let.Secundus, Let.Primis] == value001);

                someArray001[Let.Secundus, Let.Primis] = value001;
            }
        }

        static void Show(int[,] someArray001)
        {
            for (int i = 0; i < someArray001.GetLength(0); ++i)
            {
                for (int j = 0; j < someArray001.GetLength(1); ++j)
                {
                    Console.Write($"{someArray001[i, j],2}");
                }
                Console.WriteLine();
            }
        }

        //Заполнение некоторых элементов массива
        //0 - Самый первый - лево верх
        //1 - Самый последний - право низ
        static void Set(int[,] someArray001, int value001, int state001)
        {
            switch (state001)
            {
                case 0:
                    someArray001[0, 0] = value001;
                    break;
                case 1:
                    Str_Geminus Last;
                    Last.Primis = someArray001.GetLength(1) - 1;
                    Last.Secundus = someArray001.GetLength(0) - 1;

                    someArray001[Last.Secundus, Last.Primis] = value001;
                    break;
            }
        }

        //Инициализация структуры
        static Str_Geminus Set(int primis001, int pecundus001)
        {
            Str_Geminus Returnar;
            Returnar.Primis = primis001;
            Returnar.Secundus = pecundus001;

            return Returnar;
        }

        //Получение значения с проверкой на выход за пределы
        static int Get(int[,] someArray001, Str_Geminus index001)
        {
            if (CheckBorders(index001.Secundus, someArray001.GetLength(0)) && CheckBorders(index001.Primis, someArray001.GetLength(1)))
            {
                return someArray001[index001.Secundus, index001.Primis];
            }
            return 0;
        }

        //Проверка нахождения в границах
        static bool CheckBorders(int value001, int max)
        {
            if (value001 >= 0)
            {
                if (value001 < max)
                {
                    return true;
                }
            }
            return false;
        }

        static void SetToOne(ref int value001)
        {
            if (value001 < 1)
            {
                value001 = 1;
            }
        }
    }
}
