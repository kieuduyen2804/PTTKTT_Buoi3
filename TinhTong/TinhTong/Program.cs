using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] mang = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int tong = TinhTongChiaDeTri(mang);

        Console.WriteLine($"Tổng của mảng là: {tong}");
    }

    static int TinhTongChiaDeTri(int[] mang)
    {
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        stack.Push(new Tuple<int, int>(0, mang.Length - 1));
        int tong = 0;

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            int trai = current.Item1;
            int phai = current.Item2;

            if (trai == phai)
            {
                tong += mang[trai];
            }
            else
            {
                int giua = trai + (phai - trai) / 2;
                stack.Push(new Tuple<int, int>(trai, giua));
                stack.Push(new Tuple<int, int>(giua + 1, phai));
            }
        }

        return tong;
    }
}
