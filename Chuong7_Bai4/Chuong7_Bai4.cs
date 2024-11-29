namespace Chuong7_Bai4;

internal class Chuong7_Bai4
{
    static void Main(string[] args)
    {
        int N = 0;
        N = NhapSoNguyen(N);
        int[] arrA = NhapMang("arrA", N);
        //Dem phan tu chan le
        int soPhanTuChan = DemPhanTuChan(arrA);
        int soPhanTuLe = N - soPhanTuChan;

        //
        int[] arrB = new int[soPhanTuChan];
        int[] arrC = new int[soPhanTuLe];

        //
        TachChanLe(arrA, arrB, arrC);

        XuatMang("arrB", arrB);
        XuatMang("arrc", arrC);

    }

    // XuatMang
    static void XuatMang(string tenMang, int[] arr)
    {
        Console.WriteLine($"Mang {tenMang} la:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    //Tach phan tu chan le
    static void TachChanLe(int[] arrA, int[] arrB, int[] arrC)
    {
        int iB = 0, iC = 0;
        foreach (int i in arrA)
        {
            if (i % 2 == 0)
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
    static int DemPhanTuChan(int[] arr)
    {
        int dem = 0;
        foreach (int i in arr)
        {
            if (i % 2 == 0)
            {
                dem++;
            }
        }
        return dem;
    }


    static int[] NhapMang(string tenMang, int N)
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

    static int NhapSoNguyen(int N)
    {
        Console.WriteLine("Nhap so phan tu cua mang");
        int.TryParse(Console.ReadLine(), out N);
        return N;
    }
}
