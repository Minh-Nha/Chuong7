namespace Chuong7_Bai4;
//Bai 4 : Mang so nguyen arrA co N phan tu, tao ra 2 mang arrB gom phan tu chan va arrC gom phan tu le
//29/11/2024
//Nguyen Ngoc Minh Nha
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

        //Khai bao arrB, arrC
        int[] arrB = new int[soPhanTuChan];
        int[] arrC = new int[soPhanTuLe];

        //Tach phan tu chan le
        TachChanLe(arrA, arrB, arrC);

        //Xuat mang arrB, arrC
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
