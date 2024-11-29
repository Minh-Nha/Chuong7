namespace Chuong7_Bai6;

internal class Program
{
    static void Main(string[] args)
    {
        int N = 0;
        N = NhapSoNguyen(N);
        int[] arr = NhapMangSoNguyen(N);
        //
        int mangSoDuong = DemPhanTuDuong(arr);
        int mangSoAm = N - mangSoDuong;
        //

    }

    //Tach phan tu chan le
    static void TachSoAmDuong(int[] arrA, int[] arrB, int[] arrC)
    {
        int iB = 0, iC = 0;
        foreach (int i in arrA)
        {
            if (i >= 0)
            {
                arrB[iB++] = i;
            }
            else
            {
                arrC[iC++] = i;
            }
        }
    }

    //Dem so phan tu chan
    static int DemPhanTuDuong(int[] arr)
    {
        int dem = 0;
        foreach (int i in arr)
        {
            if (i >= 0)
            {
                dem++;
            }
        }
        return dem;
    }
    //Nhap Mang So Nguyen
    static int[] NhapMangSoNguyen(int n)
    {
        int[] intArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            int.TryParse(Console.ReadLine(), out intArr[i]);
        }
        return intArr;
    }

    //Nhap so nguyen N
    static int NhapSoNguyen(int N)
    {
        Console.WriteLine("Nhap so phan tu cua mang");
        int.TryParse(Console.ReadLine(), out N);
        return N;
    }

   
}
