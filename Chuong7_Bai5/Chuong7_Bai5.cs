using System;
//Bai 5: Viet chuong trinh nhap 1 so nguyen tu 1 den 100, thuc hien cac yeu cau sau
//Ngay 28/11/2024
//Nguyen Ngoc Minh Nha
namespace Chuong7_Bai5;

internal class Chuong7_Bai5
{
    static void Main(string[] args)
    {
        int N = 0;
        //Nhap so nguyen N
        N = NhapSoNguyen(N);
        Console.WriteLine();
        //Tao cac gia tri ngau nhien tu 1 den 1000 theo N
        int[] arr = TaoMangNgauNhien(N);
        XuatMang(arr);
        Console.WriteLine();
        Console.WriteLine();
        //Gia tri lon nhat cua mang arr[]
        int giaTriLonNhat = GiaTriLonNhat(arr);
        Console.WriteLine("Gia tri lon nhat cua mang arr[] la: ");
        Console.WriteLine(giaTriLonNhat);
        Console.WriteLine();
        //Sap xep cac gia tri cua mang arr[] theo thu tu giam dan
        Console.WriteLine("Sap xep cac gia tri cua mang arr[] theo thu tu giam dan");
        GiaTriGiamDan(arr);
        XuatMang(arr);
        //Kiem tra mang co gia tri trung nhau hay khong
        Console.WriteLine();
        Console.WriteLine();
        bool coGiaTriTrungNhau = GiaTriTrungNhau(arr);
        Console.WriteLine(coGiaTriTrungNhau ? "Trong mang co gia tri trung nhau" : "Trong mang khong co gia tri trung nhau");
        
    }

    //Kiem tra mang co gia tri trung nhau hay khong
    static bool GiaTriTrungNhau(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                    return true;
            }
        }
        return false;
    }
    //Sap xep mang theo gia tri giam dan 
    static void GiaTriGiamDan(int[] arr)
    {
        Array.Sort(arr);// Phuong thuc sap xep cac gia tri cua mang theo thu tu tang dan
        Array.Reverse(arr);//Phuong thuc dao nguoc cac gia tri cua mang
    }
    //Tim gia tri lon nhat tron mang
    static int GiaTriLonNhat(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
    //Xuat mang
    static void XuatMang(int[] array)
    {
        //Console.WriteLine(string.Join(", ", array));
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
    }
    //Tao gia tri ngau nhien tu 1 den 1000 theo N
    static int[] TaoMangNgauNhien(int N)
    {
        int[] arr = new int[N];
        Console.WriteLine($"Tao {N} gia tri ngau nhien cua mang: ");
        for (int i = 0; i < N; i++)
        {
            arr[i] = Random.Shared.Next(0,1001);// Phuong thuc tao ngau nhien cac gia tri tu 1 den 1000
            
        }
        return arr;
    }
    //Nhap so nguyen N
    static int NhapSoNguyen(int N)
    {
        Console.WriteLine("Nhap so phan tu cua mang");
        int.TryParse(Console.ReadLine(), out N);
        return N;
    }
}
