using System;

namespace MTA_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 0;
            Console.WriteLine("Nhập vào độ dài mảng:");
            arrayLength = int.Parse(Console.ReadLine());
            int[] arrNumber = new int[arrayLength];

            InputArray(arrNumber, arrayLength);
            printArray(arrNumber);
            count2(arrNumber);
            getMaxMin(arrNumber);
            getMaxCount(arrNumber);

        }
        private static void InputArray(int[] arr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Nhập vào phần tử thứ " + i);
                try
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Nhập sai định dạng, thoát chương trình ");
                }
            }
        }

        private static void printArray(int[] arr)
        {
            Console.WriteLine("Mảng bạn vừa nhập là:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }

        private static void getMaxMin(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            Console.WriteLine("Giá trị lớn nhất là: " + max);
            //Console.WriteLine("Giá trị bé nhất là: " + min);

        }
        private static void count2(int[] arr)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                //count++;
            }
            Console.WriteLine("Trung bình cộng các phần tử của mảng là: " + (sum / arr.Length));
        }
        private static void getMaxCount(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            
                if (arr[i] ==5)
                {
                    count++;
                }
               
            Console.WriteLine("Số lượng các phần tử giá trị = 5 là: " + count);

        }
    }
}
