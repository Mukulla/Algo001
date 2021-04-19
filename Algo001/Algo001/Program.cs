using System;

namespace Algo001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        int binarySearch( int[] SomeArray, int SearchValue )
        {
            if( SomeArray == null )
            {
                return -1;
            }
            int Low = SomeArray[ 0 ];
            int High = SomeArray[ SomeArray.GetUpperBound( 0 ) ];
            // Repeat until the pointers Low and High meet each other
            while ( Low <= High )
            {
                int Medium = Low + ( High - Low ) / 2;

                if ( SomeArray[ Medium ] == SearchValue )
                {
                    return Medium;
                }

                if ( SomeArray[ Medium ] < SearchValue )
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
