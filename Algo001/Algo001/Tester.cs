using System;
using System.Collections.Generic;
using System.Text;

namespace Algo001
{
    class Tester
    {
        public void TestPrimeNumber(int Number, string ExpectedResult)
        {
            if (PrimeNumber(Number) == ExpectedResult)
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }
        }

        string PrimeNumber(int Number001)
        {
            //Приводим число к границам
            MyFunc.CheckLimitataAream(ref Number001, 0, 1_000_000);

            int d = 0, i = 2;
            while (i < Number001)
            {
                if (Number001 % i == 0)
                {
                    ++d;
                }

                ++i;
            }

            if (d == 0)
            {
                return "Число простое";
            }
            return "Число НЕ простое";
        }

        public void TestRecFibonachi(int Number, int ExpectedResult)
        {
            int a = FiboIter(Number);
            int b = Fibonachi(Number);
            if (Fibonachi(Number) == ExpectedResult)
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }
        }

        public void TestIterFibonachi(int Number, int ExpectedResult)
        {
            if (FiboIter(Number) == ExpectedResult)
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }
        }

        int Fibonachi(int Number001)
        {
            //Приводим число к границам
            MyFunc.CheckLimitataAream(ref Number001, 0, 10_000);

            if (Number001 == 0 || Number001 == 1)
            {
                return Number001;
            }
            else
            {
                return Fibonachi(Number001 - 1) + Fibonachi(Number001 - 2);
            }
        }

        int FiboIter(int Number001)
        {
            //Приводим число к границам
            MyFunc.CheckLimitataAream(ref Number001, 0, 1_000_000);

            if (Number001 == 0 || Number001 == 1)
            {
                return Number001;
            }

            int previouspreviousNumber, previousNumber = 0, currentNumber = 1;

            for (int i = 1; i < Number001; i++)
            {

                previouspreviousNumber = previousNumber;

                previousNumber = currentNumber;

                currentNumber = previouspreviousNumber + previousNumber;

            }
            return currentNumber;
        }
    }
}
