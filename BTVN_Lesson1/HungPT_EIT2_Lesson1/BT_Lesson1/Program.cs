using System;

namespace BT_Lesson1
{   
    //---Nhap cac xau string
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string x1 = Console.ReadLine();
    //        string x2 = Console.ReadLine();
    //        string x3 = Console.ReadLine();
    //        Console.WriteLine("{0} {1} {2}", x3, x2, x1);
    //    }
    //}

    //---Tinh giai thua cua 1 so
    //class Program
    //{
    //    public static int InputConvertInt()
    //    {
    //        int dd = 0, ans;
    //        do
    //        {
    //            if (int.TryParse(Console.ReadLine(), out ans))
    //                dd++;
    //            else
    //                Console.WriteLine("Ban nhap ko phai la so");
    //        } while (dd == 0);
    //        return ans;
    //    }

    //    public static void Main()
    //    {
    //        Console.Write("Nhap vao 1 so n = ");
    //        int n = InputConvertInt();
    //        int ans = 1;
    //        for(int i = 1; i <= n; i++)
    //        {
    //            ans *= i;
    //        }
    //        Console.WriteLine("Giai thua cua n = {0}", ans);
    //    }
    //}

    //---Kiem tra 2 so cung la so chan ko
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Kiem tra 2 so int co cung la so chan\nMoi nhap vao 2 so");
    //        int n1, n2, dd1 = 0, dd2 = 0;
    //        do
    //        {
    //            if (int.TryParse(Console.ReadLine(), out n1))
    //                dd1++;
    //            else
    //                Console.WriteLine("Ban nhap ko phai so int, moi nhap lai");
    //        } while (dd1 == 0);
    //        do
    //        {
    //            if (int.TryParse(Console.ReadLine(), out n2))
    //                dd2++;
    //            else
    //                Console.WriteLine("Ban nhap ko phai so int, moi nhap lai");
    //        } while (dd2 == 0);

    //        string ans = ((n1 % 2 == 0) && (n2 % 2 == 0)) ? "True" : "False";
    //        Console.WriteLine(ans);
    //    }
    //}

    //---Nhap cac bo test, Moi bo test nhap vao 2 so va tinh tong
    //class Program
    //{
    //    static double InputConvertDouble()
    //    {
    //        double dd = 0, ans;
    //        do
    //        {
    //            if (double.TryParse(Console.ReadLine(), out ans))
    //                dd++;
    //            else
    //                Console.WriteLine("Ban nhap ko phai la so");
    //        } while (dd == 0);
    //        return ans;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Nhap cac bo test, Moi bo test nhap vao 2 so va tinh tong");
    //        Console.Write("Nhap vao so bo test t = ");
    //        int t = Convert.ToInt32(Console.ReadLine());
    //        while(t-- > 0)
    //        {
    //            Console.WriteLine("Nhap 2 so thuc a va b:");
    //            double a = InputConvertDouble();
    //            double b = InputConvertDouble();
    //            Console.WriteLine("Tong 2 so {0} va {1} la {2}", a, b, a + b);
    //        }
    //    }
    //}

    //---Nhap vao cac ten va chuan hoa
    //class Program
    //{
    //    public static string ChuanHoa(string str)
    //    {
    //        string ans = "";
    //        str = str.Trim();
    //        str = str.ToLower();
    //        while (str.IndexOf("  ") != -1)
    //        {
    //            str = str.Replace("  ", " ");
    //        }
    //        ans += char.ToUpper(str[0]);
    //        for (int i = 1; i < str.Length; i++)
    //        {
    //            if (str[i - 1] == ' ' && str[i] != ' ')
    //                ans += char.ToUpper(str[i]);
    //            else
    //                ans += str[i];
    //        }
    //        return ans;
    //    }
    //    public static void Main()
    //    {
    //        Console.Write("Nhap vao so pt n = ");
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        for(int i = 0; i < n; i++)
    //        {
    //            Console.Write("Nhap name = ");
    //            string name = Console.ReadLine();
    //            Console.WriteLine("Name sau khi chuan hoa: Welcome {0}", ChuanHoa(name));
    //        }
    //    }
    //}
}
