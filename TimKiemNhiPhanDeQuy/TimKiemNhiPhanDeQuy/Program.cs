using System;

class Program
{
    static void Main()
    {
        int[] mang = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int phanTuCanTim = 7;

        int viTri = TimKiemNhiPhanDeQui(mang, phanTuCanTim, 0, mang.Length - 1);

        if (viTri != -1)
            Console.WriteLine($"Phần tử {phanTuCanTim} được tìm thấy tại vị trí: {viTri}");
        else
            Console.WriteLine($"Phần tử {phanTuCanTim} không có trong mảng.");
    }

    static int TimKiemNhiPhanDeQui(int[] mang, int phanTuCanTim, int trai, int phai)
    {
        if (trai > phai)
            return -1;

        int giua = trai + (phai - trai) / 2;

        if (mang[giua] == phanTuCanTim)
            return giua;

        if (mang[giua] > phanTuCanTim)
            return TimKiemNhiPhanDeQui(mang, phanTuCanTim, trai, giua - 1);

        return TimKiemNhiPhanDeQui(mang, phanTuCanTim, giua + 1, phai);
    }
}
