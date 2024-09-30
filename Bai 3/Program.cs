using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Bai 1
            //Console.Write("Nhập vào một số nguyên: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 3 == 0)
            //{
            //    Console.WriteLine("Số {0} chia hết cho 3.", number);
            //}
            //else
            //{
            //    Console.WriteLine("Số {0} không chia hết cho 3.", number);
            //}

            // Bai 2
            //Console.Write("Nhập vào một số nguyên n: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = " + i*j);

            //    }
            //}
            // Bai 3
            //Console.Write("Nhập vào một số nguyên n: ");
            //int n = int.Parse(Console.ReadLine());
            //int scp = (int)Math.Sqrt(n);
            //if (scp * scp == n)
            //{
            //    Console.WriteLine($"Số {n} là số chính phương");
            //}
            //else
            //{
            //    Console.WriteLine($"Số {n} không phải là số chính phương");
            //}

            // Bai 5
            //Console.Write("Nhập vào tháng (1-12): ");
            //int month = int.Parse(Console.ReadLine());
            //int days = 0;

            //if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            //{
            //    days = 31;
            //}
            //else if (month == 4 || month == 6 || month == 9 || month == 11)
            //{
            //    days = 30;
            //}
            //else if (month == 2)
            //{
            //    Console.Write("Nhập vào năm: ");
            //    int year = int.Parse(Console.ReadLine());
            //    bool isLeapYear = false;

            //    if (year % 4 == 0)
            //    {
            //        if (year % 100 == 0)
            //        {
            //            if (year % 400 == 0)
            //            {
            //                isLeapYear = true;
            //            }
            //        }
            //        else
            //        {
            //            isLeapYear = true;
            //        }
            //    }

            //    if (isLeapYear)
            //    {
            //        days = 29;
            //    }
            //    else
            //    {
            //        days = 28;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Tháng không hợp lệ.");
            //    return;
            //}

            //Console.WriteLine($"Tháng {month} có {days} ngày.");

            // Bai 6
            //Console.Write("Nhập vào số nguyên n: ");
            //int n = int.Parse(Console.ReadLine());
            //long tong = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    long ketqua = 1;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        ketqua *= i;


            //    }
            //    tong += ketqua;
            //}
            //Console.WriteLine($"Tổng = {tong}");

            // Bai 7]
            //Console.Write("Nhập vào số nguyên n: ");
            //int n = int.Parse(Console.ReadLine());
            //int tong = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        tong += i;
            //    }
            //}

            //Console.WriteLine("Tổng của số lẻ là : " + tong);

            // Bai 8
            //Console.Write("Nhập số nguyên dương n: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Các số nguyên tố từ 1 đến {n} là:");

            //for (int i = 2; i <= n; i++)
            //{
            //    bool isPrime = true;

            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            // Bai 9

            //Console.Write("Nhập số hàng: ");
            //int n = int.Parse(Console.ReadLine());

            //// Vẽ tam giác thông thường
            //Console.WriteLine("\nTam giác thông thường:");
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Vẽ tam giác ngược
            //Console.WriteLine("\nTam giác ngược:");
            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Vẽ tam giác đều
            //Console.WriteLine("\nTam giác đều:");
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= 2 * i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            // Bai 10
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dãy Fibonacci với {n} phần tử là:");

            int a = 0;
            int b = 1;

            if (n >= 1)
            {
                Console.Write(a + " ");
            }
            if (n >= 2)
            {
                Console.Write(b + " ");
            }

            for (int i = 3; i <= n; i++)
            {
                int fibo = a + b;
                Console.Write(fibo + " ");
                a = b;
                b = fibo;
            }


            Console.ReadKey();
        }
    }
}
