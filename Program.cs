using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    //cai dat lop bieu dien ngan xep bang mang 1 chieu kieu so nguyen
    class Stack
    {
        //Khai bao thanh phan du lieu
        private int[] data;
        private int top;

        //dinh nghia cac phuong thuc khoi tao
        public Stack()
        {
            data = new int[100];
            top = -1;
        }
        public Stack(int size)
        {
            data = new int[size];
            top = -1;
        }
        //dinh nghia cac phuong thuc kiem tra rong
        public bool isEmpty()
        {
            bool kq = false;
            if (top == -1)
                kq = true;
            return kq;
        }
        //dinh nghia phuong thuc kiem tra day
        public bool isFull()
        {
            bool kq = false;
            if (top == data.Length-1)
                kq = true;
            return kq;
        }
        //dinh nghia phuong thuc them phan tu vao ngan xep
        public void Push(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Stack da day. Them khong thanh cong!");
            }
            else
            {
                top++;
                data[top] = x;
            }
        }
        //dinh nghia phuong thuc lay phan tu khoi ngan xep
        public int Pop()
        {
            int kq = 0;
            if (isEmpty())
            {
                Console.WriteLine("Stack da day. Them khong thanh cong!");
            }
            else
            {
                kq = data[top];
                top--;
            }
            return kq;
        }
    }
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Stack s = new Stack();
        //    s.Push(6);
        //    s.Push(7);
        //    s.Push(8);

        //    while(!s.isEmpty())
        //    {
        //        Console.Write($"{s.Pop()}");
        //    }
        //    Console.ReadLine();
        //}
        static void Main(string[] args)
        {
            //ung dung cau truc stack de doi co so 10->2
            int n;
            Console.Write("Nhap co so he 10:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap he so can doi:");
            int x = int.Parse(Console.ReadLine());
            Stack s = new Stack();
            while (n>0)
            {
                s.Push(n % x);
                n = n / x;
            }
            Console.Write($"Bieu dien he {x}:");
                while (!s.isEmpty())
            {
                Console.Write(s.Pop());
            }
            Console.ReadLine();
        }
        


        //static void Main(string[] args)
        //{
        //    convert(8);
        //    Console.ReadLine();
        //}
        //static void convert(int i)
        //{
        //    convert(i / 2);
        //    Console.Write($"i%2");
        //}
    }
}
