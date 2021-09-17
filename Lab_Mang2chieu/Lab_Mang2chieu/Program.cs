using System;

namespace Lab_Mang2chieu
{
    class Program
    {
        public static void Nhap(int[,] A, int m, int n)
        {
            Console.WriteLine("NHAP MANG");
            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("Nhap phan tu thu [{0}][{1}]: ", i, j);
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void Xuat(int[,] A, int m, int n)
        {
            Console.WriteLine("XUAT MANG");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("A[{0}][{1}] = {2}", i, j, A[i, j]);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public static int timMax(int[,] A, int m, int n)
        {
            int max = A[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] > max) max = A[i, j];
                }
            }
            return max;
        }
        public static int timMin(int[,] A, int m, int n)
        {
            int min = A[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] < min) min = A[i, j];
                }
            }
            return min;
        }
        public static int tinhTong(int[,] A, int m, int n)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += A[i, j];
                }
            }
            return sum;
        }
        public static double trungBinh(int [,] A, int m, int n)
        {
            double sum1 = tinhTong(A, m, n);
            return sum1/(m * n);
        }
        public static int[,] Sort(int[,] A, int m, int n)
        {
            int tmp = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int q = 0; q < m; q++)
                    {
                        for (int r = 0; r < n; r++)
                        {
                            if (A[i, j] < A[q, r])
                            {
                                tmp = A[i, j];
                                A[i, j] = A[q, r];
                                A[q, r] = tmp;
                            }
                        }
                    }
                }
            }
            return A;
        }
        public static void timX(int[,] a, int m, int n)
        {
            int dem = 0;
            Console.Write("Nhap x can tim: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == x)
                    {
                        Console.WriteLine("Tim thay x tai vi tri [{0}][{1}]", i, j);
                        dem++;
                    }
                }
            }
            if (dem == 0) Console.WriteLine("Khong tim thay x trong mang");
        }

        public static int tongCheo(int[,] A, int m, int n)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) sum += A[i, j];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int m = 4, n = 5;
            //Khai báo mảng số nguyên có 4 hàng 5 cộ
            int[,] A = new int[4, 5];

            Nhap(A, m, n);
            Xuat(A, m, n);

            Console.WriteLine("Tong cac phan tu trong mang la: {0}", tinhTong(A,m,n));
            Console.WriteLine("Gia tri lon nhat trong mang la: {0}", timMax(A, m, n));
            Console.WriteLine("Gia tri nho nhat trong mang la: {0}", timMin(A, m, n));
            Console.WriteLine("Trung binh cong cua mang la: {0}",trungBinh(A, m, n));
            Console.WriteLine();
            Console.WriteLine("Cac phan tu trong mang sau khi sap xep theo thu tu: ");
            int[,] B = Sort(A, m, n);
            Xuat(B, m, n);
            timX(A, m, n);
            Console.WriteLine();
            Console.WriteLine("Tong cac phan tu tren duong cheo chinh la: {0}" ,tongCheo(A, m, n));




        }
    }
}
