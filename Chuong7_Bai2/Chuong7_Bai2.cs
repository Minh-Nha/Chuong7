namespace Chuong7_Bai2;

internal class Chuong7_Bai2
{
    static void Main(string[] args)
    {
        int[] arr = NhapVaoMangSoNguyen();
        XuatMangSoNguyen(arr);
       
    }

    static void XuatMangSoNguyen(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }

    static int[] NhapVaoMangSoNguyen()
    {
        int[] arr = new int[100];
        int dem = 0;
        int input;
        Console.WriteLine("Nhap cac so nguyen, nhap -1 de dung");
        do
        {
            Console.WriteLine("Nhap mot so nguyen: ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input == -1)
                {
                    break;
                }
                arr[dem] = input;
                dem++;
            }else
            {
                Console.WriteLine("Gia tri khong hop le, vui long nhap lai");
            }

        } while (true);
        //
        int[] result = new int[dem];
        //Array.Copy(arr, result, dem);
        for (int i = 0; i < dem; i++)
        {
            result[i] = arr[i];
        }
        return result;
    }




}
