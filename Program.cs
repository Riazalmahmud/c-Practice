using System;
namespace TestDataImplicitConversionNamespace
{


    class TesImplicitConversion
    {
        private static object? f2;

        static void Main(string[] args)
        {

            int nums = 2546;
            double dobNum = nums;
            Console.WriteLine(dobNum);

            // explicit conversion
            double numsEX = 3.555;
            int intNums = (int)numsEX;
            Console.WriteLine($"explicit conversion number: {intNums:F2}");

        }
    }
}
