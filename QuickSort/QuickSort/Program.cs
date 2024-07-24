using System;

class Program
{
    static void Main()
    {
        int[] mang = { 34, 7, 23, 32, 5, 62 };
        Console.WriteLine("Mảng gốc: ");
        InMang(mang);

        QuickSort(mang, 0, mang.Length - 1);

        Console.WriteLine("\nMảng sau khi sắp xếp: ");
        InMang(mang);
    }

    static void QuickSort(int[] mang, int trai, int phai)
    {
        if (trai < phai)
        {
            int viTriPivot = PhanHoach(mang, trai, phai);
            QuickSort(mang, trai, viTriPivot - 1);
            QuickSort(mang, viTriPivot + 1, phai);
        }
    }

    static int PhanHoach(int[] mang, int trai, int phai)
    {
        int pivot = mang[phai];
        int i = trai - 1;

        for (int j = trai; j < phai; j++)
        {
            if (mang[j] < pivot)
            {
                i++;
                HoanVi(mang, i, j);
            }
        }
        HoanVi(mang, i + 1, phai);
        return i + 1;
    }

    static void HoanVi(int[] mang, int i, int j)
    {
        int tam = mang[i];
        mang[i] = mang[j];
        mang[j] = tam;
    }

    static void InMang(int[] mang)
    {
        foreach (int phanTu in mang)
        {
            Console.Write(phanTu + " ");
        }
        Console.WriteLine();
    }
}
