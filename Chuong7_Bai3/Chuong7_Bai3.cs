namespace Chuong7_Bai3;

internal class Chuong7_Bai3
{
    static void Main(string[] args)
    {
        int N = 0;

        // Nhập kích thước mảng
        Console.Write("Nhap so phan tu cua moi mang: ");
        int.TryParse(Console.ReadLine(), out N);    
        //
        int[] arrA = NhapMang("arrA", N);
        int[] arrB = NhapMang("arrB", N);
        int[] arrC = TinhTongMang(arrA, arrB);
        //
        XuatMang("arrC", arrC);
    }

    static void XuatMang(string tenMang, int[] arr)
    {
        Console.WriteLine($"Mang {tenMang} la: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");

        }
        Console.WriteLine();
    }

    static int[] TinhTongMang(int[] arrA, int[] arrB)
    {       
        int[] arrC = new int[arrA.Length];
        for (int i = 0; i < arrA.Length; i++)
        {
            arrC[i] = arrA[i] + arrB[i];
        }
        return arrC;
    }

    static int[] NhapMang(string tenMang,int N)
    {
        int[] arr = new int[N];
        Console.WriteLine($"Nhap vao phan tu cua mang {tenMang} : ");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"{tenMang}[{i}] = ");
            int.TryParse(Console.ReadLine(), out arr[i]);
        }
        return arr;
    }



}
