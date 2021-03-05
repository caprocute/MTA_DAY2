using System;

namespace MTA_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            while (option != 5)
            {
                PrintIntro();
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        calRectancalHThang();
                        break;
                    case 2:
                        calRectancalHBH();
                        break;
                    case 3:
                        calRectancalHThoi();
                        break;
                    case 4:
                        calRectancalHTru();
                        break;
                    case 5: {
                            Console.WriteLine("Kết thúc chương trình!");
                            break;
                        }
                   
                }
            }
        }

        static void PrintIntro()
        {
            Console.WriteLine();
            Console.WriteLine("----------------NEW-----------------");

            Console.WriteLine("Vui lòng chọn chức năng trong menu dưới đây:");
            Console.WriteLine("1. Tính chu vi và diện tích hình thang");
            Console.WriteLine("2. Tính chu vi và diện tích hình bình hành");
            Console.WriteLine("3. Tính chu vi và diện tích thoi");
            Console.WriteLine("4. Tính chu vi và diện tích hình trụ");
            Console.WriteLine("5. Kết thúc");
        }

        static void calRectancalHThang()
        {
            Console.WriteLine("Nhập vào chiều cao:");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào đáy lớn:");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào đáy bé ");
            int width2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào cạnh bên 1 ");
            int h1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào cạnh bên 2 ");
            int h2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Diện tích hình thang là: " + ((width + width2) / 2 * height));
            Console.WriteLine("Chu vi hình thang là: " + ((width2 + width+h2+h1)));

        }
        static void calRectancalHBH()
        {
            Console.WriteLine("Nhập vào chiều cao:");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào độ dài cạnh đáy:");
            int width = int.Parse(Console.ReadLine());


            Console.WriteLine("Nhập vào độ dài cạnh kề:");
            int width2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Diện tích hình bình hành là: " + ((width  * height)));
            Console.WriteLine("Chu vi hình bình hành là: " + (2*(width +width2)));

        }

        static void calRectancalHTru()
        {
            Console.WriteLine("Nhập vào chiều cao:");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào bán kính đáy:");
            int width = int.Parse(Console.ReadLine());


            Console.WriteLine("Diện tích xung quanh hình trụ là: " + ((2*3.14*height*width)));
            Console.WriteLine("Diện tích toàn phần hình trụ là: " + ((2*3.14*width*(width+height))));

            Console.WriteLine("Thể tích hình trụ là: " + (3.14*width*width*height));

        }
        static void calRectancalHThoi()
        {
            Console.WriteLine("Nhập vào đường chéo 1:");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào đường chéo 2:");
            int width = int.Parse(Console.ReadLine());


            Console.WriteLine("Nhập vào chiều dài cạnh:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Diện tích hình thoi là: " + ((1/2)*(width * height)));
            Console.WriteLine("Chu vi hình bình hành là: " + (a*4));
        }


    }

}
