using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int[] myArray = new int[5];
            myArray[0] = 1;
            myArray[1] = 4;
            myArray[2] = 9;
            myArray[3] = 16;
            myArray[4] = 25;

            // foreach (var item in myArray)
            // {
            //     Console.WriteLine(item);
            // }

            // grab the 3rd item of the array and save it to another variable
            var someElement = myArray[2];
            // Console.WriteLine(someElement);

            Console.WriteLine("Using the collection initializer");
            // Using the collection initializer
            int[] mypArray = new int[5] { 1, 4, 9, 16, 25 };
            // foreach (var item in mypArray)
            // {
            //     Console.WriteLine(item);
            // }


            // Another way to use the collection initializer
            int[] myzArray = { 1, 4, 9, 16, 25,10 };


            // iterating over an array
            // for (int i = 0; i < myzArray.Length; i++)
            // {
            //     Console.WriteLine(myzArray[i]);
            // }
            FindMin(myzArray);
            FindMax(myzArray);
            FindAverage(myzArray);
            FindMedian(myzArray);
        }

        static void FindMin(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            int min = arr[0];
            foreach (var item in arr)
            {
                if (min>item)
                {
                    min = item;
                }
            }
            Console.WriteLine("Min: {0}", min);
        }

        static void FindMax(int[] arr) 
        {
            int max = arr[0];
            foreach (var item in arr)
            {
                if(max<item)
                {
                    max = item;
                }
            }
            Console.WriteLine("Max: {0}", max);
        }

        static void FindAverage(int[] arr)
        {
            var sum = 0;
            foreach(var item in arr)
            {
                sum += item;
            }
            Console.WriteLine("Sum: {0}", sum);
            var average = sum/arr.Length;
            Console.WriteLine("Average: {0}", average);
        }

        static void FindMedian(int[] arr) 
        {
            int index = arr.Length % 2;
            int len = arr.Length /2 ;
            if(index == 0)
            {
                float value = arr[len] + arr[len-1];
                Console.WriteLine($"Median: {value/2}");
            } 
            else 
            {
                Console.WriteLine(arr[len]);
            }
        }

    }
}