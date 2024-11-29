namespace Chuong7_Bai1;
//Bai 1: Viet chuong trinh nhap 1 so nguyen tu 1 den 100, thuc hien cac yeu cau sau
//Ngay 28/11/2024
//Nguyen Ngoc Minh Nha
internal class Chuong7_Bai1
{
    static void Main(string[] args)
    {
        int n = 0;

        n = NhapVaoMotSoNguyen(n);
        //A.Nhap mang so nguyen n phan tu
        Console.WriteLine($"A.Nhap mang so nguyen voi n la {n} phan tu");
        int[] arr = NhapMangSoNguyen(n);
        Console.WriteLine();
        //B.Xuat mang vua nhap
        Console.WriteLine("B.Xuat mang vua nhap");
        XuatMangSoNguyen(arr);
        Console.WriteLine();
        Console.WriteLine();
        //C.Xuat cac so chan trong mang
        Console.WriteLine("C.Xuat cac so chan trong mang");
        XuatSoChanTrongMang(arr);
        Console.WriteLine();
        Console.WriteLine();
        //D.Xuat cac so la so nguyen to trong mang
        Console.WriteLine("D.Xuat cac so nguyen to trong mang");
        XuatSoNguyenToTrongMang(arr);
        Console.WriteLine();
        Console.WriteLine();
        //E.Tinh trung binh cong cac phan tu trong mang
        Console.WriteLine("E.Tinh trung binh cong trong mang");
        TinhTrungBinhCongMang(arr);
        Console.WriteLine();
        //F.Dem so luong so hoan thien co trong mang
        Console.WriteLine("F.Dem so hoan thien trong mang");
        DemSoLuongSoHoanThien(arr);
        Console.WriteLine();
        //G.Tim kiem vi tri cuoi cung cua phan tu x trong mang
        Console.WriteLine("G.Tim vi tri cuoi cung cua phan tu x trong mang");
        int x = 0;
        Console.WriteLine("Nhap gia tri muon tim x = ");
        int.TryParse(Console.ReadLine(), out x);

        int vt = TimViTriCuoiCungCuaPhanTuTrongMang(arr, x);
        if (vt == -1)
        {
            Console.WriteLine($"Khong tim thay {x} trong mang");
        }
        else
        {
            Console.WriteLine($"Vi tri cuoi cung cua {x} trong mang la {vt}");
        }
        //H.Tim vi tri so nguyen to dau tien trong mang neu co 
        Console.WriteLine();     
        Console.WriteLine("H.Tim vi tri so nguyen to dau tien trong mang neu co ");
        SoNguyenToDauTien(arr);
        Console.WriteLine();
        //I.Tim phan tu lon nhat trong mang
        Console.WriteLine("I.Tim phan tu lon nhat trong mang");
        PhanTuLonNhat(arr);
        Console.WriteLine();
        //J.Tìm số dương nhỏ nhất trong mảng
        Console.WriteLine("J.Tim so duong nho nhat trong mang");
        SoDuongNhoNhat(arr);
        Console.WriteLine();
        //K.Sap xep cac phan tu cua mang theo thu tu tang dan
        Console.WriteLine("K.Sap xep cac phan tu cua mang theo thu tu tang dan");
        SapXepTangDan(arr);
        Console.WriteLine();
        Console.WriteLine();
        //L.Kiem tra mang co thu tu tang khong
        Console.WriteLine("L.Kiem tra mang co thu tu tang khong");
        bool thuTuTangDan = ThuTuTangDan(arr);
        Console.WriteLine(thuTuTangDan == true ? "Mang co thu tu tang dan" : "Mang khong co thu tu tang dan");
        Console.WriteLine();
    }

