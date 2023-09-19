﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class IntArray
    {
        //Field
        private int[] arr;
        //Properties
        public int Size { get => arr.Length; }
        public int[] Arr { get => arr; set => arr = value; }
        public int this[int index]
        {
            get => arr[index];
            set => arr[index] = value;
        }
        //Constructor
        public IntArray() { arr = new int[1]; arr[0] = 0; }
        public IntArray(int k)
        {
            var rd = new Random();
            if (KiemTraKT(k))
            {
                arr = new int[k];
                for (var i = 0; i < arr.Length; i++)
                {
                    arr[i] = rd.Next(1, 201);
                }
            }
        }
        public IntArray(int[] array)
        {
            arr = new int[array.Length];
            for(var i = 0; i < arr.Length; i++)
            {
                arr[i] = array[i];
            }
        }
        public IntArray(IntArray array)
        {
            arr = new int[array.arr.Length];
            for(var i = 0; i < arr.Length; i++)
            {
                arr[i] = array[i];
            }
        }
        //Method
        public bool KiemTraKT(int n)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            if (n >= 0 && n <= 1000000)
            {
                return true;
            }
            throw new Exception("Kích thước mảng từ 1 đến 1.000.000 phần tử");
        }
        public void Nhap()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Nhập kích thước mảng: ");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!KiemTraKT(n));
            arr = new int[n];
            for(var i = 0; i < arr.Length; i++)
            {
                Console.Write($"a[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }        public void Xuat()
        {
            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        public int TimTuanTu(int x)
        {
            int n = arr.Length;
            for(var i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
        public void PhatSinhTang()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var rd = new Random();
            int n;
            do
            {
                Console.Write("Nhập số lượng phần tử: ");
                n = int.Parse(Console.ReadLine());
            } while (!KiemTraKT(n));
            arr = new int[n];
            arr[0] = rd.Next(1, 5);
            for(var i = 1; i < n; i++)
            {
                arr[i] = arr[i - 1] + rd.Next(1, 5);
            }
        }
        public int TimNhiPhan(int x)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (arr[mid] == x)
                    return mid;
                else if (arr[mid] > x)
                    right = mid - 1;
                else if (arr[mid] < x)
                    left = mid + 1;
            }
            return -1;
        }
    }
}
