using System;

namespace LearnArray
{
    internal class Program
    {
        // Hien thi GTLN va GTNN trong mang.
        static void Main(string[] args)
        {
            Array1();
        }
        static void Array1()
        {
            Console.WriteLine("Nhap so phan tu cua mang");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap phan tu thu " + i);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                int max = numbers[0];
                int min = numbers[0];
                for (int i = 0; i < n; i++)
                {
                    if (max < numbers[i])
                    {
                        max = numbers[i];
                    }
                    if (min > numbers[i])
                    {
                        min = numbers[i];
                    }
                }
                Console.WriteLine("Gia tri lon nhat trong mang la " + max);
                Console.WriteLine("Gia tri nho nhat trong mang la " + min);
            }
            else
            {
                Console.WriteLine("Nhap n > 0");
            }
        }

    }
}
