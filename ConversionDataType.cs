using System;
namespace TestConversionDataTypeNamespace
{


    class TesConversionDataType
    {


        static void MainConversionDataType(string[] args)
        {
            string nums = "12354";
            int numConvert = Convert.ToInt32(nums);
            Console.WriteLine($"convert nums: {numConvert}");
            Console.WriteLine($"convert nums double: {Convert.ToDouble(nums):f2}");
            Console.WriteLine($"parse nums : {int.Parse(nums)}");
            Console.WriteLine($"convert int : {int.IsNegative(int.Parse(nums))}");

            /// TypPase;
            if (int.TryParse(nums, out int result))
            {
                Console.WriteLine("try pase result " + result);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }

            /// conver char
            string str = "hello world";
            char resultConvert = Convert.ToChar(result);
            Console.WriteLine($"Convert char is {resultConvert}");


        }
    }
}
