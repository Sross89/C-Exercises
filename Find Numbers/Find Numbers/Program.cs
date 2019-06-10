using System;


// Write a basic program that takes an array of numbers as input and computes the following:
// Minimum Value
// Maximum Value
// Sequence Length
// Average Value
namespace Find_Numbers
{
    class Program
    {
        public static int MinValue(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int MaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int SequenceLength(int[] array)
        {
            int length = array.Length;
            return length;
        }

        public static int AverageValue(int[] array)
        {
            int total = 0;
            int ave = 0;
            int count = 0;
            foreach (int num in array)
            {
                count += 1;
                total += num;
            }
            ave = total / count;
            return ave;
        }


        static void Main(string[] args)
        {
            int[] array1 = {6, 9, 15, -2, 92, 11};
            int[] array2 = { 3, 9, 15, -2, 9, 111, 74 };
            int[] array3 = { 77, 9, 15, -5, -92, 1, 13, -2, -55, 12 };
            int[] array4 = { 3, 9, 15, -200, 92, 532, 32, 21, 0 };
            int[] array5 = { 727, 95, 11, -2, 92, 13, 5, -131 };

            Console.WriteLine("There are five arrays to process: ");
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            Console.WriteLine("[{0}]", string.Join(", ", array2));
            Console.WriteLine("[{0}]", string.Join(", ", array3));
            Console.WriteLine("[{0}]", string.Join(", ", array4));
            Console.WriteLine("[{0}]", string.Join(", ", array5));

            Console.WriteLine("\nMin Numbers: ");
            Console.WriteLine(MinValue(array1));
            Console.WriteLine(MinValue(array2));
            Console.WriteLine(MinValue(array3));
            Console.WriteLine(MinValue(array4));
            Console.WriteLine(MinValue(array5));

            Console.WriteLine("\nMax Numbers: ");
            Console.WriteLine(MaxValue(array1));
            Console.WriteLine(MaxValue(array2));
            Console.WriteLine(MaxValue(array3));
            Console.WriteLine(MaxValue(array4));
            Console.WriteLine(MaxValue(array5));

            Console.WriteLine("\nSequence Length Numbers: ");
            Console.WriteLine(SequenceLength(array1));
            Console.WriteLine(SequenceLength(array2));
            Console.WriteLine(SequenceLength(array3));
            Console.WriteLine(SequenceLength(array4));
            Console.WriteLine(SequenceLength(array5));

            Console.WriteLine("\nAverage Value: ");
            Console.WriteLine(AverageValue(array1));
            Console.WriteLine(AverageValue(array2));
            Console.WriteLine(AverageValue(array3));
            Console.WriteLine(AverageValue(array4));
            Console.WriteLine(AverageValue(array5));

        }
    }
}
