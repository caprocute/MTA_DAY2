using System;
using System.Collections;


namespace MTA_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 0;
            Console.WriteLine("Nhập vào độ dài mảng:");
            arrayLength = int.Parse(Console.ReadLine());
            ArrayList arrNumber = new ArrayList();

            InputArray(arrNumber, arrayLength);
            printArray(arrNumber);
            OrderArray(arrNumber);
            getMaxMin(arrNumber);
            InsertNumber(arrNumber);
            arrNumber.Reverse();
            CheckPoly(arrNumber);
            printArray(arrNumber);
            CheckPoly(arrNumber);
        }

        private static void CheckPoly(ArrayList arrNumber)
        {
            int middle = arrNumber.Count % 2;

            for (int i = 0; i < middle; i++)
                for (int j = arrNumber.Count - 1; i > middle; i++) {
                    if (!arrNumber[i].Equals(arrNumber[j]))
                    { Console.WriteLine("Day khong doi xung");
                        return;
                    }
                   
                }
            Console.WriteLine("Day doi xung!");
        }
        private static void InsertNumber(ArrayList arrNumber)
        {
            Console.WriteLine("Nhập vào phần tử thứ moi");
            arrNumber.Add(Console.ReadLine());
            printArray(arrNumber);
        }

        private static void InputArray(ArrayList arr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Nhập vào phần tử thứ " + i);
                try
                {
                    arr.Add(int.Parse(Console.ReadLine()));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Nhập sai định dạng, thoát chương trình ");
                }
            }
        }

        private static void printArray(ArrayList arr)
        {
            Console.WriteLine("Mảng bạn vừa nhập là:");

            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
        private static void OrderArray(ArrayList arr)
        {
            ArrayList cloneArr= (ArrayList)arr.Clone();
            cloneArr.Sort();

            Console.WriteLine("Mảng bạn vừa nhập là:");

            for (int i = arr.Count-1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
        private static void getMaxMin(ArrayList arr)
        {
            int max = (int)arr[0];
            int count = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if ((int)arr[i] > max)
                {
                    count = 0;
                    max = (int)arr[i];
                }
                else
                if((int)arr[i]==max)
                {
                    count++;
                }
                
            }

            Console.WriteLine("Tong so phan tu co gia tri lon nhat la: " + count);
            //Console.WriteLine("Giá trị bé nhất là: " + min);

        }
      
    }

}
