using System;


namespace Lab_ngay_4
{
    class Program
    {
        public static void Nhap(int[] A)
        {
            Console.WriteLine("Nhap Mang:");
            for (int i = 0; i < A.Length; i++)
            {

                Console.Write("Nhap phan tu thu (" + i.ToString() + "):");
                A[i] = int.Parse(Console.ReadLine());
            }

        }
        public static void Xuat(int[] A)
        {
            Console.WriteLine("Xuat mang:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }
        public static int tinhTong(int[] A)
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }
            return sum;
        }
        public static int timMax(int[] A)
        {
            int max = -999;
            for (int i = 0; i < A.Length; i++)
            {
                if (max < A[i]) max = A[i];
            }
            return max;
        }
        public static int timMin(int[] A)
        {
            int min = 999;
            for (int i = 0; i < A.Length; i++)
            {
                if (min > A[i]) min = A[i];
            }
            return min;
        }

        public static int demChan(int[] A)
        {
            int dem = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] % 2 == 0)) dem++;
            }
            return dem;
        }
        public static double trungBinhCong(int[] A)
        {
            double sum1 = 0, tbc = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum1 += A[i];
            }
            tbc = sum1 / A.Length;
            return tbc;
        }
        public static int timX(int[] A, int x)
        {
            int dem = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == x) dem++;
            }
            return dem;
        }
        public static int demChan_A(int[] A)
        {
            int dem = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0) dem++;
            }
            return dem;
        }
        public static int[] mangMoi(int[] A)
        {
            int sl = demChan_A(A);
            int dem = 0;
            int[] B = new int[sl];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    B[dem++] = A[i];
                }
            }
            return B;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());

            int[] A = new int[n];

            Nhap(A);
            Xuat(A);

            Console.WriteLine();
            Console.WriteLine("Tong cac phan tu trong mang la: {0}", tinhTong(A));
            Console.WriteLine("Phan tu lon nhat cua mang la: {0}", timMax(A));
            Console.WriteLine("Phan tu nho nhat cua mang la: {0}", timMin(A));
            Console.WriteLine("So luong phan tu nguyen duong chan: {0} ", demChan(A));
            Console.WriteLine("Trung binh cong cac gia tri trong mang: {0} ", trungBinhCong(A));

            if (demChan_A(A) == 0) Console.WriteLine(" Khong co phan tu chan nao trong mang nen khong tao duoc mang moi. ");
            else
            {
                Console.WriteLine();
                Console.WriteLine("Tien hanh tao mang moi voi {0} phan tu chan tu mang truoc.", demChan_A(A));
                int[] B = mangMoi(A);
                Xuat(B);
            }

        }
    }
}
