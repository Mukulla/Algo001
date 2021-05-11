using System;
using System.Collections.Generic;
using System.Text;

namespace Algo001
{
    class BuSorter
    {
        //Реализация сортировки с возвратом массива
        static public int[] Sorte(int[] SomeArray001)
        {
            int MinValue = FindMin(SomeArray001);
            int MaxValue = FindMax(SomeArray001);

            List<int>[] Blockes = new List<int>[MaxValue - MinValue + 1];
            for (int i = 0; i < Blockes.Length; ++i)
            {
                Blockes[i] = new List<int>();
            }

            for (int i = 0; i < SomeArray001.Length; ++i)
            {
                Blockes[SomeArray001[i] - MinValue].Add(SomeArray001[i]);
            }

            int[] TempoArray001 = new int[SomeArray001.Length];

            int Index = 0;
            for (int i = 0; i < Blockes.Length; ++i)
            {
                if (Blockes[i].Count > 0)
                {
                    for (int j = 0; j < Blockes[i].Count; ++j)
                    {
                        TempoArray001[Index] = Blockes[i][j];
                        ++Index;
                    }
                }
            }
            return TempoArray001;
        }
        /*
        static public void BucketSorter( int[] SomeArray001 )
        {
            int MinValue = FindMin(SomeArray001);
            int MaxValue = FindMax(SomeArray001);

            int Length = MaxValue - MinValue + 1;           

            List<int>[] Blockes = new List<int>[MaxValue - MinValue + 1];
            for (int i = 0; i < Blockes.Length; ++i)
            {
                Blockes[i] = new List<int>();
            }

            for (int i = 0; i < SomeArray001.Length; ++i)
            {
                Blockes[SomeArray001[i] - MinValue].Add(SomeArray001[i]);
            }

            int Index = 0;
            for (int i = 0; i < Blockes.Length; ++i)
            {
                if (Blockes[i].Count > 0)
                {
                    for (int j = 0; j < Blockes[i].Count; ++j)
                    {
                        SomeArray001[Index] = Blockes[i][j];
                        ++Index;
                    }
                }
            }
        }*/
        static int FindMin(int[] SomeArray001)
        {
            if (SomeArray001 == null)
            {
                return 0;
            }

            int MinValue001 = SomeArray001[0];

            for (int i = 1; i < SomeArray001.Length; ++i)
            {
                if (SomeArray001[i] < MinValue001)
                {
                    MinValue001 = SomeArray001[i];
                }
            }

            return MinValue001;
        }

        static int FindMax(int[] SomeArray001)
        {
            if (SomeArray001 == null)
            {
                return 0;
            }

            int MaxValue001 = SomeArray001[0];

            for (int i = 1; i < SomeArray001.Length; ++i)
            {
                if (SomeArray001[i] > MaxValue001)
                {
                    MaxValue001 = SomeArray001[i];
                }
            }

            return MaxValue001;
        }
        //Создание случайного массива
        static public int[] GetRandomArray(int Size, int Min001, int Max001)
        {
            Random Rnd001 = new Random();
            if (Size < 1)
            {
                Size = 1;
            }

            int[] TempoArray = new int[Size];

            for (int i = 0; i < Size; ++i)
            {
                TempoArray[i] = Rnd001.Next(Min001, Max001);
            }

            return TempoArray;
        }
        //Отобразить массив в консоли
        static public void ShowArray(int[] SomeArray001)
        {
            foreach (var Item in SomeArray001)
            {
                Console.Write($"{Item,3}");
                Console.WriteLine();
            }
        }
    }
}
