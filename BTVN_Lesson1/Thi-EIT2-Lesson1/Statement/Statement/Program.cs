using System;

namespace Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            IfStatement();
            SwitchCaseStatement();
            Operators();
            ForLoopStatement();
            WhileStatement();
        }
        
        static void IfStatement()
        {
            // So chan hay so le?
            Console.Write("Nhap so n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("{0} la so chan", n);
                }
                else
                {
                    Console.WriteLine("{0} la so le ", n);
                }
                if (n % 3 == 0)
                {
                    Console.WriteLine("{0} la so chia het cho 3", n);
                }
                else
                {
                    Console.WriteLine("{0} la so khong chia het cho 3", n);
                }
            }
            else
            {
                Console.WriteLine("Nhap lai n > 0");
            }
            Console.WriteLine("==========================================");
            


        }
        static void SwitchCaseStatement()
        {
            Console.Write("Nhap so thu tu tu 1 - 7 : ");
           int day0fWeek =  Convert.ToInt32(Console.ReadLine());
            switch (day0fWeek)
            {
                case 1 :
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Nhap ngay dung trong tuan (1 - 7)");
                    break;
            }
           
        }
        static void Operators()
        {
            // Tinh + - * / % cua a, b
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine($"Tong {a} + {b} = {a + b}");
            Console.WriteLine($"Hieu {a} - {b} = {a - b}");
            Console.WriteLine($"Tich {a} * {b} = {a * b}");

            if (b != 0)
            {
                Console.WriteLine($"Thuong {a} / {b} = {(float)a / b}");
                Console.WriteLine($"So du {a} % {b} = {a % b}");
            }
            else
            {
                Console.WriteLine("Nhap b khac 0");
            }
            Console.WriteLine("==========================================");

            // So sanh a va b

            if (a < b)
            {
                Console.WriteLine("{0} < {1}", a , b);
            } else if (a > b)
            {
                Console.WriteLine("{0} > {1}", a, b);

            } else
            {
                Console.WriteLine("{0} == {1}",a ,b);
            }
            Console.WriteLine("==========================================");

        }
        static void ForLoopStatement()
        {
            // Hien thi so chan le < n,tong cac chu so tu 1 ==> 10
            Console.WriteLine("Nhap so tu nhien n");
            int n = int.Parse(Console.ReadLine());
            int sum = default;
            if (n > 0)
            {
                Console.Write("Cac so chan  < {0} : ", n);
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    } 
                }
                Console.WriteLine();
                Console.Write("Cac so le  < {0} : ", n);
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
                Console.Write("Tong cac chu so : 1 + 2 + 3 + 4 + ... +  {0} = ", n);
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                Console.Write(sum);
            } else
            {
                Console.WriteLine("Nhap n > 0");
            }
            Console.WriteLine();

        }

        static void WhileStatement()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.Write(i + " ");
                i++;
            }

        }
     

    }
}
