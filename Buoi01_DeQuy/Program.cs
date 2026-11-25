using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Bai 1 Chuong 1 ===");
        Bai1Chuong1();
        Console.WriteLine("=== Bai 2 Chuong 1 ===");
        Bai2Chuong1();
        Console.WriteLine("=== Bai 3 Chuong 1 ===");
        Bai3Chuong1();
        Console.WriteLine("=== Bai 4 Chuong 1 ===");
        Bai4Chuong1();
        Console.WriteLine("=== Bai 5 Chuong 1 ===");
        Bai5Chuong1();
        Console.WriteLine("=== Bai 1 Chuong 2 ===");
        Bai1Chuong2();
        Console.WriteLine("=== Bai 2 Chuong 2 ===");
        Bai2Chuong2();
        Console.WriteLine("=== Bai 3 Chuong 2 ===");
        Bai3Chuong2();
        Console.WriteLine("=== Bai 4 Chuong 2 ===");
        Bai4Chuong2();
        Console.WriteLine("=== Bai 5 Chuong 2 ===");
        Bai5Chuong2();
        Console.WriteLine("=== Bai 6 Chuong 2 ===");
        Bai6Chuong2();
        Console.WriteLine("=== Bai 1 Chuong 3 ===");
        Bai1Chuong3();
        Console.WriteLine("=== Bai 2 Chuong 3 ===");
        Bai2Chuong3();
        Console.WriteLine("=== Bai 3 Chuong 3 ===");
        Bai3Chuong3();
        Console.WriteLine("=== Bai 4 Chuong 3 ===");
        Bai4Chuong3();
        Console.WriteLine("=== Bai 5 Chuong 3 ===");
        Bai5Chuong3();
        Console.WriteLine("=== Bai 6 Chuong 3 ===");
        Bai6Chuong3();
        Console.WriteLine("=== Bai 7 Chuong 3 ===");
        Bai7Chuong3();
        Console.WriteLine("=== Bai 8 Chuong 3 ===");
        Bai8Chuong3();
        Console.WriteLine("=== Bai 1 Phan 1 ===");
        Bai1Phan1();
        Console.WriteLine("=== Bai 2 Phan 1 ===");
        Bai2Phan1();
        Console.WriteLine("=== Bai 3 Phan 1 ===");
        Bai3Phan1();
        Console.WriteLine("=== Bai 4 Phan 1 ===");
        Bai4Phan1();
        Console.WriteLine("=== Bai 5 Phan 1 ===");
        Bai5Phan1();
        Console.WriteLine("=== Bai 6 Phan 1 ===");
        Bai6Phan1();
        Console.WriteLine("=== Bai 7 Phan 1 ===");
        Bai7Phan1();
        Console.ReadLine();
    }

    static void Bai1Chuong1()
    {
        Random rd = new Random();
        int[] arr = new int[1000];
        for (int i = 0; i < 1000; i++)
        {
            arr[i] = rd.Next(1, 100);
        }

        int max = arr[0];
        int min = arr[0];
        for (int i = 1; i < 1000; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
        Console.WriteLine("So lon nhat: " + max);
        Console.WriteLine("So nho nhat: " + min);
    }

    static void Bai2Chuong1()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) Console.Write("FizzBuzz ");
            else if (i % 3 == 0) Console.Write("Fizz ");
            else if (i % 5 == 0) Console.Write("Buzz ");
            else Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void Bai3Chuong1()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();
        string kq = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            kq = kq + s[i];
        }
        Console.WriteLine("Chuoi dao nguoc: " + kq);
    }

    static void Bai4Chuong1()
    {
        Random rd = new Random();
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rd.Next(1, 100);
        }

        Console.WriteLine("Mang ban dau: " + string.Join(", ", arr));
        Array.Sort(arr);
        Console.WriteLine("Mang sap xep: " + string.Join(", ", arr));
    }

    static void Bai5Chuong1()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        long a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        if (n <= 1) c = n;
        Console.WriteLine("So Fibonacci thu " + n + " la: " + c);
    }

    static void ThapHaNoi(int n, char nguon, char trungGian, char dich)
    {
        if (n == 0) return;
        ThapHaNoi(n - 1, nguon, dich, trungGian);
        ThapHaNoi(n - 1, trungGian, nguon, dich);
    }

    static void Bai1Chuong2()
    {
        Console.Write("Nhap so dia n: ");
        int n = int.Parse(Console.ReadLine());
        Stopwatch sw = Stopwatch.StartNew();
        ThapHaNoi(n, 'A', 'B', 'C');
        sw.Stop();
        Console.WriteLine("Thoi gian chay: " + sw.Elapsed.TotalMilliseconds + " ms");
    }

    static int TimNhiPhan(int[] arr, int trai, int phai, int x)
    {
        if (trai > phai) return -1;
        int giua = (trai + phai) / 2;
        if (arr[giua] == x) return giua;
        if (arr[giua] > x) return TimNhiPhan(arr, trai, giua - 1, x);
        return TimNhiPhan(arr, giua + 1, phai, x);
    }

    static void Bai2Chuong2()
    {
        int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int x = 15;
        Console.WriteLine("Mang: " + string.Join(", ", arr));
        Console.WriteLine("Can tim: " + x);
        int kq = TimNhiPhan(arr, 0, arr.Length - 1, x);
        if (kq == -1) Console.WriteLine("Khong tim thay");
        else Console.WriteLine("Tim thay o vi tri: " + kq);
    }

    static bool LaNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static void Bai3Chuong2()
    {
        Console.Write("Nhap so can kiem tra: ");
        int n = int.Parse(Console.ReadLine());
        if (LaNguyenTo(n)) Console.WriteLine(n + " la so nguyen to");
        else Console.WriteLine(n + " khong phai so nguyen to");
    }

    static bool LaHoanHao(int n)
    {
        if (n < 2) return false;
        int tong = 1;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0) tong = tong + i;
        }
        return tong == n;
    }

    static void Bai4Chuong2()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Cac so hoan hao nho hon " + n + ": ");
        for (int i = 1; i < n; i++)
        {
            if (LaHoanHao(i)) Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static long Fibo(int n)
    {
        if (n <= 2) return 1;
        long f1 = 1, f2 = 1, fn = 1;
        for (int i = 3; i <= n; i++)
        {
            fn = f1 + f2;
            f1 = f2;
            f2 = fn;
        }
        return fn;
    }

    static void Bai5Chuong2()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("So Fibonacci thu " + n + " la: " + Fibo(n));
    }

    static void SapXepNoiBot(double[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    double tam = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tam;
                }
            }
        }
    }

    static void Bai6Chuong2()
    {
        double[] arr = { 3.5, 1.2, 9.8, 5.4, 2.1 };
        Console.WriteLine("Mang ban dau: " + string.Join(", ", arr));
        SapXepNoiBot(arr);
        Console.WriteLine("Mang sau khi sap xep: " + string.Join(", ", arr));
    }

    static int TinhS1(int n)
    {
        if (n == 1) return 1;
        return TinhS1(n - 1) + n;
    }

    static void Bai1Chuong3()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("S(" + n + ") = " + TinhS1(n));
    }

    static int TinhS2(int n)
    {
        if (n == 1) return 1;
        return TinhS2(n - 1) + n * n;
    }

    static void Bai2Chuong3()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("S(" + n + ") = " + TinhS2(n));
    }

    static double TinhS3(int n)
    {
        if (n == 1) return 1.0;
        return TinhS3(n - 1) + 1.0 / n;
    }

    static void Bai3Chuong3()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("S(" + n + ") = " + TinhS3(n));
    }

    static double LuyThua(double x, int n)
    {
        if (n == 0) return 1;
        return LuyThua(x, n - 1) * x;
    }

    static void Bai4Chuong3()
    {
        Console.Write("Nhap co so x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Nhap so mu n: ");
        int n = int.Parse(Console.ReadLine());
        double kq;
        if (n < 0) kq = 1.0 / LuyThua(x, -n);
        else kq = LuyThua(x, n);
        Console.WriteLine(x + "^" + n + " = " + kq);
    }

    static int UocLeLonNhat(int n)
    {
        if (n % 2 == 1) return n;
        return UocLeLonNhat(n / 2);
    }

    static void Bai5Chuong3()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Uoc le lon nhat cua " + n + " la: " + UocLeLonNhat(n));
    }

    static int UCLN(int a, int b)
    {
        if (b == 0) return a;
        return UCLN(b, a % b);
    }

    static void Bai6Chuong3()
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("UCLN(" + a + ", " + b + ") = " + UCLN(Math.Abs(a), Math.Abs(b)));
    }

    static int DemChuSo(int n)
    {
        if (n < 10) return 1;
        return DemChuSo(n / 10) + 1;
    }

    static void Bai7Chuong3()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("So chu so cua " + n + " la: " + DemChuSo(Math.Abs(n)));
    }

    static double Can(int i, int n)
    {
        if (i == n) return Math.Sqrt(n);
        return Math.Sqrt(i + Can(i + 1, n));
    }

    static void Bai8Chuong3()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("S(" + n + ") = " + Can(1, n));
    }

    static int TongTu1DenN(int n)
    {
        if (n == 1) return 1;
        return n + TongTu1DenN(n - 1);
    }

    static void Bai1Phan1()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("S(" + n + ") = " + TongTu1DenN(n));
    }

    static string DaoChuoi(string s)
    {
        if (s.Length <= 1) return s;
        return DaoChuoi(s.Substring(1)) + s[0];
    }

    static void Bai2Phan1()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();
        Console.WriteLine("Chuoi dao nguoc: " + DaoChuoi(s));
    }

    static double LuyThuaDeQuy(double x, int n)
    {
        if (n == 0) return 1;
        return x * LuyThuaDeQuy(x, n - 1);
    }

    static void Bai3Phan1()
    {
        Console.Write("Nhap co so x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Nhap so mu n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(x + "^" + n + " = " + LuyThuaDeQuy(x, n));
    }

    static int TimMax(int[] arr, int n)
    {
        if (n == 1) return arr[0];
        int maxConLai = TimMax(arr, n - 1);
        if (arr[n - 1] > maxConLai) return arr[n - 1];
        return maxConLai;
    }

    static void Bai4Phan1()
    {
        Console.Write("Nhap so phan tu n: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[" + i + "] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Phan tu lon nhat: " + TimMax(arr, n));
    }

    static int SoChuSo(int n)
    {
        if (n < 10) return 1;
        return 1 + SoChuSo(n / 10);
    }

    static void Bai5Phan1()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("So chu so cua " + n + " la: " + SoChuSo(n));
    }

    static void ChuyenDia(int n, char nguon, char trungGian, char dich)
    {
        if (n == 1)
        {
            Console.WriteLine("Chuyen dia 1 tu " + nguon + " -> " + dich);
            return;
        }
        ChuyenDia(n - 1, nguon, dich, trungGian);
        Console.WriteLine("Chuyen dia " + n + " tu " + nguon + " -> " + dich);
        ChuyenDia(n - 1, trungGian, nguon, dich);
    }

    static void Bai6Phan1()
    {
        Console.Write("Nhap so dia n: ");
        int n = int.Parse(Console.ReadLine());
        ChuyenDia(n, 'A', 'B', 'C');
    }

    static void SinhNhiPhan(int[] a, int i, int n)
    {
        if (i == n)
        {
            Console.WriteLine(string.Join("", a));
            return;
        }
        a[i] = 0;
        SinhNhiPhan(a, i + 1, n);
        a[i] = 1;
        SinhNhiPhan(a, i + 1, n);
    }

    static void Bai7Phan1()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        SinhNhiPhan(a, 0, n);
    }
}