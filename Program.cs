using System;
using System.Linq;
namespace TestEncapsulationspace
{
        class TestEncapsulation
        {
        static void Main(string[] args)
        {
            int[] numbers = { 50, 20, 40, 10, 30 };
            Array.Sort(numbers);
            numbers = numbers.Append(2).ToArray();
         numbers = numbers.Select(x => x + 1).ToArray();
            int sum2 = numbers.Aggregate((a, b) => a + b);
    
            Console.WriteLine("sum2 = " + sum2);

            double avg = numbers.Average();
            Console.WriteLine("Average number is " + avg.ToString());
            int sum = 0;
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
                sum += num;
            }
            Console.WriteLine("Average number is " + sum.ToString());
            double divison = sum / numbers.Length;
            Console.WriteLine("divison is " + divison);

        }
        }
    }

