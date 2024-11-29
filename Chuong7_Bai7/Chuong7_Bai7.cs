using System;

namespace Chuong7_Bai7;

internal class Chuong7_Bai7
{
    static void Main(string[] args)
    {
        int N = 0;
        N = NhapSoNguyen(N);
        int[] arr = NhapMang(N);
        // Xóa các phần tử bằng X
        Console.Write("Nhap gia tri X can xoa: ");
        int X = int.Parse(Console.ReadLine());
        arr = XoaPhanTuBangX(arr, X);
        Console.WriteLine("Mang sau khi da xoa cac phan tu bang X:");
        XuatMang(arr);
        //Chèn X sau số nguyên tố đầu tiên
        Console.WriteLine("Nhap gia tri X can chen vao sau so nguyen to dau tien: ");
        X = int.Parse(Console.ReadLine());
        arr = ChenSoNguyenSauSNTDauTien(arr, X);
        Console.WriteLine("Mang sau khi da chen X vao sau so nguyen to dau tien: ");
        XuatMang(arr);

    }

    static int[] ChenSoNguyenSauSNTDauTien(int[] arr, int X)
    {
        int viTriSNTDauTien = -1;

        // Tìm vị trí số nguyên tố đầu tiên
        for (int i = 0; i < arr.Length; i++)
        {
            if (KiemTraSoNguyenTo(arr[i]))
            {
                viTriSNTDauTien = i;
                break;
            }
        }

        // Nếu không có số nguyên tố, trả về mảng ban đầu
        if (viTriSNTDauTien == -1) return arr;

        // Tạo mảng mới với kích thước lớn hơn
        int[] result = new int[arr.Length + 1];

        // Sao chép các phần tử và chèn X
        for (int i = 0; i < result.Length; i++)
        {
            if (i <= viTriSNTDauTien)
            {
                result[i] = arr[i]; // Sao chép phần tử trước số nguyên tố
            }
            else if (i == viTriSNTDauTien + 1)
            {
                result[i] = X; // Chèn X
            }
            else
            {
                result[i] = arr[i - 1]; // Sao chép phần tử sau số nguyên tố
            }
        }

        return result;
    }

    //Kiem tra so nguyen to
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
    //Xuat mang
    static void XuatMang(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    //Xoa cac phan tu co gia tri bang x trong mang
    static int[] XoaPhanTuBangX(int[] arr, int X)
    {
        // Đếm số phần tử không bằng X
        int dem = 0;
        foreach (int item in arr)
        {
            if (item != X)
            {
                dem++;
            }
        }

        // Tạo mảng mới có kích thước phù hợp
        int[] result = new int[dem];
        int index = 0;

        // Gán các phần tử khác X vào mảng mới
        foreach (var item in arr)
        {
            if (item != X)
            {
                result[index++] = item;
            }
        }
        return result;
    }

    //Nhap cac gia tri trong mang
    static int[] NhapMang(int N)
    {
        int[] arr = new int[N];
        Console.WriteLine($"Nhap vao phan tu cua mang: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"arr[{i}] = ");
            int.TryParse(Console.ReadLine(), out arr[i]);
        }
        return arr;
    }
    //Nhap so phan tu trong mang
    static int NhapSoNguyen(int N)
    {
        Console.WriteLine("Nhap so phan tu cua mang");
        int.TryParse(Console.ReadLine(), out N);
        return N;
    }

}