    //L.Kiem tra mang co thu tu tang hay khong
    static bool ThuTuTangDan(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    //K.Sap xep cac phan tu cua mang theo thu tu tang dan
    static void SapXepTangDan(int[] arr)
    {
        Array.Sort(arr);
        Console.WriteLine("Mang sau khi tang dan: ");
        XuatMangSoNguyen(arr);
    }

    //J.Tim so duong nho nhat trong mang
    static void SoDuongNhoNhat(int[] arr)
    {
        int min = int.MaxValue;
        bool found = false;

        foreach (int i in arr)
        {
            if (i < min && i >= 0 )
            {
               min = i;
               found = true;
            }
        }
        if (found)
        {
            Console.WriteLine($"So duong nho nhat trong mang la {min}");
        }else
        {
            Console.WriteLine("Mang khong co so duong nao");
        }
    }

    //I.Tim phan tu lon nhat trong mang
    static void PhanTuLonNhat(int[] arr)
    {
        int max = arr[0];
        foreach (int i in arr)
        {
            if (i > max)
            {
                max = i;
            }    
        }
        Console.WriteLine($"Phan tu lon nhat trong mang la {max}");
    }

    //H.Tim vi tri so nguyen to dau tien trong mang neu co 
    static void SoNguyenToDauTien(int[] arr)
    {
        //int dem = 0;
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (KiemTraSoNguyenTo(arr[i]))
        //    {
        //        dem++;
        //        if (dem == 1)
        //        {
        //            Console.WriteLine($"Vi tri so nguyen to dau tien trong mang la vi tri thu a[{i}]");
        //        }            
        //    }
        //}

        bool found = false;
        for (int i = 0; i < arr.Length; i++) 
        {
            if(KiemTraSoNguyenTo(arr[i]))
            {
                Console.WriteLine($"Vi tri so nguyen to dau tien trong mang la vi tri thu a[{i}]");
                found = true;
                break;
            }
        }
        if (!found) 
        {
            Console.WriteLine("Mang khong co so nguyen to nao");
        }
    }

    //G.Tim vi tri cuoi cung cua x trong mang
    static int TimViTriCuoiCungCuaPhanTuTrongMang(int[] arr, int x)
    {
        int vt = -1;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
            {
                vt = i;
                break;
            }
        }
        return vt;
    }

    //f.Dem so luong so hoan thien co trong mang
    static void DemSoLuongSoHoanThien(int[] arr)
    {
        int dem = 0;
        foreach (var item in arr)
        {
            if (KiemTraSoHoanThien(item))
            {
                dem++;
            }
        }
        Console.WriteLine(dem); ;
    }

    static bool KiemTraSoHoanThien(int n)
    {
        long tongUS = TinhTongCacUocSo(n) - n;
        return tongUS == n;
    }

    static long TinhTongCacUocSo(int number)
    {
        long tongUS = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                tongUS += i;
            }
        }
        return tongUS;
    }

    //e.Tinh trung binh cong cac phan tu trong mang
    static void TinhTrungBinhCongMang(int[] arr)
    {
        double tong = 0;
        double trungBinhCong = 0;
        foreach (var item in arr)
        {
            tong += item;
        }
        trungBinhCong = tong / arr.Length;
        Console.WriteLine($"Trung binh cong cua mang: {trungBinhCong}");

    }

    //d.Xuat cac so nguyen to co trong mang
    static void XuatSoNguyenToTrongMang(int[] arr)
    {
        foreach (var item in arr)
        {
            if (KiemTraSoNguyenTo(item))
            {
                Console.Write(item + " ");
            }
        }
    }

    static bool KiemTraSoNguyenTo(int n)
    {
        if (n < 2)
            return false;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    //c.Xuat cac so chan trong mang
    static void XuatSoChanTrongMang(int[] arr)
    {
        foreach (var item in arr)
        {
            if (item % 2 == 0)
            {
                Console.Write(item + " ");
            }
        }
    }

    //b.Xuat mang vua nhap
    static void XuatMangSoNguyen(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }

    //a.Nhap mang so nguyen n phan tu
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

    //1.NhapVaoMotSoNguyen
    static int NhapVaoMotSoNguyen(int n)
    {
        do
        {
            Console.WriteLine("Nhap vao 1 so nguyen voi 1<=n<=100: ");
            int.TryParse(Console.ReadLine(), out n);
            if (1 > n || n > 100)
            {
                Console.WriteLine("Nhap sai vui long nhap lai");
            }

        }
        while (1 > n || n > 100);
        return n;
    }
}
