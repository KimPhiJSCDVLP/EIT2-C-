using System;
using System.Collections.Generic;
namespace BTVN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //danh sach độ tuổi khách hàng
            int[] numbers = new int[] { 19, 22, 13, 64, 15, 26,8,33 };
            Console.WriteLine("Danh sach tuoi cua khach hang");
            int dem = 0;
            dem = numbers.Length;
            
            for(int i = 0; i < numbers.Length; i++)
            {
             
                Console.WriteLine("{0} ", numbers[i] );
            }
            int ktr;
            do
            {
                
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("kiem tra thong tin tuoi :  ");
                    ktr = Convert.ToInt32(Console.ReadLine());
                    if (ktr==numbers[i]) 
                    { 
                        Console.WriteLine("Nhap so tuoi nguoi xem");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                        if (numbers[i] > 18)
                        {
                            Console.Write("Tuổi người xem phim:  ");
                            Console.WriteLine("{0}", numbers[i]);


                            {
                                switch (ktr)
                                {
                                    case 22:
                                        Console.WriteLine("phim Ma");
                                        break;
                                    case 64:
                                        Console.WriteLine("phim tinh cam");
                                        break;
                                    default:
                                        Console.WriteLine("phim Hai");
                                        break;
                                }
                            }
                        }
                        else
                            Console.WriteLine("khong du tuoi xem");

                    }
                    else
                        Console.WriteLine("sai");



                }
            }
            while (numbers.Length<dem);
            Console.ReadKey();
        }
    }
}
