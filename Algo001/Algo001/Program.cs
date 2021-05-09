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


        static int CalculateCount(Str_Geminus Sizes001)
        {
            CountWays = 0;

            SetToOne(ref Sizes001.Primis);
            SetToOne(ref Sizes001.Secundus);

            int[,] SomeArray001 = new int[Sizes001.Secundus, Sizes001.Primis];

            Fill(SomeArray001, 0);
            //SetRandomValues(SomeArray001, 3, -1);
            Set(SomeArray001, 1, 1);

            //Show(SomeArray001);

            CalculateCountWays(SomeArray001, Set(0, 0));
            //Console.WriteLine(CountWays);

            return CountWays;
        }

        //Вычисление количества маршрутов
        static void CalculateCountWays(int[,] SomeArray001, Str_Geminus Koords001)
        {
            Str_Geminus Right = Koords001;
            ++Right.Primis;
            Str_Geminus Down = Koords001;
            ++Down.Secundus;

            if (Get(SomeArray001, Right) == 1)
            {
                ++CountWays;
                return;
            }
            if (Get(SomeArray001, Right) == -1)
            {
                return;
            }
            else
            {
                if (Right.Primis > SomeArray001.GetLength(1))
                {
                    return;
                }
                CalculateCountWays(SomeArray001, Right);
            }

            if (Get(SomeArray001, Down) == 1)
            {
                ++CountWays;
                return;
            }
            if (Get(SomeArray001, Down) == -1)
            {
                return;
            }
            else
            {
                if (Down.Secundus > SomeArray001.GetLength(0))
                {
                    return;
                }
                CalculateCountWays(SomeArray001, Down);
            }
        }

        //Заполнение массива одним значением
        static void Fill(int[,] SomeArray001, int Value001)
        {
            for (int i = 0; i < SomeArray001.GetLength(0); ++i)
            {
                for (int j = 0; j < SomeArray001.GetLength(1); ++j)
                {
                    SomeArray001[i, j] = Value001;
                }
            }
        }

        static void SetRandomValues(int[,] SomeArray001, int CountValues, int Value001)
        {
            //Дабы не было больше чем есть в массиве
            int MaxCount = SomeArray001.Length * 1 / 3;
            if (CountValues > MaxCount)
            {
                CountValues = MaxCount;
            }

            Random Rnd001 = new Random();
            Str_Geminus Let;

            for (int i = 0; i < CountValues; ++i)
            {
                do
                {
                    Let.Primis = Rnd001.Next(1, SomeArray001.GetLength(1));
                    Let.Secundus = Rnd001.Next(1, SomeArray001.GetLength(0));
                }
                while (SomeArray001[Let.Secundus, Let.Primis] == Value001);

                SomeArray001[Let.Secundus, Let.Primis] = Value001;
            }
        }

        static void Show(int[,] SomeArray001)
        {
            for (int i = 0; i < SomeArray001.GetLength(0); ++i)
            {
                for (int j = 0; j < SomeArray001.GetLength(1); ++j)
                {
                    Console.Write($"{SomeArray001[i, j],2}");
                }
                Console.WriteLine();
            }
        }

        //Заполнение некоторых элементов массива
        //0 - Самый первый - лево верх
        //1 - Самый последний - право низ
        static void Set(int[,] SomeArray001, int Value001, int State001)
        {
            switch (State001)
            {
                case 0:
                    SomeArray001[0, 0] = Value001;
                    break;
                case 1:
                    Str_Geminus Last;
                    Last.Primis = SomeArray001.GetLength(1) - 1;
                    Last.Secundus = SomeArray001.GetLength(0) - 1;

                    SomeArray001[Last.Secundus, Last.Primis] = Value001;
                    break;
            }
        }

        //Инициализация структуры
        static Str_Geminus Set(int Primis001, int Secundus001)
        {
            Str_Geminus Returnar;
            Returnar.Primis = Primis001;
            Returnar.Secundus = Secundus001;

            return Returnar;
        }

        //Получение значения с проверкой на выход за пределы
        static int Get(int[,] SomeArray001, Str_Geminus Index001)
        {
            if (CheckBorders(Index001.Secundus, SomeArray001.GetLength(0)) && CheckBorders(Index001.Primis, SomeArray001.GetLength(1)))
            {
                return SomeArray001[Index001.Secundus, Index001.Primis];
            }
            return 0;
        }

        //Проверка нахождения в границах
        static bool CheckBorders(int Value001, int Max)
        {
            if (Value001 >= 0)
            {
                if (Value001 < Max)
                {
                    return true;
                }
            }
            return false;
        }

        static void SetToOne(ref int Value001)
        {
            if (Value001 < 1)
            {
                Value001 = 1;
            }
        }
    }
}
