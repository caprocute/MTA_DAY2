using System;

namespace MTA_DAY2
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
            OrderArray(arrNumber);
            printArray(arrNumber);
            getMaxMin(arrNumber);
            count2(arrNumber);
            getMaxCount(arrNumber);
        }

        private static void InputArray(int[] arr,int length)
        {
            for (int i=0; i < length; i++)
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

        private static void OrderArray(int[] arr)
        {
            int[] cloneArr = arr;
            for (int i=0; i < arr.Length - 1; i++)
            {
                int swap;
                for (int j = i + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[j])
                    {
                        swap = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swap;
                    }
                }
            }
        }

        private static void printArray(int[] arr)
        {
            Console.WriteLine("Mảng bạn vừa nhập là:");
           
            for (int i = 0; i < arr.Length ; i++)
            {
                Console.Write(arr[i]+" ");
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
            Console.WriteLine("Giá trị bé nhất là: " + min);

        }
        private static void count2(int[] arr)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0) sum += arr[i];
                count++;
            }
            Console.WriteLine("Trung bình cộng các phần tử có chỉ số chẵn là: " + (sum/count));
        }
        private static void getMaxCount(int[] arr)
        {
            int max = arr[0];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) { max = arr[i];
                    count = 0;
                }else
                if (arr[i] == max) count++;
            }
            Console.WriteLine("Số lượng các phần tử có giá trị lớn nhất là: " + count);

        }
    }
}
