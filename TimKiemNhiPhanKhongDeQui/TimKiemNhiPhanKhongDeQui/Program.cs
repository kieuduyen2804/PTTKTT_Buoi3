using System;

class Program
{
    static void Main()
    {
        int[] mang = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int phanTuCanTim = 7;

        int viTri = TimKiemNhiPhanKhongDeQui(mang, phanTuCanTim);

        if (viTri != -1)
            Console.WriteLine($"Phần tử {phanTuCanTim} được tìm thấy tại vị trí: {viTri}");
        else
            Console.WriteLine($"Phần tử {phanTuCanTim} không có trong mảng.");
    }

    static int TimKiemNhiPhanKhongDeQui(int[] mang, int phanTuCanTim)
    {
        int trai = 0;
        int phai = mang.Length - 1;

        while (trai <= phai)
        {
            int giua = trai + (phai - trai) / 2;

            // Kiểm tra nếu phần tử cần tìm là phần tử giữa
            if (mang[giua] == phanTuCanTim)
                return giua;

            // Nếu phần tử cần tìm nhỏ hơn phần tử giữa, tìm kiếm trong nửa trái
            if (mang[giua] > phanTuCanTim)
                phai = giua - 1;
            else
                // Nếu phần tử cần tìm lớn hơn phần tử giữa, tìm kiếm trong nửa phải
                trai = giua + 1;
        }

        // Phần tử cần tìm không có trong mảng
        return -1;
    }
}
