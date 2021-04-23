using System;
using System.Collections.Generic;
using System.Text;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Algo003
{
    public class Cls_Point
    {
        public float x, y;
    }

    public struct Str_PointF
    {
        public float x, y;
    }

    public struct Str_PointD
    {
        public double x, y;
    }
    public class BechmarkClass
    {
        int Iterations = 97;       

        [Benchmark]
        public void TestRef()
        {
            for (int i = 0; i < Iterations; ++i)
            {
                Reference(SetRandomCls(1,23), SetRandomCls(1, 29));
                //TurboReference(SetRandomCls(1,23), SetRandomCls(1, 29));
            }
        }

        [Benchmark]
        public void TestValueF()
        {
            for (int i = 0; i < Iterations; ++i)
            {
                ValueyedF(SetRandomStrF(1, 31), SetRandomStrF(1, 37));
            }
        }

        [Benchmark]
        public void TestValueD()
        {
            for (int i = 0; i < Iterations; ++i)
            {
                ValueyedD(SetRandomStrD(1, 73), SetRandomStrD(1, 79));
            }
        }

        [Benchmark]
        public void TestValueShort()
        {
            for (int i = 0; i < Iterations; ++i)
            {
                PointDistanceShort(SetRandomStrF(1, 43), SetRandomStrF(1, 47));
            }
        }




        public float Reference(Cls_Point pointOne, Cls_Point pointTwo)
        {
            float x = pointOne.x - pointTwo.x;
            float y = pointOne.y - pointTwo.y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        
        public float ValueyedF(Str_PointF pointOne, Str_PointF pointTwo)
        {
            float x = pointOne.x - pointTwo.x;
            float y = pointOne.y - pointTwo.y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public double ValueyedD(Str_PointD pointOne, Str_PointD pointTwo)
        {
            double x = pointOne.x - pointTwo.x;
            double y = pointOne.y - pointTwo.y;
            return Math.Sqrt((x * x) + (y * y));
        }

        public float PointDistanceShort(Str_PointF pointOne, Str_PointF pointTwo)
        {
            float x = pointOne.x - pointTwo.x;
            float y = pointOne.y - pointTwo.y;
            return (x * x) + (y * y);
        }

        public float TurboReference(Cls_Point A, Cls_Point B)
        {
            float TempoX = MyCalcu.Do(A.x, B.x, 1);
            TempoX = MyCalcu.Do(TempoX, TempoX, 2);

            float TempoY = MyCalcu.Do(A.y, B.y, 1);
            TempoY = MyCalcu.Do(TempoY, TempoY, 2);

            return MathF.Sqrt(TempoX + TempoY);
        }

        public Cls_Point SetRandomCls(int MinValue, int MaxValue)
        {
            Cls_Point TempoPoint = new Cls_Point();
            Random Rnd001 = new Random();
            TempoPoint.x = Rnd001.Next(MinValue, MaxValue);
            TempoPoint.y = Rnd001.Next(MinValue, MaxValue);

            return TempoPoint;
        }

        public Str_PointF SetRandomStrF(int MinValue, int MaxValue)
        {
            Str_PointF TempoPoint;
            Random Rnd001 = new Random();
            TempoPoint.x = Rnd001.Next(MinValue, MaxValue);
            TempoPoint.y = Rnd001.Next(MinValue, MaxValue);

            return TempoPoint;
        }

        public Str_PointD SetRandomStrD(int MinValue, int MaxValue)
        {
            Str_PointD TempoPoint;
            Random Rnd001 = new Random();
            TempoPoint.x = Rnd001.Next(MinValue, MaxValue);
            TempoPoint.y = Rnd001.Next(MinValue, MaxValue);

            return TempoPoint;
        }

        public float Do(float First, float Second, int NumberAction)
        {
            if (Second == 0.0f)
            {
                return 0.0f;
            }

            switch (NumberAction)
            {
                case 0:
                    return First + Second;
                case 1:
                    return First - Second;
                case 2:
                    return First * Second;
                case 3:
                    return First / Second;
            }

            return 0.0f;
        }
    }
}
