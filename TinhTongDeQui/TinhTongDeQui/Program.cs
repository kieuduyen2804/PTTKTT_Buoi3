using System;

class Program
{
    static void Main()
    {
        int[] mang = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int tong = TinhTongChiaDeTri(mang, 0, mang.Length - 1);

        Console.WriteLine($"Tổng của mảng là: {tong}");
    }

    static int TinhTongChiaDeTri(int[] mang, int trai, int phai)
    {
        if (trai == phai)
        {
            return mang[trai];
        }

        int giua = trai + (phai - trai) / 2;
        int tongTrai = TinhTongChiaDeTri(mang, trai, giua);
        int tongPhai = TinhTongChiaDeTri(mang, giua + 1, phai);

        return tongTrai + tongPhai;
    }
}
